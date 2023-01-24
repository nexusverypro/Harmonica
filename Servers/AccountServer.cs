// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Configs;
using Newtonsoft.Json;
using RecNet;
using RestSharp;
using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace Servers
{
  internal class AccountServer
  {
    private HttpListener listener = new HttpListener();

    public AccountServer()
    {
      try
      {
        Console.WriteLine("[AccountServer] has started.");
        new Thread(new ThreadStart(this.StartListen)).Start();
      }
      catch (Exception ex)
      {
        Console.WriteLine("An Exception Occurred while Listening :" + ex.ToString());
      }
    }

    private void StartListen()
    {
      this.listener.Prefixes.Add(string.Format("http://+:{0}/", (object) Config.accountServerPort));
      while (true)
      {
        this.listener.Start();
        Console.WriteLine("[AccountServer] is running.");
        HttpListenerContext context = this.listener.GetContext();
        HttpListenerRequest request = context.Request;
        HttpListenerResponse response = context.Response;
        string rawUrl = request.RawUrl;
        string end;
        using (StreamReader streamReader = new StreamReader(request.InputStream, request.ContentEncoding))
          end = streamReader.ReadToEnd();
        Console.ForegroundColor = ConsoleColor.Blue;
        if (Config.LogMessages)
          Console.WriteLine("RAWURL: http://localhost:" + (object) Config.accountServerPort + request.RawUrl + " | HTTPMETHOD: " + request.HttpMethod + " | POSTDATA: " + end);
        NameValueCollection headers = request.Headers;
        string str = "";
        for (int index = 0; index < request.Headers.Count; ++index)
        {
          string key = headers.GetKey(index);
          Console.WriteLine(key + " : " + headers.GetValues(key)[0]);
          if (key == "Authorization")
            str = headers.GetValues("Authorization")[0];
        }
        string s = "";
        if (rawUrl == "/account/me")
        {
          RestClient restClient = new RestClient("https://accounts.rec.net/account/me");
          RestRequest restRequest = new RestRequest(Method.GET);
          restRequest.AddHeader("Authorization", str);
          s = restClient.Execute((IRestRequest) restRequest).Content;
        }
        if (rawUrl.StartsWith("/account/bulk?id="))
        {
          RestClient restClient = new RestClient("https://accounts.rec.net" + rawUrl);
          RestRequest restRequest = new RestRequest(Method.GET);
          restRequest.AddHeader("Authorization", str);
          s = restClient.Execute((IRestRequest) restRequest).Content;
        }
        if (rawUrl.StartsWith("/account/create"))
        {
          if (true)
          {
            RestClient restClient = new RestClient("https://accounts.rec.net/account/create");
            RestRequest restRequest = new RestRequest(Method.POST);
            restRequest.AddParameter("platform", (object) "1");
            restRequest.AddParameter("platformId", (object) "2727391827299817");
            restRequest.AddParameter("deviceId", (object) AccountServer.generateDeviceId());
            s = restClient.Execute((IRestRequest) restRequest).Content;
          }
          else
            s = "{\"success\":false,\"error\":\"Oops!\r\nHarmonica doesn't support creating accounts yet.\r\n[code: create]\"}";
        }
        if (rawUrl.StartsWith("/account/") && rawUrl.EndsWith("/bio"))
          s = JsonConvert.SerializeObject((object) new Accounts.AccountBioResponseDTO()
          {
            accountId = 1,
            bio = "Welcome to harmonica!"
          });
        Thread.Sleep(400);
        Console.WriteLine(rawUrl);
        Console.WriteLine(s);
        if (Config.LogMessages)
          Console.WriteLine("Account Data: " + s);
        byte[] bytes = Encoding.UTF8.GetBytes(s);
        response.ContentLength64 = (long) bytes.Length;
        Stream outputStream = response.OutputStream;
        outputStream.Write(bytes, 0, bytes.Length);
        Thread.Sleep(200);
        outputStream.Close();
        this.listener.Stop();
      }
    }

    public static string generateDeviceId() => new RestClient("https://www.345tool.com/api/generate/id").Execute((IRestRequest) new RestRequest(Method.POST)).Content;

    public class CreateAccountDTO
    {
      public bool success { get; set; }

      public AccountServer.AccountCreationData value { get; set; }
    }

    public class AccountCreationData
    {
      public int accountId { get; set; }

      public string username { get; set; }

      public string displayName { get; set; }

      public string profileImage { get; set; }

      public bool? isJunior { get; set; }

      public int platforms { get; set; }

      public DateTime createdAt { get; set; }
    }
  }
}

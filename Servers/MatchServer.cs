// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Configs;
using RestSharp;
using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace Servers
{
  internal class MatchServer
  {
    private HttpListener listener = new HttpListener();

    public MatchServer()
    {
      try
      {
        if (Config.LogMessages)
          Console.WriteLine("[MatchServer] has started.");
        new Thread(new ThreadStart(this.StartListen)).Start();
      }
      catch (Exception ex)
      {
        Console.WriteLine("An Exception Occurred while Listening :" + ex.ToString());
      }
    }

    private void StartListen()
    {
      this.listener.Prefixes.Add(string.Format("http://+:{0}/", (object) Config.matchServerPort));
      while (true)
      {
        this.listener.Start();
        if (Config.LogMessages)
          Console.WriteLine("[MatchServer] is listening for a request.");
        HttpListenerContext context = this.listener.GetContext();
        HttpListenerRequest request = context.Request;
        HttpListenerResponse response = context.Response;
        string s = "";
        string rawUrl = request.RawUrl;
        string end;
        using (StreamReader streamReader = new StreamReader(request.InputStream, request.ContentEncoding))
          end = streamReader.ReadToEnd();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        if (Config.LogMessages)
          Console.WriteLine("RAWURL: http://localhost:" + (object) Config.matchServerPort + request.RawUrl + " | HTTPMETHOD: " + request.HttpMethod + " | POSTDATA: " + end);
        string str1 = "";
        NameValueCollection headers = request.Headers;
        for (int index = 0; index < request.Headers.Count; ++index)
        {
          string key = headers.GetKey(index);
          Console.WriteLine(key + " : " + headers.GetValues(key)[0]);
          if (key == "Authorization")
          {
            string str2 = headers.GetValues("Authorization")[0];
          }
          if (key == "X-RNSIG")
            str1 = headers.GetValues(key)[0];
        }
        RestClient restClient = new RestClient("http://match.rec.net");
        RestRequest restRequest1 = new RestRequest(rawUrl, MatchServer.ParseMethod(request.HttpMethod));
        restRequest1.AddHeader("Authorization", "Bearer eyJhbGciOiJSUzI1NiIsImtpZCI6ImFIWEFmR1dEWjZXMTNIYWd5U3FPZlZtVFUyRSIsInR5cCI6IkpXVCIsIng1dCI6ImFIWEFmR1dEWjZXMTNIYWd5U3FPZlZtVFUyRSJ9.eyJuYmYiOjE2MzQ5Mjc5NTEsImV4cCI6MTYzNDk3MTE1MSwiaXNzIjoiaHR0cHM6Ly9hdXRoLnJlYy5uZXQiLCJhdWQiOlsiaHR0cHM6Ly9hdXRoLnJlYy5uZXQvcmVzb3VyY2VzIiwicm4uYWNjb3VudHMiLCJybi5hcGkiLCJybi5hdXRoIiwicm4uY2hhdCIsInJuLmNsdWJzIiwicm4uY29tbWVyY2UiLCJybi5sZWFkZXJib2FyZCIsInJuLmxpbmsiLCJybi5tYXRjaCIsInJuLm5vdGlmeSIsInJuLnJvb21jb21tZW50cyIsInJuLnJvb21zIiwicm4uc3RvcmFnZSJdLCJjbGllbnRfaWQiOiJyZWNyb29tIiwicm9sZSI6ImdhbWVDbGllbnQiLCJybi5wbGF0IjoiMSIsInJuLnBsYXRpZCI6IjQ2Nzk4NDI5Nzg3ODk3MTMiLCJybi5kZXZpY2VjbGFzcyI6IjUiLCJybi52ZXIiOiIyMDIxMTAwOCIsInJuLmFzaWQiOiIxNjM0OTI3OTQ5NTQyIiwicm4uc2siOiIxMDgzNjgyNzkzIiwic3ViIjoiMzA2OTIxMTMiLCJhdXRoX3RpbWUiOjE2MzQ5Mjc5NTEsImlkcCI6ImxvY2FsIiwicm4ucGlkIjoiMzA2OTIxMTMiLCJzY29wZSI6WyJybi5hY2NvdW50cyIsInJuLmFjY291bnRzLmdjIiwicm4uYXBpIiwicm4uYXV0aCIsInJuLmF1dGguZ2MiLCJybi5jaGF0Iiwicm4uY2x1YnMiLCJybi5jb21tZXJjZSIsInJuLmxlYWRlcmJvYXJkIiwicm4ubGluayIsInJuLm1hdGNoLnJlYWQiLCJybi5tYXRjaC53cml0ZSIsInJuLm5vdGlmeSIsInJuLnJvb21jb21tZW50cyIsInJuLnJvb21zIiwicm4uc3RvcmFnZSIsIm9mZmxpbmVfYWNjZXNzIl0sImFtciI6WyJjYWNoZWRfbG9naW4iXX0.oCEqD-YeaU-ewmTtpTPnJM5FN8tOrOcAsQhLvFyluf6j3FCTIeSQyCDDcT12CrRdOmaamZwQy4jSccVRLiipdki4OEpQjOx8dmwyrhtlofIQbxl-2Twr0-1p5vLePBB2ePW1qyUOAwZv2J92vXtdq0YWSZAgWs_WjnEIwMLmWlyjY8Cw0M-2Y7RXfKZSYvYaUHOthDCvP1G-7URAznjwenccuSJ7Wx_roHi0hEBZLq5r85zVPD9Gs6gC8nDJcg13CyKQujv0FxziQBGbDGRwZxu-W5XhJOy1u3yMchayUbKC_3OydXlZ-wW7n3ba_QQs3uRqgLtoFcyzd8nHMsB0xQ");
        restRequest1.AddHeader("X-RNSIG", str1);
        restRequest1.AddParameter("text/xml", (object) s, ParameterType.RequestBody);
        RestRequest restRequest2 = restRequest1;
        IRestResponse restResponse = restClient.Execute((IRestRequest) restRequest2);
        switch (restResponse.ResponseStatus)
        {
          case ResponseStatus.Completed:
            if (restResponse.StatusCode == HttpStatusCode.OK)
            {
              try
              {
                Console.WriteLine(restResponse.Content);
              }
              catch
              {
                Console.WriteLine("ERROR: Malformed login response");
                break;
              }
            }
            Console.WriteLine("ERROR: " + (object) restResponse.StatusCode + " " + restResponse.StatusDescription);
            break;
          case ResponseStatus.Error:
            Console.WriteLine("ERROR: " + restResponse.ErrorMessage);
            break;
          case ResponseStatus.TimedOut:
            Console.WriteLine("ERROR: Timed out trying to contact RecNet servers");
            break;
          default:
            Console.WriteLine("ERROR: Unknown error occurred");
            break;
        }
        Thread.Sleep(400);
        Console.WriteLine(rawUrl);
        Console.WriteLine(s);
        byte[] bytes = Encoding.UTF8.GetBytes(s);
        response.ContentLength64 = (long) bytes.Length;
        Stream outputStream = response.OutputStream;
        outputStream.Write(bytes, 0, bytes.Length);
        Thread.Sleep(200);
        outputStream.Close();
        this.listener.Stop();
      }
    }

    public static Method ParseMethod(string method)
    {
      if (method == "GET")
        return Method.GET;
      if (method == "POST")
        return Method.POST;
      if (method == "PUT")
        return Method.PUT;
      if (method == "PATCH")
        return Method.PATCH;
      if (method == "DELETE")
        return Method.DELETE;
      if (method == "COPY")
        return Method.COPY;
      if (method == "HEAD")
        return Method.HEAD;
      return method == "OPTIONS" ? Method.OPTIONS : Method.GET;
    }
  }
}

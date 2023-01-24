// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Client;
using Configs;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Web;

namespace Servers
{
  internal class RoomServer
  {
    private HttpListener listener = new HttpListener();

    public RoomServer()
    {
      try
      {
        Console.WriteLine("[RoomServer] has started.");
        new Thread(new ThreadStart(this.StartListen)).Start();
      }
      catch (Exception ex)
      {
        Console.WriteLine("An Exception Occurred while Listening :" + ex.ToString());
      }
    }

    private void StartListen()
    {
      this.listener.Prefixes.Add(string.Format("http://+:{0}/", (object) Config.roomServerPort));
      while (true)
      {
        try
        {
          this.listener.Start();
          Console.WriteLine("[RoomServer] is running.");
          HttpListenerContext context = this.listener.GetContext();
          HttpListenerRequest request = context.Request;
          HttpListenerResponse response = context.Response;
          NameValueCollection headers = request.Headers;
          string str1 = "";
          string str2 = "";
          for (int index = 0; index < request.Headers.Count; ++index)
          {
            string key = headers.GetKey(index);
            Console.WriteLine(key + " : " + headers.GetValues(key)[0]);
            if (key == "Authorization")
              str1 = headers.GetValues("Authorization")[0];
            if (key == "X-RNSIG")
              str2 = headers.GetValues(key)[0];
          }
          string s = "";
          string rawUrl = request.RawUrl;
          string end;
          using (StreamReader streamReader = new StreamReader(request.InputStream, request.ContentEncoding))
            end = streamReader.ReadToEnd();
          string[] strArray1 = rawUrl.Split('/');
          string str3 = strArray1[strArray1.Length - 1];
          Console.ForegroundColor = ConsoleColor.Green;
          Console.WriteLine("RAWURL: http://localhost:" + (object) Config.roomServerPort + request.RawUrl + " | HTTPMETHOD: " + request.HttpMethod + " | POSTDATA: " + end);
          Console.WriteLine(str3);
          if (request.HttpMethod == "GET" && !rawUrl.StartsWith("/favicon") && !rawUrl.Contains("/playerdata/me"))
          {
            WebClient webClient1 = new WebClient();
            webClient1.Headers.Add("Authorization", request.Headers.Get("Authorization"));
            webClient1.Headers.Add("Te", "identity");
            webClient1.Headers.Add("User-Agent", "BestHTTP");
            string str4 = webClient1.DownloadString("https://rooms.rec.net" + rawUrl);
            if (rawUrl.StartsWith("/rooms/") && str4.Contains("\"IsRRO\"") && !str4.StartsWith("[") && !str4.EndsWith("]") && !rawUrl.EndsWith("/hot") && !rawUrl.EndsWith("?tag=rro") && !rawUrl.Contains("skip") && !rawUrl.Contains("take"))
            {
              string[] strArray2 = request.Headers.Get("Authorization").Split(' ');
              Console.WriteLine("Rec Room Original Room detected!\n\tSetting creator id...");
              if (!string.IsNullOrEmpty(str4))
              {
                Thread.Sleep(1000);
                RoomServer.ThisRoom thisRoom = JsonConvert.DeserializeObject<RoomServer.ThisRoom>(str4);
                thisRoom.CreatorAccountId = new int?((int) ClientSecurity.GetTokenSubject(strArray2[1]));
                foreach (RoomServer.cRole role1 in thisRoom.Roles)
                {
                  int? role2 = role1.Role;
                  int maxValue = (int) byte.MaxValue;
                  if (role2.GetValueOrDefault() == maxValue & role2.HasValue)
                    role1.AccountId = new int?((int) ClientSecurity.GetTokenSubject(strArray2[1]));
                }
                string str5 = JsonConvert.SerializeObject((object) thisRoom);
                Console.WriteLine(str5);
                s = str5;
              }
            }
            else
            {
              WebClient webClient2 = new WebClient();
              webClient2.Headers.Add("Authorization", request.Headers.Get("Authorization"));
              webClient2.Headers.Add("Te", "identity");
              webClient2.Headers.Add("User-Agent", "BestHTTP");
              s = webClient2.DownloadString("https://rooms.rec.net" + rawUrl);
            }
          }
          if (rawUrl.Contains("/playerdata/me"))
            s = "[]";
          if (rawUrl.Contains("/bans"))
          {
            RestClient restClient = new RestClient("https://rooms.rec.net");
            RestRequest restRequest1 = new RestRequest("/rooms/170126/bans", Method.POST);
            restRequest1.AddHeader("Authorization", str1);
            restRequest1.AddHeader("X-RNSIG", str2);
            restRequest1.AddParameter("banMask=7&id=1", (object) ParameterType.RequestBody);
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
          }
          byte[] bytes = Encoding.UTF8.GetBytes(s);
          response.ContentLength64 = (long) bytes.Length;
          Stream outputStream = response.OutputStream;
          outputStream.Write(bytes, 0, bytes.Length);
          Thread.Sleep(5);
          outputStream.Close();
          this.listener.Stop();
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex.ToString());
        }
      }
    }

    public Dictionary<string, string> SplitPostData(string postdata)
    {
      string[] strArray1 = postdata.Split('&');
      Dictionary<string, string> dictionary = new Dictionary<string, string>();
      foreach (string str in strArray1)
      {
        char[] chArray = new char[1]{ '=' };
        string[] strArray2 = str.Split(chArray);
        dictionary.Add(HttpUtility.UrlDecode(strArray2[0]), HttpUtility.UrlDecode(strArray2[1]));
      }
      return dictionary;
    }

    public class Stats
    {
      public int? CheerCount { get; set; }

      public int? FavoriteCount { get; set; }

      public int? VisitorCount { get; set; }

      public int? VisitCount { get; set; }
    }

    public class SubRoom
    {
      public int? SubRoomId { get; set; }

      public int? RoomId { get; set; }

      public string UnitySceneId { get; set; }

      public string Name { get; set; }

      public string DataBlob { get; set; }

      public string DataBlobHash { get; set; }

      public DateTime? DataSavedAt { get; set; }

      public bool IsSandbox { get; set; }

      public int? MaxPlayers { get; set; }

      public int? Accessibility { get; set; }
    }

    public class cRole
    {
      public int? AccountId { get; set; }

      public int? Role { get; set; }

      public object LastChangedByAccountId { get; set; }

      public int? InvitedRole { get; set; }
    }

    public class cTag
    {
      public string Tag { get; set; }

      public int? Type { get; set; }
    }

    public class ThisRoom
    {
      public int? RoomId { get; set; }

      public bool IsDorm { get; set; }

      public int? MaxPlayerCalculationMode { get; set; }

      public int? MaxPlayers { get; set; }

      public bool CloningAllowed { get; set; }

      public bool DisableMicAutoMute { get; set; }

      public bool DisableRoomComments { get; set; }

      public bool EncryptVoiceChat { get; set; }

      public bool LoadScreenLocked { get; set; }

      public int? Version { get; set; }

      public string Name { get; set; }

      public string Description { get; set; }

      public string ImageName { get; set; }

      public int? WarningMask { get; set; }

      public object CustomWarning { get; set; }

      public int? CreatorAccountId { get; set; }

      public int? State { get; set; }

      public int? Accessibility { get; set; }

      public bool SupportsLevelVoting { get; set; }

      public bool IsRRO { get; set; }

      public bool SupportsScreens { get; set; }

      public bool SupportsWalkVR { get; set; }

      public bool SupportsTeleportVR { get; set; }

      public bool SupportsVRLow { get; set; }

      public bool SupportsQuest2 { get; set; }

      public bool SupportsMobile { get; set; }

      public bool SupportsJuniors { get; set; }

      public int? MinLevel { get; set; }

      public DateTime? CreatedAt { get; set; }

      public RoomServer.Stats Stats { get; set; }

      public string DataBlob { get; set; }

      public string DataBlobHash { get; set; }

      public List<RoomServer.SubRoom> SubRooms { get; set; }

      public List<RoomServer.cRole> Roles { get; set; }

      public List<RoomServer.cTag> Tags { get; set; }

      public List<object> PromoImages { get; set; }

      public List<object> PromoExternalContent { get; set; }

      public List<object> LoadScreens { get; set; }
    }

    public class BanPostDTO
    {
      public int banMask { get; set; }

      public int id { get; set; }
    }
  }
}

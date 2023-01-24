// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Configs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Web;

namespace OldAPIs
{
  internal class APIServer1
  {
    private HttpListener listener = new HttpListener();
    private ulong ServerID;

    public APIServer1()
    {
      try
      {
        Console.WriteLine("API Server Running... Press ^C to Stop...");
        new Thread(new ThreadStart(this.StartListen)).Start();
      }
      catch (Exception ex)
      {
        Console.WriteLine("An Exception Occurred while Listening :" + ex.ToString());
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

    public void StartListen()
    {
      this.listener.Prefixes.Add(string.Format("http://+:{0}/", (object) Config.APIServerPort));
      while (true)
      {
        this.listener.Start();
        Console.WriteLine("API Server is listening...");
        HttpListenerContext context = this.listener.GetContext();
        HttpListenerRequest request = context.Request;
        HttpListenerResponse response = context.Response;
        context.Request.Url.ToString();
        string rawUrl = request.RawUrl;
        string s1 = "";
        string end;
        using (StreamReader streamReader = new StreamReader(request.InputStream, request.ContentEncoding))
          end = streamReader.ReadToEnd();
        Console.WriteLine(string.Format("URL Requested: {0}", (object) context.Request.Url));
        if (rawUrl == "/api/avatar/v1/defaultunlocked")
        {
          Config.localdefaultitems = new WebClient().DownloadString("https://api.rec.net/api/avatar/v1/defaultunlocked");
          s1 = Config.localdefaultitems;
        }
        else if (rawUrl == "/api/platformlogin/v2/getcachedlogins")
          s1 = PlatformLogin2019Profile.GetDebugLogin(new UserConfig(this.ServerID));
        else if (rawUrl.StartsWith("/api/players/v1/"))
        {
          string[] strArray = rawUrl.Split('/');
          string userID = strArray[strArray.Length - 1];
          Console.WriteLine(userID);
          switch (userID)
          {
            case "getorcreate":
              s1 = Players.GetOrCreate(new UserConfig(this.ServerID, this.SplitPostData(end)));
              goto label_152;
            case "list":
              s1 = "[]";
              goto label_152;
            case "birthday":
              s1 = JsonConvert.SerializeObject((object) new OldAPIs.Generic.APISuccessResposne());
              goto label_152;
            default:
              s1 = Players.GetOrCreate(new UserConfig(this.ServerID, userID));
              break;
          }
        }
        else if (rawUrl.StartsWith("/api/versioncheck/"))
        {
          s1 = "{\"VersionStatus\":0}";
        }
        else
        {
          string s2 = rawUrl;
          if (s2 != null)
          {
            // ISSUE: reference to a compiler-generated method
            uint stringHash = PrivateImplementationDetails.ComputeStringHash(s2);
            if (stringHash > 2248932164U)
            {
              if (stringHash <= 2976159423U)
              {
                if (stringHash <= 2859857060U)
                {
                  if (stringHash <= 2456531810U)
                  {
                    if (stringHash != 2330850875U)
                    {
                      if (stringHash == 2456531810U && s2 == "/api/gamesessions/v2/create")
                      {
                        s1 = GameSessions.Create(end);
                        goto label_152;
                      }
                      else
                        goto label_146;
                    }
                    else if (s2 == "/api/events/v1/list")
                      goto label_145;
                    else
                      goto label_146;
                  }
                  else if (stringHash != 2528303580U)
                  {
                    if (stringHash != 2538518886U)
                    {
                      if (stringHash != 2859857060U || !(s2 == "/api/events/v2/list"))
                        goto label_146;
                      else
                        goto label_145;
                    }
                    else if (s2 == "/api/config/v2")
                    {
                      s1 = Config2.GetDebugConfig();
                      goto label_152;
                    }
                    else
                      goto label_146;
                  }
                  else if (s2 == "/api/images/v2/profile")
                  {
                    if (!(request.HttpMethod == "POST"))
                      goto label_152;
                    else
                      goto label_152;
                  }
                  else
                    goto label_146;
                }
                else if (stringHash <= 2925826566U)
                {
                  if (stringHash != 2907900596U)
                  {
                    if (stringHash != 2909048947U)
                    {
                      if (stringHash != 2925826566U || !(s2 == "/api/platformlogin/v2"))
                        goto label_146;
                    }
                    else if (!(s2 == "/api/platformlogin/v1"))
                      goto label_146;
                  }
                  else if (s2 == "/api/avatar/v2/gifts/create")
                  {
                    s1 = "[]";
                    goto label_152;
                  }
                  else
                    goto label_146;
                }
                else if (stringHash != 2958380967U)
                {
                  if (stringHash != 2959381804U)
                  {
                    if (stringHash != 2976159423U || !(s2 == "/api/platformlogin/v5"))
                      goto label_146;
                  }
                  else if (!(s2 == "/api/platformlogin/v4"))
                    goto label_146;
                }
                else if (s2 == "/api/platformlogin/v1/logincached")
                {
                  s1 = loginCachedFunc.loginCache(new UserConfig(this.ServerID));
                  goto label_152;
                }
                else
                  goto label_146;
              }
              else if (stringHash <= 3435949808U)
              {
                if (stringHash <= 2992937042U)
                {
                  if (stringHash != 2979624534U)
                  {
                    if (stringHash != 2992937042U || !(s2 == "/api/platformlogin/v6"))
                      goto label_146;
                  }
                  else if (s2 == "/api/platformlogin/v1/profiles")
                  {
                    s1 = Players.GetOrCreateArray(new UserConfig(this.ServerID));
                    goto label_152;
                  }
                  else
                    goto label_146;
                }
                else if (stringHash != 3005936841U)
                {
                  if (stringHash != 3413914792U)
                  {
                    if (stringHash == 3435949808U && s2 == "/api/avatar/v2/set")
                    {
                      Avatar.SetAvatar(end);
                      goto label_152;
                    }
                    else
                      goto label_146;
                  }
                  else if (s2 == "/api/gameconfigs/v1/all")
                  {
                    s1 = System.IO.File.ReadAllText("gameconfig.json");
                    goto label_152;
                  }
                  else
                    goto label_146;
                }
                else if (s2 == "/api/equipment/v1/getUnlocked")
                {
                  s1 = Equipment.GetUnlocked();
                  goto label_152;
                }
                else
                  goto label_146;
              }
              else if (stringHash <= 3865985461U)
              {
                if (stringHash != 3446422514U)
                {
                  if (stringHash != 3447903044U)
                  {
                    if (stringHash == 3865985461U && s2 == "/api/storefronts/v1/allGiftDrops/2")
                    {
                      s1 = "[]";
                      goto label_152;
                    }
                    else
                      goto label_146;
                  }
                  else if (s2 == "/api/platformlogin/v2/getcachedlogins")
                  {
                    s1 = PlatformLogin2019Profile.GetDebugLogin(new UserConfig(this.ServerID));
                    goto label_152;
                  }
                  else
                    goto label_146;
                }
                else if (s2 == "/api/avatar/v1/saved")
                {
                  s1 = "[]";
                  goto label_152;
                }
                else
                  goto label_146;
              }
              else if (stringHash != 4225962702U)
              {
                if (stringHash != 4257950800U)
                {
                  if (stringHash == 4282887303U && s2 == "/api/messages/v2/get")
                  {
                    s1 = "[]";
                    goto label_152;
                  }
                  else
                    goto label_146;
                }
                else if (s2 == "/api/activities/charades/v1/words")
                {
                  s1 = Activities.Charades.words();
                  goto label_152;
                }
                else
                  goto label_146;
              }
              else if (s2 == "/api/rooms/v1/myrooms")
              {
                s1 = "[]";
                goto label_152;
              }
              else
                goto label_146;
              string[] strArray1 = end.Split('&');
              Dictionary<string, string> postData = new Dictionary<string, string>();
              foreach (string str in strArray1)
              {
                char[] chArray = new char[1]{ '=' };
                string[] strArray2 = str.Split(chArray);
                postData.Add(strArray2[0], strArray2[1]);
              }
              s1 = PlatformLogin.v4(new UserConfig(this.ServerID, postData));
              goto label_152;
            }
            else if (stringHash <= 804593487U)
            {
              if (stringHash <= 352771715U)
              {
                if (stringHash <= 198441579U)
                {
                  if (stringHash != 41241644U)
                  {
                    if (stringHash == 198441579U && s2 == "/api/objectives/v1/myprogress")
                    {
                      s1 = JsonConvert.SerializeObject((object) new Objective2018());
                      goto label_152;
                    }
                    else
                      goto label_146;
                  }
                  else if (s2 == "/api/settings/v2/set")
                  {
                    Settings.SetPlayerSettings(end);
                    goto label_152;
                  }
                  else
                    goto label_146;
                }
                else if (stringHash != 226873345U)
                {
                  if (stringHash != 343323979U)
                  {
                    if (stringHash == 352771715U && s2 == "/api/avatar/v3/items")
                    {
                      s1 = AvatarItem.SerializeItems();
                      goto label_152;
                    }
                    else
                      goto label_146;
                  }
                  else if (s2 == "/api/avatar/v2/gifts/consume/")
                  {
                    s1 = "[]";
                    goto label_152;
                  }
                  else
                    goto label_146;
                }
                else if (s2 == "/api/checklist/v1/current")
                {
                  s1 = Checklist.Get();
                  goto label_152;
                }
                else
                  goto label_146;
              }
              else if (stringHash <= 454727624U)
              {
                if (stringHash != 396029181U)
                {
                  if (stringHash == 454727624U && s2 == "/api/avatar/v3/saved")
                  {
                    s1 = "[]";
                    goto label_152;
                  }
                  else
                    goto label_146;
                }
                else if (s2 == "/api/gamesessions/v2/joinrandom")
                {
                  s1 = GameSessions.JoinRandom(end);
                  goto label_152;
                }
                else
                  goto label_146;
              }
              else if (stringHash != 645376957U)
              {
                if (stringHash != 689879488U)
                {
                  if (stringHash == 804593487U && s2 == "/api/avatar/v2")
                  {
                    s1 = Avatar.SerializeAvatar();
                    goto label_152;
                  }
                  else
                    goto label_146;
                }
                else if (s2 == "/api/challenge/v1/getCurrent")
                {
                  s1 = Challenge.getCurrent();
                  goto label_152;
                }
                else
                  goto label_146;
              }
              else if (s2 == "/api/rooms/v1/mybookmarkedrooms")
              {
                s1 = "[]";
                goto label_152;
              }
              else
                goto label_146;
            }
            else if (stringHash <= 1603211641U)
            {
              if (stringHash <= 1042418911U)
              {
                if (stringHash != 1019236481U)
                {
                  if (stringHash == 1042418911U && s2 == "/api/avatar/v2/gifts")
                  {
                    s1 = "[]";
                    goto label_152;
                  }
                  else
                    goto label_146;
                }
                else if (s2 == "/api/rooms/v1/myRecent?skip=0&take=10")
                {
                  s1 = "[]";
                  goto label_152;
                }
                else
                  goto label_146;
              }
              else if (stringHash != 1420401932U)
              {
                if (stringHash != 1486805520U)
                {
                  if (stringHash == 1603211641U && s2 == "/api/config/v1/amplitude")
                  {
                    s1 = Amplitude.amplitude();
                    goto label_152;
                  }
                  else
                    goto label_146;
                }
                else if (s2 == "/api/relationships/v2/get")
                {
                  s1 = "[]";
                  goto label_152;
                }
                else
                  goto label_146;
              }
              else if (s2 == "/api/PlayerReporting/v1/moderationBlockDetails")
              {
                s1 = PlayerReporting.moderationBlockDetails();
                goto label_152;
              }
              else
                goto label_146;
            }
            else if (stringHash > 2178633321U)
            {
              int num;
              switch (stringHash)
              {
                case 2183592056:
                  if (s2 == "/api/storefronts/v3/giftdropstore/2")
                    goto label_136;
                  else
                    goto label_146;
                case 2200369675:
                  if (s2 == "/api/storefronts/v3/giftdropstore/3")
                    goto label_136;
                  else
                    goto label_146;
                case 2248932164:
                  num = s2 == "/api/settings/v2/" ? 1 : 0;
                  break;
                default:
                  num = 0;
                  break;
              }
              if (num != 0)
              {
                s1 = Settings.GetPlayerSettings();
                goto label_152;
              }
              else
                goto label_146;
label_136:
              s1 = JsonConvert.SerializeObject((object) new StoreFronts.GiftDropStore());
              goto label_152;
            }
            else
            {
              int num;
              switch (stringHash)
              {
                case 2020467393:
                  if (s2 == "/api/events/v3/list")
                    goto label_145;
                  else
                    goto label_146;
                case 2171821941:
                  if (s2 == "/api/playerevents/v1/all")
                  {
                    s1 = PlayerEvents.Get();
                    goto label_152;
                  }
                  else
                    goto label_146;
                case 2178633321:
                  num = s2 == "/api/consumables/v1/getUnlocked" ? 1 : 0;
                  break;
                default:
                  num = 0;
                  break;
              }
              if (num != 0)
              {
                s1 = Consumables.SerializeItems();
                goto label_152;
              }
              else
                goto label_146;
            }
label_145:
            s1 = Events.list();
            goto label_152;
          }
label_146:
          Console.WriteLine("==============Unknown API Call==============");
          Console.WriteLine("Unknown URI " + rawUrl);
          Console.WriteLine("Content Type: {0}", (object) request.ContentType);
          Console.WriteLine("HttpMethod: {0}", (object) request.HttpMethod);
          if (request.HttpMethod == "POST")
            Console.WriteLine("Content:\n " + end);
          Console.WriteLine("============================================");
        }
label_152:
        byte[] bytes = Encoding.UTF8.GetBytes(s1);
        response.ContentLength64 = (long) bytes.Length;
        Stream outputStream = response.OutputStream;
        outputStream.Write(bytes, 0, bytes.Length);
        Thread.Sleep(500);
        outputStream.Close();
        this.listener.Stop();
      }
    }

    public void SaveFile()
    {
    }
  }
}

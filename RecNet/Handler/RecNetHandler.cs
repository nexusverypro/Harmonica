// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Configs;
using RestSharp;
using System;
using System.Net;

namespace RecNet.Handler
{
  internal class RecNetHandler
  {
    public static string[] blacklistedApis = new string[1]
    {
      "/api/gamesight/event"
    };
    public static string AuthToken = "Bearer eyJhbGciOiJSUzI1NiIsImtpZCI6IjRwY2dIaFlHWXk0LTZsUDI5d0RDME1kS09ONCIsInR5cCI6IkpXVCIsIng1dCI6IjRwY2dIaFlHWXk0LTZsUDI5d0RDME1kS09ONCJ9.eyJuYmYiOjE2MzMzNjgxNDMsImV4cCI6MTYzMzQxMTM0MywiaXNzIjoiaHR0cHM6Ly9hdXRoLnJlYy5uZXQiLCJhdWQiOlsiaHR0cHM6Ly9hdXRoLnJlYy5uZXQvcmVzb3VyY2VzIiwicm4uYWNjb3VudHMiLCJybi5hcGkiLCJybi5hdXRoIiwicm4uY2hhdCIsInJuLmNsdWJzIiwicm4uY29tbWVyY2UiLCJybi5sZWFkZXJib2FyZCIsInJuLmxpbmsiLCJybi5tYXRjaCIsInJuLm5vdGlmeSIsInJuLnJvb21jb21tZW50cyIsInJuLnJvb21zIiwicm4uc3RvcmFnZSJdLCJjbGllbnRfaWQiOiJyZWNyb29tIiwicm9sZSI6ImdhbWVDbGllbnQiLCJybi5wbGF0IjoiMCIsInJuLnBsYXRpZCI6Ijc2NTYxMTk5MjEyNzAyMDg3Iiwicm4uZGV2aWNlY2xhc3MiOiIyIiwicm4udmVyIjoiMjAyMTA5MjQiLCJybi5hc2lkIjoiMTYzMzM2ODE0MjgzMSIsInJuLnNrIjoiOTcwNDE1NDg3Iiwic3ViIjoiMjkyNDE5MDgiLCJhdXRoX3RpbWUiOjE2MzMzNjgxNDIsImlkcCI6ImxvY2FsIiwicm4ucGlkIjoiMjkyNDE5MDgiLCJzY29wZSI6WyJybi5hY2NvdW50cyIsInJuLmFjY291bnRzLmdjIiwicm4uYXBpIiwicm4uYXV0aCIsInJuLmF1dGguZ2MiLCJybi5jaGF0Iiwicm4uY2x1YnMiLCJybi5jb21tZXJjZSIsInJuLmxlYWRlcmJvYXJkIiwicm4ubGluayIsInJuLm1hdGNoLnJlYWQiLCJybi5tYXRjaC53cml0ZSIsInJuLm5vdGlmeSIsInJuLnJvb21jb21tZW50cyIsInJuLnJvb21zIiwicm4uc3RvcmFnZSIsIm9mZmxpbmVfYWNjZXNzIl0sImFtciI6WyJjYWNoZWRfbG9naW4iXX0.WNjD100aoE6adsZK1nERp0uvD_dSCmYt7twlj2s2Hs27JHdvtm3VqBRs3qelNKMH3H8CO7FTx5oUpuqJOTumxALzkW8MfbvaCHgkvJXyEOkUd-4455PT79dFFWiMTq8Qoy6nMKtRyzm39ByKIoF9K8HtHMvlEVFuFZ1umbtaZeOjctfb4YOAl3WYfurpdpXo1G153XFIxLvYCFFLIDsFJiT6dZc61N81tJDtA9r631ZDqk-t5eY5cNIYIJLaSmB7rtdxla7nEjHZRZeILgpD0OY9gbuyULmXxSGDInt0YsALqPjJo9rbHkzEZCzwPlvMUsY8zHp-Xwme_tfvu0evVw";
    public static string[] services = new string[16]
    {
      "http://localhost:56/?v=2",
      string.Format("http://localhost:{0}", (object) Config.APIServerPort),
      string.Format("http://localhost:{0}", (object) Config.authServerPort),
      string.Format("http://localhost:{0}", (object) Config.cdnServerPort),
      string.Format("http://localhost:{0}", (object) Config.chatServerPort),
      string.Format("http://localhost:{0}", (object) Config.clubsServerPort),
      string.Format("http://localhost:{0}", (object) Config.commerceServerPort),
      string.Format("http://localhost:{0}", (object) Config.imageServerPort),
      string.Format("http://localhost:{0}", (object) Config.leaderboardServerPort),
      string.Format("http://localhost:{0}", (object) Config.linkServerPort),
      string.Format("http://localhost:{0}", (object) Config.matchServerPort),
      "https://notify.rec.net",
      string.Format("http://localhost:{0}", (object) Config.roomCommentsServerPort),
      string.Format("http://localhost:{0}", (object) Config.roomServerPort),
      string.Format("http://localhost:{0}", (object) Config.storageServerPort),
      "https://www.rec.net"
    };
    public static string[] actualServices = new string[16]
    {
      "https://ns.rec.net",
      "https://api.rec.net",
      "https://auth.rec.net",
      "https://cdn.rec.net",
      "https://chat.rec.net",
      "https://clubs.rec.net",
      "https://commerce.rec.net",
      "https://img.rec.net",
      "https://leaderboard.rec.net",
      "https://link.rec.net",
      "https://match.rec.net",
      "https://notify.rec.net",
      "https://roomcomments.rec.net",
      "https://rooms.rec.net",
      "https://storage.rec.net",
      "https://www.rec.net"
    };

    public static T ExecuteWebClientRequest<T>(string serverurl, Func<string, T> parser)
    {
      if (Config.AuthToken == "")
      {
        T obj1 = parser("");
      }
      else
      {
        WebClient webClient = new WebClient();
        webClient.Headers.Add("Authorization", Config.AuthToken);
        webClient.Headers.Add("Te", "identity");
        webClient.Headers.Add("User-Agent", "BestHTTP");
        string str = webClient.DownloadString(serverurl);
        if (str == "")
        {
          T obj2 = parser(str);
        }
        else
        {
          T obj3 = parser(str);
        }
      }
      return default (T);
    }

    public static T ExecuteRecNetExternalRequest<T>(
      Service service,
      RestRequest request,
      Func<string, T> parser)
    {
      foreach (string blacklistedApi in RecNetHandler.blacklistedApis)
      {
        if (request.Resource == blacklistedApi)
          return parser("[]");
      }
      if (request.Resource == "/favico.ico" || request.Resource == "/favicon.ico")
        return parser("[]");
      IRestResponse restResponse = new RestClient(RecNetHandler.actualServices[(int) service]).AddDefaultHeader("Authorization", RecNetHandler.AuthToken).Execute((IRestRequest) request);
      switch (restResponse.ResponseStatus)
      {
        case ResponseStatus.Completed:
          if (restResponse.StatusCode == HttpStatusCode.OK)
          {
            try
            {
              if (!string.IsNullOrEmpty(restResponse.Content) && !(restResponse.Content == "The resource you are looking for has been removed, had its name changed, or is temporarily unavailable.") && !(restResponse.Content == "You do not have permission to view this directory or page."))
                return parser(restResponse.Content);
              Console.WriteLine("ERROR: Malformed response");
              break;
            }
            catch
            {
              Console.WriteLine("ERROR: Malformed response");
              break;
            }
          }
          else
          {
            Console.WriteLine("ERROR: " + (object) restResponse.StatusCode + " " + restResponse.StatusDescription);
            break;
          }
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
      return default (T);
    }
  }
}

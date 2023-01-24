// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Client;
using System.Collections.Generic;
using System.Net;

namespace RecNet
{
  public class Core
  {
    public static Queue<ServerRequest> ServerRequests = new Queue<ServerRequest>();

    public static byte[] GetFromImgServer(string requestUri) => new WebClient().DownloadData("https://img.rec.net" + requestUri);

    public static byte[] GetFromCDN(string requestUri) => new WebClient().DownloadData("https://cdn.rec.net" + requestUri);

    public static bool EnqueuePerson(ServerRequest request)
    {
      try
      {
        Core.ServerRequests.Enqueue(request);
        return true;
      }
      catch
      {
        return false;
      }
    }

    public static string DequeueWithResponse(ServerRequest request) => request.url.EndsWith("/api/config/v2") ? "OK" : "{\"error\":true,\"message\":\"Failed to find the requested resource\"}";
  }
}

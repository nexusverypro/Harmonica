// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Configs;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace Servers
{
  internal class NameServer
  {
    private HttpListener listener = new HttpListener();

    public NameServer()
    {
      try
      {
        if (Config.LogMessages)
          Console.WriteLine("[NameServer] has started.");
        new Thread(new ThreadStart(this.StartListen)).Start();
      }
      catch (Exception ex)
      {
        Console.WriteLine("An Exception Occurred while Listening :" + ex.ToString());
      }
    }

    private void StartListen()
    {
      this.listener.Prefixes.Add(string.Format("http://+:{0}/", (object) Config.nameServerPort));
      while (true)
      {
        this.listener.Start();
        if (Config.LogMessages)
          Console.WriteLine("[NameServer] is running.");
        HttpListenerContext context = this.listener.GetContext();
        HttpListenerRequest request = context.Request;
        HttpListenerResponse response = context.Response;
        string s = JsonConvert.SerializeObject((object) new NameServer.NSData()
        {
          Accounts = "https://accounts.rec.net",
          API = "http://4.tcp.eu.ngrok.io:18528",
          Auth = "https://auth.rec.net",
          CDN = "https://cdn.rec.net",
          Chat = "https://chat.rec.net",
          Clubs = "https://clubs.rec.net",
          Commerce = "http://4.tcp.eu.ngrok.io:17091",
          Images = "https://img.rec.net",
          Leaderboard = "https://leaderboard.rec.net",
          Link = "https://link.rec.net",
          Matchmaking = "https://match.rec.net",
          Notifications = "https://notify.rec.net",
          RoomComments = "https://roomcomments.rec.net",
          Rooms = "http://2.tcp.eu.ngrok.io:14816",
          Storage = "https://storage.rec.net",
          WWW = "https://rec.net"
        });
        Thread.Sleep(400);
        Console.WriteLine("");
        if (Config.LogMessages)
          Console.WriteLine("[NS] Name server was requested!");
        byte[] bytes = Encoding.UTF8.GetBytes(s);
        response.ContentLength64 = (long) bytes.Length;
        Stream outputStream = response.OutputStream;
        outputStream.Write(bytes, 0, bytes.Length);
        Thread.Sleep(100);
        outputStream.Close();
        this.listener.Stop();
      }
    }

    public class NSData
    {
      public string Accounts { get; set; }

      public string API { get; set; }

      public string Auth { get; set; }

      public string CDN { get; set; }

      public string Chat { get; set; }

      public string Clubs { get; set; }

      public string Commerce { get; set; }

      public string Images { get; set; }

      public string Leaderboard { get; set; }

      public string Link { get; set; }

      public string Matchmaking { get; set; }

      public string Notifications { get; set; }

      public string RoomComments { get; set; }

      public string Rooms { get; set; }

      public string Storage { get; set; }

      public string WWW { get; set; }
    }
  }
}

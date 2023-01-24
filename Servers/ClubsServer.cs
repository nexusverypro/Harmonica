// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Configs;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace Servers
{
  internal class ClubsServer
  {
    private HttpListener listener = new HttpListener();

    public ClubsServer()
    {
      try
      {
        if (Config.LogMessages)
          Console.WriteLine("[ClubsServer] has started.");
        new Thread(new ThreadStart(this.StartListen)).Start();
      }
      catch (Exception ex)
      {
        Console.WriteLine("An Exception Occurred while Listening :" + ex.ToString());
      }
    }

    private void StartListen()
    {
      this.listener.Prefixes.Add(string.Format("http://+:{0}/", (object) Config.clubsServerPort));
      while (true)
      {
        this.listener.Start();
        if (Config.LogMessages)
          Console.WriteLine("[ClubsServer] is listening for a request.");
        HttpListenerContext context = this.listener.GetContext();
        HttpListenerRequest request = context.Request;
        HttpListenerResponse response = context.Response;
        string s = "";
        string rawUrl = request.RawUrl;
        string end;
        using (StreamReader streamReader = new StreamReader(request.InputStream, request.ContentEncoding))
          end = streamReader.ReadToEnd();
        Console.ForegroundColor = ConsoleColor.White;
        if (Config.LogMessages)
          Console.WriteLine("RAWURL: http://localhost:" + (object) Config.clubsServerPort + request.RawUrl + " | HTTPMETHOD: " + request.HttpMethod + " | POSTDATA: " + end);
        if (rawUrl.StartsWith("/club/home/me"))
        {
          if (Config.LogMessages)
            Console.WriteLine("[club.lh] Setting current clubhouse.");
          s = "";
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
  }
}

// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace Servers.Oculus
{
  public class OculusGraphServer
  {
    private HttpListener listener = new HttpListener();

    public OculusGraphServer()
    {
      try
      {
        new Thread(new ThreadStart(this.StartListen)).Start();
      }
      catch (Exception ex)
      {
        Console.WriteLine("An Exception Occurred while Listening :" + ex.ToString());
      }
    }

    private void StartListen()
    {
      this.listener.Prefixes.Add(string.Format("http://+:{0}/", (object) 90128));
      while (true)
      {
        this.listener.Start();
        HttpListenerContext context = this.listener.GetContext();
        HttpListenerRequest request = context.Request;
        HttpListenerResponse response = context.Response;
        string s = "";
        string rawUrl = request.RawUrl;
        using (StreamReader streamReader = new StreamReader(request.InputStream, request.ContentEncoding))
          streamReader.ReadToEnd();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("============== Oculus Request was sent! ==============\n" + ("URI: " + rawUrl + "\n") + ("Method: " + request.HttpMethod + "\n") + ("Sender: " + context.Request.RemoteEndPoint.ToString() + "\n") + "======================================================\n");
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

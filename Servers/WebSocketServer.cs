// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using OldAPIs;
using System;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace Servers
{
  internal class WebSocketServer
  {
    public WebSocketServer() => Console.WriteLine("[WebSocketServer] has started.");

    public class NotificationV2 : WebSocketBehavior
    {
      protected override void OnMessage(MessageEventArgs e)
      {
        Console.WriteLine("[ws] WEBSOCKET WAS REQUESTED");
        this.Send(Notification.ProcessRequest(e.Data));
      }
    }
  }
}

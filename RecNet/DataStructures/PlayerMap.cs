// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using System.Collections.Generic;

namespace RecNet.DataStructures
{
  public class PlayerMap
  {
    public Dictionary<ulong, MultiplayerPlayer> AllPlayers;

    public PlayerMap() => this.AllPlayers = new Dictionary<ulong, MultiplayerPlayer>();
  }
}

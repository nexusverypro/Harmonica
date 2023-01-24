// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using RecNet.DataStructures;
using System.Collections.Generic;

namespace Client
{
  public class ClientHandle
  {
    public Dictionary<ulong, MultiplayerPlayer> AllPlayers = new Dictionary<ulong, MultiplayerPlayer>();

    public void AddPlayer(MultiplayerPlayer player) => this.AllPlayers.Add((ulong) player.m_PlayerData.Account.accountId, player);

    public MultiplayerPlayer GetPlayerDetails(ulong id)
    {
      MultiplayerPlayer multiplayerPlayer;
      this.AllPlayers.TryGetValue(id, out multiplayerPlayer);
      return multiplayerPlayer;
    }
  }
}

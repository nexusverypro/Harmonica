// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Client;
using Newtonsoft.Json;
using RestSharp;
using Servers;
using System;
using System.Collections;
using System.Collections.Generic;

namespace RecNet
{
  internal static class Relationships
  {
    public static Dictionary<int, Relationships.Player> LocalFriends = new Dictionary<int, Relationships.Player>();
    public static int PlayerAcceptFriendTokenId = 0;
    public static int PlayerSendFriendTokenId = 0;

    public static string Friends() => JsonConvert.SerializeObject((object) new List<Relationships.Player>()
    {
      new Relationships.Player()
      {
        Id = new Random().Next(123856, 1237121231),
        PlayerID = 1,
        RelationshipType = Relationships.RelationshipType.Friend,
        Favorited = Relationships.ReciprocalStatus.Mutual,
        Ignored = Relationships.ReciprocalStatus.None,
        Muted = Relationships.ReciprocalStatus.None
      }
    });

    public static string AcceptFriendRequest(int id)
    {
      ++Relationships.PlayerAcceptFriendTokenId;
      RestClient restClient = new RestClient("https://api.rec.net");
      RestRequest restRequest = new RestRequest("/api/relationships/v2/acceptfriendrequest?id=" + id.ToString());
      restRequest.AddHeader("Authorization", APIServer2.auth);
      restClient.Execute((IRestRequest) restRequest);
      return JsonConvert.SerializeObject((object) new Relationships.Player()
      {
        Id = Relationships.PlayerAcceptFriendTokenId,
        PlayerID = id,
        RelationshipType = Relationships.RelationshipType.Friend,
        Favorited = Relationships.ReciprocalStatus.None,
        Muted = Relationships.ReciprocalStatus.None,
        Ignored = Relationships.ReciprocalStatus.None
      });
    }

    public static string SendFriendRequest(int id)
    {
      ++Relationships.PlayerSendFriendTokenId;
      RestClient restClient = new RestClient("https://api.rec.net");
      RestRequest restRequest = new RestRequest("/api/relationships/v2/sendfriendrequest?id=" + id.ToString());
      restRequest.AddHeader("Authorization", APIServer2.auth);
      restClient.Execute((IRestRequest) restRequest);
      return JsonConvert.SerializeObject((object) new Relationships.Player()
      {
        Id = Relationships.PlayerSendFriendTokenId,
        PlayerID = id,
        RelationshipType = Relationships.RelationshipType.FriendRequestSent,
        Favorited = Relationships.ReciprocalStatus.None,
        Muted = Relationships.ReciprocalStatus.None,
        Ignored = Relationships.ReciprocalStatus.None
      });
    }

    public static string Favorite(int id, bool favorite)
    {
      Relationships.ReciprocalStatus reciprocalStatus = Relationships.ReciprocalStatus.None;
      if (favorite)
      {
        if (favorite)
          reciprocalStatus = Relationships.ReciprocalStatus.Mutual;
      }
      else
        reciprocalStatus = Relationships.ReciprocalStatus.None;
      Relationships.Player player = new Relationships.Player()
      {
        Id = new Random().Next(79123, 812736123),
        PlayerID = id,
        RelationshipType = Relationships.RelationshipType.FriendRequestSent,
        Favorited = reciprocalStatus,
        Muted = Relationships.ReciprocalStatus.None,
        Ignored = Relationships.ReciprocalStatus.None
      };
      Relationships.LocalFriends[id].Favorited = player.Favorited;
      return JsonConvert.SerializeObject((object) player);
    }

    public static string Mute(int id, bool mute)
    {
      Relationships.ReciprocalStatus reciprocalStatus = Relationships.ReciprocalStatus.None;
      if (mute)
      {
        if (mute)
          reciprocalStatus = Relationships.ReciprocalStatus.Mutual;
      }
      else
        reciprocalStatus = Relationships.ReciprocalStatus.None;
      Relationships.Player player = new Relationships.Player()
      {
        Id = Relationships.LocalFriends[id].Id,
        PlayerID = Relationships.LocalFriends[id].PlayerID,
        RelationshipType = Relationships.LocalFriends[id].RelationshipType,
        Favorited = Relationships.LocalFriends[id].Favorited,
        Muted = reciprocalStatus,
        Ignored = Relationships.LocalFriends[id].Ignored
      };
      Relationships.LocalFriends[id].Muted = player.Muted;
      return JsonConvert.SerializeObject((object) player);
    }

    public static string Ignore(int id, bool ignore)
    {
      Relationships.ReciprocalStatus reciprocalStatus = Relationships.ReciprocalStatus.None;
      if (ignore)
      {
        if (ignore)
          reciprocalStatus = Relationships.ReciprocalStatus.Mutual;
      }
      else
        reciprocalStatus = Relationships.ReciprocalStatus.None;
      Relationships.Player player = new Relationships.Player()
      {
        Id = Relationships.LocalFriends[id].Id,
        PlayerID = Relationships.LocalFriends[id].PlayerID,
        RelationshipType = Relationships.LocalFriends[id].RelationshipType,
        Favorited = Relationships.LocalFriends[id].Favorited,
        Muted = Relationships.LocalFriends[id].Muted,
        Ignored = reciprocalStatus
      };
      Relationships.LocalFriends[id].Ignored = player.Ignored;
      return JsonConvert.SerializeObject((object) player);
    }

    public static IEnumerator SaveToFileCoroutine()
    {
      while (true)
        Relationships.Save();
    }

    public static void Save() => RecNet.Handler.SaveData.SaveData.SetSaveData(ClientSecurity.EncodeTo64(JsonConvert.SerializeObject((object) Relationships.LocalFriends)), Environment.CurrentDirectory + "\\Friends.txt");

    public class Player
    {
      public int Id { get; set; }

      public int PlayerID { get; set; }

      public Relationships.RelationshipType RelationshipType { get; set; }

      public Relationships.ReciprocalStatus Favorited { get; set; }

      public Relationships.ReciprocalStatus Muted { get; set; }

      public Relationships.ReciprocalStatus Ignored { get; set; }
    }

    public enum RelationshipType
    {
      None,
      FriendRequestSent,
      FriendRequestReceived,
      Friend,
    }

    public enum ReciprocalStatus
    {
      None,
      Local,
      Remote,
      Mutual,
    }
  }
}

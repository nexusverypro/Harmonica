// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Configs;
using Newtonsoft.Json;
using System;

namespace OldAPIs
{
  public class GameSessions
  {
    public static string JoinRandom(string jsonData)
    {
      Console.WriteLine("[API][GameSession] Attempting to join random room.");
      GameSessions.JoinRandomRequest joinRandomRequest = JsonConvert.DeserializeObject<GameSessions.JoinRandomRequest>(jsonData);
      if (Config.localGameSession == null)
      {
        Config.localGameSession = new GameSessions.SessionInstance()
        {
          GameSessionId = 2842L,
          RegionId = "au",
          RoomId = joinRandomRequest.ActivityLevelIds[0],
          RecRoomId = new long?(),
          EventId = new long?(),
          CreatorPlayerId = new long?(1L),
          Name = "Dorm Room",
          ActivityLevelId = joinRandomRequest.ActivityLevelIds[0],
          Private = false,
          Sandbox = false,
          SupportsScreens = true,
          SupportsVR = true,
          GameInProgress = false,
          MaxCapacity = 20,
          IsFull = false
        };
      }
      else
      {
        Config.localGameSession.RoomId = joinRandomRequest.ActivityLevelIds[0];
        Config.localGameSession.ActivityLevelId = joinRandomRequest.ActivityLevelIds[0];
        Config.localGameSession.Sandbox = false;
      }
      return JsonConvert.SerializeObject((object) new GameSessions.JoinResult()
      {
        Result = 0,
        GameSession = Config.localGameSession
      });
    }

    public static string StatusSession() => JsonConvert.SerializeObject((object) new GameSessions.PlayerStatus()
    {
      PlayerId = Config.playerID,
      IsOnline = true,
      InScreenMode = false,
      GameSession = Config.localGameSession
    });

    public static string Create(string jsonData)
    {
      Console.WriteLine("[API][GameSession] Creating Room...");
      GameSessions.CreateRequest createRequest = JsonConvert.DeserializeObject<GameSessions.CreateRequest>(jsonData);
      if (Config.localGameSession == null)
      {
        Config.localGameSession = new GameSessions.SessionInstance()
        {
          GameSessionId = 2842L,
          RegionId = "au",
          RoomId = createRequest.ActivityLevelIds,
          RecRoomId = new long?(),
          EventId = new long?(),
          CreatorPlayerId = new long?(Convert.ToInt64(Config.playerID)),
          Name = "Dorm Room",
          ActivityLevelId = createRequest.ActivityLevelIds,
          Private = true,
          Sandbox = true,
          SupportsScreens = true,
          SupportsVR = true,
          GameInProgress = false,
          MaxCapacity = 20,
          IsFull = false
        };
      }
      else
      {
        Config.localGameSession.RoomId = createRequest.ActivityLevelIds;
        Config.localGameSession.ActivityLevelId = createRequest.ActivityLevelIds;
        Config.localGameSession.Sandbox = createRequest.IsSandbox;
      }
      return JsonConvert.SerializeObject((object) new GameSessions.JoinResult()
      {
        Result = 0,
        GameSession = Config.localGameSession
      });
    }

    public static GameSessions.PlayerStatus StatusSessionInstance() => new GameSessions.PlayerStatus()
    {
      PlayerId = Config.playerID,
      IsOnline = true,
      InScreenMode = false,
      GameSession = Config.localGameSession
    };

    public enum JoinResultIDs
    {
      Success = 0,
      NoSuchGame = 1,
      PlayerNotOnline = 2,
      InsufficientSpace = 3,
      EventNotStarted = 4,
      EventAlreadyFinished = 5,
      EventCreatorNotReady = 6,
      BlockedFromRoom = 7,
      ProfileLocked = 8,
      NoBirthday = 9,
      MarkedForDelete = 10, // 0x0000000A
      JuniorNotAllowed = 11, // 0x0000000B
      Banned = 12, // 0x0000000C
      NoSuchRoom = 20, // 0x00000014
      RoomCreatorNotReady = 21, // 0x00000015
      RoomIsNotActive = 22, // 0x00000016
      RoomBlockedByCreator = 23, // 0x00000017
      RoomBlockingCreator = 24, // 0x00000018
      RoomIsPrivate = 25, // 0x00000019
    }

    public class PlayerStatus
    {
      public ulong PlayerId { get; set; }

      public bool IsOnline { get; set; }

      public bool InScreenMode { get; set; }

      public GameSessions.SessionInstance GameSession { get; set; }
    }

    public class SessionInstance
    {
      public long GameSessionId { get; set; }

      public string RegionId { get; set; }

      public string RoomId { get; set; }

      public long? EventId { get; set; }

      public long? RecRoomId { get; set; }

      public long? CreatorPlayerId { get; set; }

      public string Name { get; set; }

      public string ActivityLevelId { get; set; }

      public bool Private { get; set; }

      public bool Sandbox { get; set; }

      public bool SupportsVR { get; set; }

      public bool SupportsScreens { get; set; }

      public bool GameInProgress { get; set; }

      public int MaxCapacity { get; set; }

      public bool IsFull { get; set; }
    }

    public class JoinRandomRequest
    {
      public string[] ActivityLevelIds { get; set; }

      public ulong[] ExpectedPlayerIds { get; set; }

      public GameSessions.RegionPing[] RegionPings { get; set; }
    }

    public class CreateRequest
    {
      public string ActivityLevelIds { get; set; }

      public ulong[] ExpectedPlayerIds { get; set; }

      public GameSessions.RegionPing[] RegionPings { get; set; }

      public bool IsSandbox { get; set; }
    }

    public class RegionPing
    {
      public string Region { get; set; }

      public int Ping { get; set; }
    }

    private class JoinResult
    {
      public int Result { get; set; }

      public GameSessions.SessionInstance GameSession { get; set; }
    }
  }
}

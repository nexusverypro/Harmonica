// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace RecNet
{
  internal class PlayerEvents
  {
    public static List<PlayerEvents.RoomEvent> LocalEventList = new List<PlayerEvents.RoomEvent>()
    {
      new PlayerEvents.RoomEvent()
      {
        PlayerEventId = 1,
        CreatorPlayerId = 1,
        ImageName = "DefaultProfileImage",
        RoomId = 170126,
        SubRoomId = 170120,
        ClubId = (object) null,
        Name = "Harmonica Event 1",
        Description = "Rec Room private server event test",
        StartTime = DateTime.Parse("2021-10-06T11:15:00Z"),
        EndTime = DateTime.Parse("2021-11-06T11:15:00Z"),
        AttendeeCount = 999,
        State = 0,
        Accessibility = 1,
        IsMultiInstance = false,
        SupportMultiInstanceRoomChat = true
      },
      new PlayerEvents.RoomEvent()
      {
        PlayerEventId = 2,
        CreatorPlayerId = 1,
        ImageName = "DefaultProfileImage",
        RoomId = 170132,
        SubRoomId = 170126,
        ClubId = (object) null,
        Name = "Harmonica Event 2",
        Description = "Rec Room private server event test",
        StartTime = DateTime.Parse("2021-10-06T11:15:00Z"),
        EndTime = DateTime.Parse("2021-11-06T11:15:00Z"),
        AttendeeCount = 999,
        State = 0,
        Accessibility = 1,
        IsMultiInstance = false,
        SupportMultiInstanceRoomChat = true
      }
    };

    public static List<PlayerEvents.RoomEvent> Search(string query) => new List<PlayerEvents.RoomEvent>();

    public static string Filters() => JsonConvert.SerializeObject((object) new PlayerEvents.RoomFilter()
    {
      PinnedFilters = new List<string>()
      {
        "harmonica",
        "reccon",
        "celebration",
        "workshops",
        "class",
        "coop",
        "competition",
        "game",
        "grandopening",
        "meetup"
      },
      PopularFilters = new List<string>()
      {
        "celebration",
        "workshops",
        "class",
        "coop",
        "competition",
        "game",
        "grandopening",
        "meetup",
        "performance"
      },
      TrendingFilters = new List<string>()
    });

    public static List<PlayerEvents.RoomEvent> GetRoomWithId(int roomId) => new List<PlayerEvents.RoomEvent>()
    {
      new PlayerEvents.RoomEvent()
      {
        PlayerEventId = 1,
        CreatorPlayerId = 1,
        ImageName = "DefaultProfileImage",
        RoomId = roomId,
        SubRoomId = roomId + 2,
        ClubId = (object) null,
        Name = "Harmonica Event 1",
        Description = "Rec Room private server event test",
        StartTime = DateTime.Parse("2021-10-06T11:15:00Z"),
        EndTime = DateTime.Parse("2021-11-06T11:15:00Z"),
        AttendeeCount = 999,
        State = 0,
        Accessibility = 1,
        IsMultiInstance = false,
        SupportMultiInstanceRoomChat = true
      }
    };

    public class RoomFilter
    {
      public List<string> PinnedFilters { get; set; }

      public List<string> PopularFilters { get; set; }

      public List<string> TrendingFilters { get; set; }
    }

    public class RoomEvent
    {
      public int PlayerEventId { get; set; }

      public int CreatorPlayerId { get; set; }

      public string ImageName { get; set; }

      public int RoomId { get; set; }

      public int SubRoomId { get; set; }

      public object ClubId { get; set; }

      public string Name { get; set; }

      public string Description { get; set; }

      public DateTime StartTime { get; set; }

      public DateTime EndTime { get; set; }

      public int AttendeeCount { get; set; }

      public int State { get; set; }

      public int Accessibility { get; set; }

      public bool IsMultiInstance { get; set; }

      public bool SupportMultiInstanceRoomChat { get; set; }
    }
  }
}

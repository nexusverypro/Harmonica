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
  internal static class Rooms
  {
    public static string FallbackToDorm() => JsonConvert.SerializeObject((object) new Rooms.Room()
    {
      RoomId = 31630177,
      IsDorm = true,
      MaxPlayerCalculationMode = 0,
      MaxPlayers = 90,
      CloningAllowed = false,
      DisableMicAutoMute = false,
      DisableRoomComments = true,
      EncryptVoiceChat = true,
      LoadScreenLocked = false,
      Name = "Dorm Room",
      Description = "Your private room",
      ImageName = "DefaultRoomImage.jpg",
      WarningMask = 0,
      CustomWarning = (object) null,
      CreatorAccountId = 29241908,
      State = 0,
      Accessibility = 0,
      SupportsLevelVoting = false,
      IsRRO = false,
      SupportsScreens = true,
      SupportsWalkVR = true,
      SupportsTeleportVR = true,
      SupportsVRLow = true,
      SupportsQuest2 = true,
      SupportsMobile = true,
      SupportsJuniors = true,
      MinLevel = 0,
      CreatedAt = DateTime.UtcNow,
      Stats = new Rooms.Stats()
      {
        CheerCount = 1,
        FavoriteCount = 1,
        VisitCount = 1,
        VisitorCount = 1
      }
    });

    public static string OwnedByMe() => JsonConvert.SerializeObject((object) new List<Rooms.cRoom>()
    {
      new Rooms.cRoom()
      {
        RoomId = 31630177,
        IsDorm = true,
        MaxPlayerCalculationMode = 0,
        MaxPlayers = 90,
        CloningAllowed = false,
        DisableMicAutoMute = false,
        DisableRoomComments = true,
        EncryptVoiceChat = true,
        LoadScreenLocked = false,
        Name = "Dorm Room",
        Description = "Your private room",
        ImageName = "DefaultRoomImage.jpg",
        WarningMask = 0,
        CustomWarning = (object) null,
        CreatorAccountId = 29241908,
        State = 0,
        Accessibility = 0,
        SupportsLevelVoting = false,
        IsRRO = false,
        SupportsScreens = true,
        SupportsWalkVR = true,
        SupportsTeleportVR = true,
        SupportsVRLow = true,
        SupportsQuest2 = true,
        SupportsMobile = true,
        SupportsJuniors = true,
        MinLevel = 0,
        CreatedAt = DateTime.UtcNow.ToString(),
        Stats = new Rooms.Stats()
        {
          CheerCount = 1,
          FavoriteCount = 1,
          VisitCount = 1,
          VisitorCount = 1
        }
      },
      new Rooms.cRoom()
      {
        RoomId = 170126,
        IsDorm = false,
        MaxPlayerCalculationMode = 0,
        MaxPlayers = 12,
        CloningAllowed = true,
        DisableMicAutoMute = false,
        DisableRoomComments = true,
        EncryptVoiceChat = true,
        LoadScreenLocked = false,
        Name = "Rec Center",
        Description = "A social hub to meet and mingle with friends new and old.",
        ImageName = "22eefa3219f046fd9e2090814650ede3",
        WarningMask = 0,
        CustomWarning = (object) null,
        CreatorAccountId = 29241908,
        State = 0,
        Accessibility = 1,
        SupportsLevelVoting = false,
        IsRRO = true,
        SupportsScreens = true,
        SupportsWalkVR = true,
        SupportsTeleportVR = true,
        SupportsVRLow = true,
        SupportsQuest2 = true,
        SupportsMobile = true,
        SupportsJuniors = true,
        MinLevel = 0,
        CreatedAt = "2018-08-28T15:44:47.3149535Z",
        Stats = new Rooms.Stats()
        {
          CheerCount = 1,
          FavoriteCount = 1,
          VisitCount = 1,
          VisitorCount = 1
        }
      }
    });

    public class SubRoom
    {
      public int SubRoomId { get; set; }

      public int RoomId { get; set; }

      public string UnitySceneId { get; set; }

      public string Name { get; set; }

      public string DataBlob { get; set; }

      public string DataBlobHash { get; set; }

      public string DataSavedAt { get; set; }

      public bool IsSandbox { get; set; }

      public int MaxPlayers { get; set; }

      public int Accessibility { get; set; }
    }

    public class cTag
    {
      public string Tag { get; set; }

      public int Type { get; set; }
    }

    public class cRoom
    {
      public int RoomId { get; set; }

      public bool IsDorm { get; set; }

      public int MaxPlayerCalculationMode { get; set; }

      public int MaxPlayers { get; set; }

      public bool CloningAllowed { get; set; }

      public bool DisableMicAutoMute { get; set; }

      public bool DisableRoomComments { get; set; }

      public bool EncryptVoiceChat { get; set; }

      public bool LoadScreenLocked { get; set; }

      public string Name { get; set; }

      public string Description { get; set; }

      public string ImageName { get; set; }

      public int WarningMask { get; set; }

      public object CustomWarning { get; set; }

      public int CreatorAccountId { get; set; }

      public int State { get; set; }

      public int Accessibility { get; set; }

      public bool SupportsLevelVoting { get; set; }

      public bool IsRRO { get; set; }

      public bool SupportsScreens { get; set; }

      public bool SupportsWalkVR { get; set; }

      public bool SupportsTeleportVR { get; set; }

      public bool SupportsVRLow { get; set; }

      public bool SupportsQuest2 { get; set; }

      public bool SupportsMobile { get; set; }

      public bool SupportsJuniors { get; set; }

      public int MinLevel { get; set; }

      public string CreatedAt { get; set; }

      public Rooms.Stats Stats { get; set; }

      public List<Rooms.SubRoom> SubRooms { get; set; }

      public List<Rooms.cTag> Tags { get; set; }

      public List<object> PromoImages { get; set; }

      public List<object> PromoExternalContent { get; set; }

      public List<object> LoadScreens { get; set; }
    }

    public class Stats
    {
      public int CheerCount { get; set; }

      public int FavoriteCount { get; set; }

      public int VisitorCount { get; set; }

      public int VisitCount { get; set; }
    }

    public class Room
    {
      public int RoomId { get; set; }

      public bool IsDorm { get; set; }

      public int MaxPlayerCalculationMode { get; set; }

      public int MaxPlayers { get; set; }

      public bool CloningAllowed { get; set; }

      public bool DisableMicAutoMute { get; set; }

      public bool DisableRoomComments { get; set; }

      public bool EncryptVoiceChat { get; set; }

      public bool LoadScreenLocked { get; set; }

      public string Name { get; set; }

      public string Description { get; set; }

      public string ImageName { get; set; }

      public int WarningMask { get; set; }

      public object CustomWarning { get; set; }

      public int CreatorAccountId { get; set; }

      public int State { get; set; }

      public int Accessibility { get; set; }

      public bool SupportsLevelVoting { get; set; }

      public bool IsRRO { get; set; }

      public bool SupportsScreens { get; set; }

      public bool SupportsWalkVR { get; set; }

      public bool SupportsTeleportVR { get; set; }

      public bool SupportsVRLow { get; set; }

      public bool SupportsQuest2 { get; set; }

      public bool SupportsMobile { get; set; }

      public bool SupportsJuniors { get; set; }

      public int MinLevel { get; set; }

      public DateTime CreatedAt { get; set; }

      public Rooms.Stats Stats { get; set; }
    }

    public class RoomModifyResponse
    {
      public Rooms.CreateModifyRoomStatus Result { get; set; }
    }

    public enum CreateModifyRoomStatus
    {
      Success = 0,
      Unknown = 1,
      PermissionDenied = 2,
      RoomNotActive = 3,
      RoomDoesNotExist = 4,
      RoomHasNoDataBlob = 5,
      DuplicateName = 10, // 0x0000000A
      ReservedName = 11, // 0x0000000B
      InappropriateName = 12, // 0x0000000C
      InappropriateDescription = 13, // 0x0000000D
      TooManyRooms = 20, // 0x00000014
      InvalidMaxPlayers = 30, // 0x0000001E
      DataHistoryDoesNotExist = 40, // 0x00000028
      DataHistoryAlreadyActive = 41, // 0x00000029
      InvalidTags = 50, // 0x00000032
      NoStartingRoomScene = 55, // 0x00000037
      RoomUnderModerationReview = 100, // 0x00000064
      PlayerHasRoomUnderModerationReview = 101, // 0x00000065
      AccessibilityUnderModerationLock = 102, // 0x00000066
      JuniorStatusFail = 200, // 0x000000C8
      InappropriateCustomWarning = 300, // 0x0000012C
      PartialBanSuccessBanPower = 400, // 0x00000190
      TargetHasBanPower = 401, // 0x00000191
      PlayerIsRoomBanned = 410, // 0x0000019A
    }
  }
}

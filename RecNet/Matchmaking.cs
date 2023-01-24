// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Newtonsoft.Json;

namespace RecNet
{
  internal static class Matchmaking
  {
    public static PlayerPresence GenericPresenceEventResponse = new PlayerPresence()
    {
      playerId = 1,
      statusVisibility = PlayerStatusVisibility.Public,
      deviceClass = DeviceClass.Screen,
      vrMovementMode = VRMovementMode.WALK,
      roomInstance = new RoomInstance()
      {
        roomId = 1,
        roomInstanceId = 1,
        subRoomId = 1,
        dataBlob = "",
        isFull = false,
        isInProgress = false,
        isPrivate = false,
        location = "",
        maxCapacity = 20,
        name = "",
        photonRegionId = "",
        photonRoomId = "",
        roomInstanceType = 0
      },
      isOnline = true,
      appVersion = "20221008"
    };

    public static string DefaultPresence() => JsonConvert.SerializeObject((object) new PlayerPresence()
    {
      playerId = 1,
      statusVisibility = PlayerStatusVisibility.Public,
      deviceClass = DeviceClass.Screen,
      vrMovementMode = VRMovementMode.WALK,
      roomInstance = new RoomInstance()
      {
        roomId = 1,
        roomInstanceId = 1,
        subRoomId = 1,
        dataBlob = "",
        isFull = false,
        isInProgress = false,
        isPrivate = false,
        location = "",
        maxCapacity = 20,
        name = "",
        photonRegionId = "",
        photonRoomId = "",
        roomInstanceType = 0
      },
      isOnline = true,
      appVersion = "20221008"
    });

    public static string FallbackToDorm() => JsonConvert.SerializeObject((object) new Matchmaking.MatchRoomDTO()
    {
      errorCode = Matchmaking.MatchmakingErrorCode.Success,
      roomInstance = new RoomInstance()
      {
        roomId = 32712685,
        roomInstanceId = 849735346,
        subRoomId = 33376137,
        dataBlob = "",
        isFull = true,
        isInProgress = false,
        isPrivate = true,
        location = "76d98498-60a1-430c-ab76-b54a29b7a163",
        maxCapacity = 1,
        name = "Dorm Room",
        photonRegionId = "eu",
        photonRoomId = "59e904ef-803e-41ec-b3d0-b5e684168121",
        roomInstanceType = 2
      }
    });

    public enum MatchmakingErrorCode
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
      AlreadyInBestInstance = 13, // 0x0000000D
      InsufficientRelationship = 14, // 0x0000000E
      UpdateRequired = 16, // 0x00000010
      AlreadyInTargetInstance = 17, // 0x00000011
      RegistrationRequired = 18, // 0x00000012
      UGCNotAllowed = 19, // 0x00000013
      NoSuchRoom = 20, // 0x00000014
      RoomCreatorNotReady = 21, // 0x00000015
      RoomIsNotActive = 22, // 0x00000016
      RoomBlockedByCreator = 23, // 0x00000017
      RoomBlockingCreator = 24, // 0x00000018
      RoomIsPrivate = 25, // 0x00000019
      RoomInstanceIsPrivate = 26, // 0x0000001A
      DeviceClassNotSupported = 30, // 0x0000001E
      DeviceClassNotSupportedByRoomOwner = 31, // 0x0000001F
      VRMovementModeNotSupportedByRoomOwner = 32, // 0x00000020
      EventIsPrivate = 35, // 0x00000023
      RoomInviteExpired = 40, // 0x00000028
      NoAvailableRegion = 45, // 0x0000002D
      NotorietyTooPoor = 50, // 0x00000032
      BannedFromRoom = 55, // 0x00000037
    }

    public class MatchRoomDTO
    {
      public Matchmaking.MatchmakingErrorCode errorCode { get; set; }

      public RoomInstance roomInstance { get; set; }
    }

    public class MatchmakingResponse
    {
      public Matchmaking.MatchmakingErrorCode ErrorCode { get; set; }

      public RoomInstance RoomInstance { get; set; }
    }
  }
}

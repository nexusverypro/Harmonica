// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using System;
using System.Collections.Generic;

namespace RecNet
{
  public class PlayerReputation
  {
    public static List<PlayerReputation.PlayerReputationDTO> GetProgressionBulk(
      int[] ids)
    {
      List<PlayerReputation.PlayerReputationDTO> playerReputationDtoList = new List<PlayerReputation.PlayerReputationDTO>();
      foreach (int id in ids)
        playerReputationDtoList.Add(new PlayerReputation.PlayerReputationDTO()
        {
          AccountId = id,
          IsCheerful = true,
          Noteriety = 0.0,
          SelectedCheer = (object) 40,
          CheerCredit = 20,
          CheerGeneral = 173,
          CheerHelpful = 46,
          CheerCreative = 65,
          CheerGreatHost = 80,
          CheerSportsman = 52
        });
      return playerReputationDtoList;
    }

    public enum HileType
    {
      Time = 0,
      Inject = 1,
      GiftCount = 2,
      Engine = 3,
      UnknownDll = 4,
      ImageSignature = 5,
      AvatarHack = 6,
      [Obsolete] NetworkCertificatePublicKey = 100, // 0x00000064
      [Obsolete] NetworkCertificateIssuer = 101, // 0x00000065
      NetworkCertificateMissing = 102, // 0x00000066
      NetworkCertificateMismatch = 103, // 0x00000067
      AutosaveChecksumMismatch = 150, // 0x00000096
      AutosaveSubRoomIdMismatch = 151, // 0x00000097
      AutosaveChecksumException = 152, // 0x00000098
      Photon_MissingHash = 200, // 0x000000C8
      Photon_CorruptHash = 201, // 0x000000C9
      Photon_DifferentHash = 203, // 0x000000CB
      AppData_Runtime_LengthMismatch = 300, // 0x0000012C
      AppData_Runtime_LastWriteTimeMismatch = 301, // 0x0000012D
      AppData_Boot_InvalidSignature = 310, // 0x00000136
      AppData_Boot_UnableToVerifySignatures = 311, // 0x00000137
    }

    public class PlayerReputationDTO
    {
      public int AccountId { get; set; }

      public bool IsCheerful { get; set; }

      public double Noteriety { get; set; }

      public object SelectedCheer { get; set; }

      public int CheerCredit { get; set; }

      public int CheerGeneral { get; set; }

      public int CheerHelpful { get; set; }

      public int CheerCreative { get; set; }

      public int CheerGreatHost { get; set; }

      public int CheerSportsman { get; set; }
    }
  }
}

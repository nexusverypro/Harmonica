// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Configs;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace OldAPIs
{
  public class PlatformLogin2019Profile
  {
    public ulong Id { get; set; }

    public string Username { get; set; }

    public string DisplayName { get; set; }

    public int XP { get; set; }

    public int Level { get; set; }

    public int RegistrationStatus { get; set; }

    public bool Developer { get; set; }

    public bool CanReceiveInvites { get; set; }

    public string ProfileImageName { get; set; }

    public bool JuniorProfile { get; set; }

    public bool ForceJuniorImages { get; set; }

    public bool PendingJunior { get; set; }

    public bool HasBirthday { get; set; }

    public bool AvoidJuniors { get; set; }

    public mPlayerReputation Reputation { get; set; }

    public List<mPlatformID> PlatformId { get; set; }

    public static string GetDebugLogin(UserConfig LoginProfile) => JsonConvert.SerializeObject((object) new List<PlatformLogin2019Profile>()
    {
      new PlatformLogin2019Profile()
      {
        Id = LoginProfile.UserID,
        Username = LoginProfile.UserName,
        DisplayName = LoginProfile.DisplayName,
        XP = 9999,
        Level = LoginProfile.Level,
        RegistrationStatus = 2,
        Verified = true,
        Developer = LoginProfile.Developer,
        CanReceiveInvites = false,
        ProfileImageName = "test",
        JuniorProfile = false,
        ForceJuniorImages = false,
        PendingJunior = false,
        HasBirthday = true,
        AvoidJuniors = true,
        Reputation = new mPlayerReputation()
        {
          Noteriety = 0,
          CheerCredit = 20,
          CheerGeneral = 10,
          CheerHelpful = 10,
          CheerGreatHost = 10,
          CheerSportsman = 10,
          CheerCreative = 10,
          SubscriberCount = 0,
          SubscribedCount = 0,
          SelectedCheer = 0
        },
        PlatformId = new List<mPlatformID>()
        {
          new mPlatformID()
          {
            Platform = 0,
            PlatformId = 76561198243518990UL
          }
        }
      }
    });

    public string Bio { get; set; }

    public bool Verified { get; set; }
  }
}

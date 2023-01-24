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
  public class loginCachedFunc
  {
    public string Error { get; set; }

    public PlatformLogin2019Profile Player { get; set; }

    public string Token { get; set; }

    public bool FirstLoginOfTheDay { get; set; }

    public ulong AnalyticsSessionId { get; set; }

    public bool CanUseScreenMode { get; set; }

    public static string loginCache(UserConfig LoginProfile) => JsonConvert.SerializeObject((object) new loginCachedFunc()
    {
      Error = "",
      Player = new PlatformLogin2019Profile()
      {
        Id = LoginProfile.UserID,
        Username = LoginProfile.UserName,
        DisplayName = LoginProfile.DisplayName,
        XP = 1,
        Level = LoginProfile.Level,
        RegistrationStatus = 2,
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
            PlatformId = 76561198243518990UL,
            DeviceId = "shut up amongus"
          }
        }
      },
      Token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOjEsImV4cCI6MTYxOTI4NzQ2MSwidmVycyI6IjIwMTcxMTE3X0VBIn0.-GqtcqPwAzr9ZJioTiz5v0Kl4HMMjH8hFMtVzQtRN5c",
      FirstLoginOfTheDay = true,
      AnalyticsSessionId = 392394UL,
      CanUseScreenMode = true
    });
  }
}

// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Configs;
using Newtonsoft.Json;
using System.IO;

namespace OldAPIs
{
  internal class Players
  {
    public static string GetOrCreate(UserConfig player) => JsonConvert.SerializeObject((object) new Profile()
    {
      Id = player.UserID,
      Username = Players.playerName(),
      DisplayName = Players.playerName(),
      XP = 48,
      Level = player.Level,
      Reputation = 0,
      Verified = true,
      Developer = false,
      HasEmail = true,
      CanReceiveInvites = false,
      ProfileImageName = "1a427b60c9d7446da6331ce66077239c.jpg",
      HasBirthday = true
    });

    public static string GetOrCreateArray(UserConfig player) => JsonConvert.SerializeObject((object) new Profile[1]
    {
      new Profile()
      {
        Id = player.UserID,
        Username = Players.playerName(),
        DisplayName = Players.playerName(),
        XP = 48,
        Level = player.Level,
        Reputation = 0,
        Verified = true,
        Developer = false,
        HasEmail = true,
        CanReceiveInvites = false,
        ProfileImageName = "1a427b60c9d7446da6331ce66077239c.jpg",
        JuniorProfile = false,
        ForceJuniorImages = false,
        HasBirthday = true
      }
    });

    public static string playerName() => File.ReadAllText("playerNameConfig.txt");
  }
}

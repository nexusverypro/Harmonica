// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace OldAPIs
{
  internal class Settings
  {
    private static List<Setting> playerSettings;
    public static string SettingsPath = Environment.CurrentDirectory + "\\Resources\\LocalSettings";

    public static string GetPlayerSettings()
    {
      if (Settings.playerSettings == null)
        Settings.playerSettings = !File.Exists(Settings.SettingsPath) ? Settings.CreateDefaultSettings() : Settings.LoadSettings();
      return JsonConvert.SerializeObject((object) Settings.playerSettings);
    }

    public static void SetPlayerSettings(string jsonData)
    {
      if (jsonData == "")
      {
        Console.WriteLine("[api.lh] Json data is empty.");
      }
      else
      {
        Setting setting = JsonConvert.DeserializeObject<Setting>(jsonData);
        for (int index = 0; index < Settings.playerSettings.Count; ++index)
        {
          if (Settings.playerSettings[index].Key == setting.Key)
          {
            Settings.playerSettings[index].Value = setting.Value;
            Settings.SaveSettings(Settings.playerSettings);
            return;
          }
        }
        Settings.playerSettings.Add(new Setting()
        {
          Key = setting.Key,
          Value = setting.Value
        });
        Settings.SaveSettings(Settings.playerSettings);
      }
    }

    public static List<Setting> CreateDefaultSettings() => new List<Setting>()
    {
      new Setting() { Key = "PlayerSessionCount", Value = "1" },
      new Setting()
      {
        Key = "SplitTestAssignedSegments",
        Value = "1|{\"SplitTesting+RoomRecommendations_2020_05_06\":\"Off\",\"SplitTesting+RoomRecommendationsType_2020_08_14\":\"Aug14MinVisitors3500\",\"SplitTesting+ProfileOnClick_2021_04_30\":\"On\"}"
      },
      new Setting()
      {
        Key = "Recroom.ChallengeMap",
        Value = "244"
      },
      new Setting() { Key = "USER_TRACKING", Value = "1" },
      new Setting()
      {
        Key = "BACKPACK_FAVORITE_TOOL",
        Value = "-1"
      },
      new Setting() { Key = "MakerPen_SnappingMode", Value = "0" },
      new Setting()
      {
        Key = "TUTORIAL_COMPLETE_MASK",
        Value = "57"
      },
      new Setting()
      {
        Key = "Recroom.AccountCreation.HasStarted",
        Value = "True"
      },
      new Setting()
      {
        Key = "Recroom.AccountCreation.HasFinished",
        Value = "True"
      },
      new Setting()
      {
        Key = "Recroom.AccountCreation.HasChosenUsername",
        Value = "True"
      },
      new Setting()
      {
        Key = "Recroom.AccountCreation.HasCreatedPassword",
        Value = "True"
      },
      new Setting()
      {
        Key = "HAS_OPENED_WATCH_MENU_BEFORE",
        Value = "True"
      },
      new Setting()
      {
        Key = "HasCheckedForPlatformReferrers",
        Value = "True"
      },
      new Setting() { Key = "RoomsVisited", Value = "2" }
    };

    public static List<Setting> LoadSettings()
    {
      List<Setting> settingList = new List<Setting>();
      using (BinaryReader binaryReader = new BinaryReader((Stream) File.Open(Settings.SettingsPath, FileMode.Open)))
      {
        while (binaryReader.BaseStream.Position != binaryReader.BaseStream.Length)
        {
          Setting setting = new Setting()
          {
            Key = binaryReader.ReadString(),
            Value = binaryReader.ReadString()
          };
          settingList.Add(setting);
        }
      }
      return settingList;
    }

    public static void SaveSettings(List<Setting> settings)
    {
      using (BinaryWriter binaryWriter = new BinaryWriter((Stream) File.Create(Settings.SettingsPath)))
      {
        foreach (Setting setting in settings)
        {
          binaryWriter.Write(setting.Key);
          binaryWriter.Write(setting.Value);
        }
      }
    }
  }
}

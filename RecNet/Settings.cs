// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace RecNet
{
  public class Settings
  {
    public static List<Settings.Setting> LocalSettings = new List<Settings.Setting>();
    public static Dictionary<int, List<Settings.Setting>> AllGlobalSettings;

    public static void AddSetting(Settings.Setting setting) => Settings.LocalSettings.Add(setting);

    public static void SetDefaultSettings()
    {
    }

    public static List<Settings.Setting> LoadSettings() => JsonConvert.DeserializeObject<List<Settings.Setting>>(File.ReadAllText(Environment.CurrentDirectory + "\\Settings.txt"));

    public static void SetSetting(string key, string value)
    {
      foreach (Settings.Setting localSetting in Settings.LocalSettings)
      {
        if (localSetting.Key == key)
        {
          localSetting.Value = value;
          Settings.SaveSettings();
        }
        else
        {
          Settings.AddSetting(new Settings.Setting()
          {
            Key = key,
            Value = value
          });
          Settings.SaveSettings();
        }
      }
    }

    public static void SaveSetting(string postdata)
    {
      Settings.Setting setting = JsonConvert.DeserializeObject<Settings.Setting>(postdata);
      Settings.LocalSettings.Add(setting);
      File.WriteAllText(Environment.CurrentDirectory + "\\Settings.txt", JsonConvert.SerializeObject((object) Settings.LocalSettings));
    }

    public static void SaveSettings() => File.WriteAllText(Environment.CurrentDirectory + "\\Settings.txt", JsonConvert.SerializeObject((object) Settings.LocalSettings));

    public static List<Settings.Setting> LoadMultiplayerSettings(int id)
    {
      Settings.AllGlobalSettings = JsonConvert.DeserializeObject<Dictionary<int, List<Settings.Setting>>>(File.ReadAllText("global-settings-metadata.txt"));
      if (!Settings.AllGlobalSettings.ContainsKey(id))
      {
        Settings.AllGlobalSettings.Add(id, new List<Settings.Setting>()
        {
          new Settings.Setting() { Key = "PlayerHeight", Value = "1" },
          new Settings.Setting()
          {
            Key = "MakerPen_SnappingMode",
            Value = "0"
          },
          new Settings.Setting()
          {
            Key = "ROTATE_IN_PLACE_ENABLED",
            Value = "True"
          },
          new Settings.Setting()
          {
            Key = "ROTATION_INCREMENT",
            Value = "1"
          },
          new Settings.Setting()
          {
            Key = "HAS_OPENED_WATCH_MENU_BEFORE",
            Value = "True"
          },
          new Settings.Setting()
          {
            Key = "VR_MOVEMENT_MODE",
            Value = "0"
          },
          new Settings.Setting() { Key = "RoomsVisited", Value = "0" },
          new Settings.Setting()
          {
            Key = "TUTORIAL_COMPLETE_MASK",
            Value = "9"
          }
        });
        File.WriteAllText("global-settings-metadata.txt", JsonConvert.SerializeObject((object) Settings.AllGlobalSettings));
      }
      return Settings.AllGlobalSettings[id];
    }

    public static void SaveMultiplayerSetting(int id, string postData)
    {
      Settings.AllGlobalSettings = JsonConvert.DeserializeObject<Dictionary<int, List<Settings.Setting>>>(File.ReadAllText("global-settings-metadata.txt"));
      Settings.Setting setting1 = JsonConvert.DeserializeObject<Settings.Setting>(postData);
      foreach (Settings.Setting setting2 in Settings.AllGlobalSettings[id])
      {
        if (setting2.Key == setting1.Key)
          setting2.Value = setting1.Value;
        else
          Settings.AllGlobalSettings[id].Add(new Settings.Setting()
          {
            Key = setting1.Key,
            Value = setting1.Value
          });
      }
      File.WriteAllText("global-settings-metadata.txt", JsonConvert.SerializeObject((object) Settings.AllGlobalSettings));
      Console.WriteLine(JsonConvert.SerializeObject((object) Settings.AllGlobalSettings));
    }

    public class Setting
    {
      public string Key { get; set; }

      public string Value { get; set; }
    }
  }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RR2017Server
{
  internal class LocalSaveConfig
  {
    public static List<string> configDatas;

    public static bool ContainsSaveDataType(LocalSaveConfig.SaveDataType sdt)
    {
      if (LocalSaveConfig.configDatas == null)
        LocalSaveConfig.LoadConfigFile();
      return LocalSaveConfig.configDatas[(int) sdt] != "";
    }

    public static void LoadConfigFile()
    {
      LocalSaveConfig.configDatas = new List<string>();
      string path = Environment.CurrentDirectory + "\\Resources\\.LocalSaveData";
      if (File.Exists(path))
      {
        foreach (string readAllLine in File.ReadAllLines(path))
          LocalSaveConfig.configDatas.Add(readAllLine);
      }
      while (LocalSaveConfig.configDatas.Count<string>() != 13)
        LocalSaveConfig.configDatas.Add("");
    }

    public static void SaveConfigData(LocalSaveConfig.SaveDataType sdt, byte[] bytes)
    {
      if (LocalSaveConfig.configDatas == null)
        LocalSaveConfig.LoadConfigFile();
      string base64String = Convert.ToBase64String(bytes, 0, bytes.Length, Base64FormattingOptions.None);
      LocalSaveConfig.configDatas[(int) sdt] = base64String;
      LocalSaveConfig.SaveDataFile();
    }

    public static byte[] LoadConfigData(LocalSaveConfig.SaveDataType sdt)
    {
      if (LocalSaveConfig.configDatas == null)
        LocalSaveConfig.LoadConfigFile();
      return Convert.FromBase64String(LocalSaveConfig.configDatas[(int) sdt]);
    }

    public static void SaveDataFile()
    {
      if (LocalSaveConfig.configDatas == null)
        LocalSaveConfig.LoadConfigFile();
      if (!Directory.Exists(Environment.CurrentDirectory + "\\Resources\\.LocalSaveData"))
        Directory.CreateDirectory(Environment.CurrentDirectory + "\\Resources\\.LocalSaveData");
      File.WriteAllLines(Environment.CurrentDirectory + "\\Resources\\.LocalSaveData", (IEnumerable<string>) LocalSaveConfig.configDatas);
    }

    public enum SaveDataType
    {
      Profile,
      Avatar,
      Gifts,
      Items,
      Equipment,
      Consumables,
      Storefronts,
      Challenges,
      Leaderboard,
      PlayerSettings,
      SavedOutfits,
      DailyChallenges,
      OrientationChallenges,
    }
  }
}

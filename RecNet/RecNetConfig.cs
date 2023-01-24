// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Newtonsoft.Json;
using System.Collections.Generic;

namespace RecNet
{
  internal class RecNetConfig
  {
    public static string Current() => JsonConvert.SerializeObject((object) new RecNetConfig.RecRoomConfig()
    {
      ShareBaseUrl = "https://rec.net/{0}",
      LevelProgressionMaps = new List<RecNetConfig.LevelProgressionMap>()
      {
        new RecNetConfig.LevelProgressionMap()
        {
          Level = 99,
          RequiredXp = 0,
          GiftDropId = new int?()
        }
      },
      DailyObjectives = new List<List<RecNetConfig.DailyObjective>>()
      {
        new List<RecNetConfig.DailyObjective>()
        {
          new RecNetConfig.DailyObjective()
          {
            type = 1030,
            score = 1,
            xp = 200
          },
          new RecNetConfig.DailyObjective()
          {
            type = 1030,
            score = 1,
            xp = 200
          },
          new RecNetConfig.DailyObjective()
          {
            type = 1030,
            score = 1,
            xp = 200
          }
        },
        new List<RecNetConfig.DailyObjective>()
        {
          new RecNetConfig.DailyObjective()
          {
            type = 1030,
            score = 1,
            xp = 200
          },
          new RecNetConfig.DailyObjective()
          {
            type = 1030,
            score = 1,
            xp = 200
          },
          new RecNetConfig.DailyObjective()
          {
            type = 1030,
            score = 1,
            xp = 200
          }
        },
        new List<RecNetConfig.DailyObjective>()
        {
          new RecNetConfig.DailyObjective()
          {
            type = 1030,
            score = 1,
            xp = 200
          },
          new RecNetConfig.DailyObjective()
          {
            type = 1030,
            score = 1,
            xp = 200
          },
          new RecNetConfig.DailyObjective()
          {
            type = 1030,
            score = 1,
            xp = 200
          }
        }
      },
      ServerMaintenance = new RecNetConfig.ServerMaintenance()
      {
        StartsInMinutes = 0
      },
      AutoMicMutingConfig = new RecNetConfig.AutoMicMutingConfig()
      {
        MicSpamVolumeThreshold = 9.0,
        MicVolumeSampleInterval = 9.0,
        MicVolumeSampleRollingWindowLength = 9.0,
        MicSpamSamplePercentageForWarning = 9.0,
        MicSpamSamplePercentageForWarningToEnd = 9.0,
        MicSpamSamplePercentageForForceMute = 9.0,
        MicSpamSamplePercentageForForceMuteToEnd = 9.0,
        MicSpamWarningStateVolumeMultiplier = 9.0
      },
      RoomKeyConfig = new RecNetConfig.RoomKeyConfig()
      {
        MaxKeysPerRoom = 1000
      },
      RoomCurrencyConfig = new RecNetConfig.RoomCurrencyConfig()
      {
        AwardCurrencyCooldownSeconds = 10.0
      }
    });

    public class LevelProgressionMap
    {
      public int Level { get; set; }

      public int RequiredXp { get; set; }

      public int? GiftDropId { get; set; }
    }

    public class DailyObjective
    {
      public int type { get; set; }

      public int score { get; set; }

      public int xp { get; set; }
    }

    public class ServerMaintenance
    {
      public int StartsInMinutes { get; set; }
    }

    public class AutoMicMutingConfig
    {
      public double MicSpamVolumeThreshold { get; set; }

      public double MicVolumeSampleInterval { get; set; }

      public double MicVolumeSampleRollingWindowLength { get; set; }

      public double MicSpamSamplePercentageForWarning { get; set; }

      public double MicSpamSamplePercentageForWarningToEnd { get; set; }

      public double MicSpamSamplePercentageForForceMute { get; set; }

      public double MicSpamSamplePercentageForForceMuteToEnd { get; set; }

      public double MicSpamWarningStateVolumeMultiplier { get; set; }
    }

    public class RoomKeyConfig
    {
      public int MaxKeysPerRoom { get; set; }
    }

    public class RoomCurrencyConfig
    {
      public double AwardCurrencyCooldownSeconds { get; set; }
    }

    public class RecRoomConfig
    {
      public string ShareBaseUrl { get; set; }

      public List<RecNetConfig.LevelProgressionMap> LevelProgressionMaps { get; set; }

      public List<List<RecNetConfig.DailyObjective>> DailyObjectives { get; set; }

      public RecNetConfig.ServerMaintenance ServerMaintenance { get; set; }

      public RecNetConfig.AutoMicMutingConfig AutoMicMutingConfig { get; set; }

      public RecNetConfig.RoomKeyConfig RoomKeyConfig { get; set; }

      public RecNetConfig.RoomCurrencyConfig RoomCurrencyConfig { get; set; }
    }
  }
}

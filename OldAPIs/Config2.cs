// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Newtonsoft.Json;
using System.Collections.Generic;

namespace OldAPIs
{
  internal class Config2
  {
    public Objective[][] DailyObjectives { get; set; }

    public static string GetDebugConfig()
    {
      Config2 config2 = new Config2();
      config2.MessageOfTheDay = "Multi 2016-2018 private server";
      config2.CdnBaseUri = "https://img.rec.net{0}";
      config2.MatchmakingParams = new MatchmakingConfigParams()
      {
        PreferEmptyRoomsFrequency = 0.3f,
        PreferFullRoomsFrequency = 0.73f
      };
      config2.ServerMaintenance = new Config2.ServerM()
      {
        StartsInMinutes = 0
      };
      config2.LevelProgressionMaps = new List<LevelProgressionEntry>()
      {
        new LevelProgressionEntry() { Level = 1, RequiredXp = 10 },
        new LevelProgressionEntry() { Level = 2, RequiredXp = 20 },
        new LevelProgressionEntry() { Level = 3, RequiredXp = 30 },
        new LevelProgressionEntry() { Level = 4, RequiredXp = 40 },
        new LevelProgressionEntry() { Level = 5, RequiredXp = 50 },
        new LevelProgressionEntry() { Level = 6, RequiredXp = 60 },
        new LevelProgressionEntry() { Level = 7, RequiredXp = 70 },
        new LevelProgressionEntry() { Level = 8, RequiredXp = 80 },
        new LevelProgressionEntry() { Level = 9, RequiredXp = 90 },
        new LevelProgressionEntry() { Level = 10, RequiredXp = 100 }
      };
      config2.DailyObjectives = new Objective[6][]
      {
        new Objective[3]
        {
          new Objective() { type = 30, score = 100 },
          new Objective() { type = 6, score = 100 },
          new Objective() { type = 3, score = 100 }
        },
        new Objective[3]
        {
          new Objective() { type = 30, score = 100 },
          new Objective() { type = 6, score = 100 },
          new Objective() { type = 3, score = 100 }
        },
        new Objective[3]
        {
          new Objective() { type = 30, score = 100 },
          new Objective() { type = 6, score = 100 },
          new Objective() { type = 3, score = 100 }
        },
        new Objective[3]
        {
          new Objective() { type = 30, score = 100 },
          new Objective() { type = 6, score = 100 },
          new Objective() { type = 3, score = 100 }
        },
        new Objective[3]
        {
          new Objective() { type = 30, score = 100 },
          new Objective() { type = 6, score = 100 },
          new Objective() { type = 3, score = 100 }
        },
        new Objective[3]
        {
          new Objective() { type = 30, score = 100 },
          new Objective() { type = 6, score = 100 },
          new Objective() { type = 3, score = 100 }
        }
      };
      config2.PhotonConfig = new photonConfig()
      {
        EnableServerTracingAfterDisconnect = false,
        CloudRegion = "eu",
        CrcCheckEnabled = false
      };
      return JsonConvert.SerializeObject((object) config2);
    }

    public string MessageOfTheDay { get; set; }

    public string CdnBaseUri { get; set; }

    public List<LevelProgressionEntry> LevelProgressionMaps { get; set; }

    public MatchmakingConfigParams MatchmakingParams { get; set; }

    public Config2.ServerM ServerMaintenance { get; set; }

    public photonConfig PhotonConfig { get; set; }

    public class ServerM
    {
      public int StartsInMinutes { get; set; }
    }
  }
}

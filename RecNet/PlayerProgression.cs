// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Newtonsoft.Json;
using System.Collections.Generic;

namespace RecNet
{
  internal class PlayerProgression
  {
    public static string GetProgressionBulk() => JsonConvert.SerializeObject((object) new List<PlayerProgression.Details>()
    {
      new PlayerProgression.Details()
      {
        PlayerId = 1,
        Level = 99,
        XP = 0
      }
    });

    public class Details
    {
      public int PlayerId { get; set; }

      public int Level { get; set; }

      public int XP { get; set; }
    }
  }
}

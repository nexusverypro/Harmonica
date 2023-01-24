// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Newtonsoft.Json;
using System.Collections.Generic;

namespace RecNet
{
  internal class Room
  {
    public static string Filters() => JsonConvert.SerializeObject((object) new Room.RoomFilter()
    {
      PinnedFilters = new List<string>()
      {
        "recroomoriginal",
        "community",
        "featured",
        "carnivale",
        "quest",
        "pvp",
        "hangout",
        "game",
        "art",
        "store",
        "tutorial",
        "fandom",
        "performance",
        "action",
        "horror"
      },
      PopularFilters = new List<string>()
      {
        "pvp",
        "quest",
        "game",
        "hangout",
        "art"
      },
      TrendingFilters = new List<string>()
      {
        "carnivale",
        "horror",
        "action",
        "scary",
        "puzzle",
        "parkour",
        "fun",
        "story"
      }
    });

    public class RoomFilter
    {
      public List<string> PinnedFilters { get; set; }

      public List<string> PopularFilters { get; set; }

      public List<string> TrendingFilters { get; set; }
    }
  }
}

// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace OldAPIs
{
  public class Consumables
  {
    public static List<Consumables> consumables;

    public long Id { get; set; }

    public string ConsumableItemDesc { get; set; }

    public DateTime CreatedAt { get; set; }

    public int Count { get; set; }

    public int UnlockedLevel { get; set; }

    public bool IsActive { get; set; }

    public static string SerializeItems()
    {
      Consumables.consumables = new List<Consumables>()
      {
        new Consumables()
        {
          Id = 1L,
          ConsumableItemDesc = "7OZ5AE3uuUyqa0P",
          CreatedAt = DateTime.Now,
          Count = 99,
          UnlockedLevel = 1,
          IsActive = false
        },
        new Consumables()
        {
          Id = 2L,
          ConsumableItemDesc = "_jnjYGBcyEWY5Ub4OezXcA",
          CreatedAt = DateTime.Now,
          Count = 99,
          UnlockedLevel = 1,
          IsActive = false
        },
        new Consumables()
        {
          Id = 3L,
          ConsumableItemDesc = "5hIAZ9wg5EyG1cILf4FS2A",
          CreatedAt = DateTime.Now,
          Count = 99,
          UnlockedLevel = 1,
          IsActive = false
        },
        new Consumables()
        {
          Id = 4L,
          ConsumableItemDesc = "wUCIKdJSvEmiQHYMyx4X4w",
          CreatedAt = DateTime.Now,
          Count = 99,
          UnlockedLevel = 1,
          IsActive = false
        },
        new Consumables()
        {
          Id = 5L,
          ConsumableItemDesc = "JfnVXFmilU6ysv-VbTAe3A",
          CreatedAt = DateTime.Now,
          Count = 99,
          UnlockedLevel = 1,
          IsActive = false
        },
        new Consumables()
        {
          Id = 6L,
          ConsumableItemDesc = "InQ25wQMGkG_bvuD5rf2Ag",
          CreatedAt = DateTime.Now,
          Count = 99,
          UnlockedLevel = 1,
          IsActive = false
        },
        new Consumables()
        {
          Id = 7L,
          ConsumableItemDesc = "mMCGPgK3tki5S_15q2Z81A",
          CreatedAt = DateTime.Now,
          Count = 99,
          UnlockedLevel = 1,
          IsActive = false
        },
        new Consumables()
        {
          Id = 8L,
          ConsumableItemDesc = "ZuvkidodzkuOfGLDnTOFyg",
          CreatedAt = DateTime.Now,
          Count = 99,
          UnlockedLevel = 1,
          IsActive = false
        }
      };
      return JsonConvert.SerializeObject((object) Consumables.consumables);
    }
  }
}

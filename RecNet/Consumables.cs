// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RecNet
{
  internal class Consumables
  {
    private static List<Consumables.ConsumableData> playerConsumablesInstance;
    public static Dictionary<string, Consumables.ConsumableInfo> ConsumablesInfo = new Dictionary<string, Consumables.ConsumableInfo>()
    {
      {
        "Glazed Donuts",
        new Consumables.ConsumableInfo()
        {
          id = 7001UL,
          guid = "7OZ5AE3uuUyqa0P-2W1ptg"
        }
      },
      {
        "Hawaiian Pizza",
        new Consumables.ConsumableInfo()
        {
          id = 7002UL,
          guid = "_jnjYGBcyEWY5Ub4OezXcA"
        }
      },
      {
        "Cheese Pizza",
        new Consumables.ConsumableInfo()
        {
          id = 7003UL,
          guid = "5hIAZ9wg5EyG1cILf4FS2A"
        }
      },
      {
        "Supreme Pizza",
        new Consumables.ConsumableInfo()
        {
          id = 7004UL,
          guid = "wUCIKdJSvEmiQHYMyx4X4w"
        }
      },
      {
        "Pepperoni Pizza",
        new Consumables.ConsumableInfo()
        {
          id = 7005UL,
          guid = "mq23W-RSP0G8iGNLdrcpUw"
        }
      },
      {
        "Assorted Donuts",
        new Consumables.ConsumableInfo()
        {
          id = 7006UL,
          guid = "ZuvkidodzkuOfGLDnTOFyg"
        }
      },
      {
        "Chocolate Frosted Donuts",
        new Consumables.ConsumableInfo()
        {
          id = 7007UL,
          guid = "mMCGPgK3tki5S_15q2Z81A"
        }
      },
      {
        "Salted Pretzels",
        new Consumables.ConsumableInfo()
        {
          id = 7008UL,
          guid = "InQ25wQMGkG_bvuD5rf2Ag"
        }
      },
      {
        "Root Beer",
        new Consumables.ConsumableInfo()
        {
          id = 7009UL,
          guid = "JfnVXFmilU6ysv-VbTAe3A"
        }
      }
    };

    public static List<Consumables.ConsumableData> PlayerConsumablesInstance
    {
      get
      {
        if (Consumables.playerConsumablesInstance == null)
          Consumables.LoadConsumableData();
        return Consumables.playerConsumablesInstance;
      }
    }

    public static Consumables.ActivateConsumableItemRequest ActivateConsumableItem(int id) => new Consumables.ActivateConsumableItemRequest()
    {
      Id = (long) id,
      IsActive = true
    };

    public static void AddConsumable(string GUID, int count)
    {
      long consumableId = Consumables.GetConsumableID(GUID);
      bool flag = false;
      for (int index = 0; index < Consumables.playerConsumablesInstance.Count<Consumables.ConsumableData>(); ++index)
      {
        if (Consumables.playerConsumablesInstance[index].ConsumableItemDesc == GUID)
        {
          flag = true;
          Consumables.playerConsumablesInstance[index].Count += count;
        }
      }
      if (!flag)
      {
        Consumables.ConsumableData consumableData = new Consumables.ConsumableData()
        {
          Id = consumableId,
          ConsumableItemDesc = GUID,
          CreatedAt = DateTime.Now,
          Count = count,
          InitialCount = 1,
          UnlockedLevel = 1,
          IsActive = false,
          ActiveDurationMinutes = new int?()
        };
        Consumables.playerConsumablesInstance.Add(consumableData);
      }
      Consumables.SaveConsumableData();
    }

    public static void LoadConsumableData()
    {
      Consumables.playerConsumablesInstance = new List<Consumables.ConsumableData>();
      string str = Environment.CurrentDirectory + "\\Resources\\LocalConsumables";
      Consumables.AddConsumable("_jnjYGBcyEWY5Ub4OezXcA", 99);
    }

    public static void SaveConsumableData()
    {
      string path = Environment.CurrentDirectory + "\\Resources\\LocalConsumables";
      List<Consumables.ConsumableData> consumableDataList = new List<Consumables.ConsumableData>();
      string contents = JsonConvert.SerializeObject((object) Consumables.playerConsumablesInstance);
      File.WriteAllText(path, contents);
    }

    public static long GetConsumableID(string guid)
    {
      foreach (KeyValuePair<string, Consumables.ConsumableInfo> keyValuePair in Consumables.ConsumablesInfo)
      {
        if (keyValuePair.Value.guid == guid)
          return (long) keyValuePair.Value.id;
      }
      return 0;
    }

    public class ConsumableData
    {
      public long Id { get; set; }

      public string ConsumableItemDesc { get; set; }

      public DateTime CreatedAt { get; set; }

      public int Count { get; set; }

      public int InitialCount { get; set; }

      public int UnlockedLevel { get; set; }

      public bool IsActive { get; set; }

      public int? ActiveDurationMinutes { get; set; }
    }

    public class ConsumableInfo
    {
      public ulong id { get; set; }

      public string guid { get; set; }
    }

    public class ActivateConsumableItemRequest
    {
      public long Id;
      public bool IsActive;
    }
  }
}

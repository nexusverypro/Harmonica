// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using System.Collections.Generic;

namespace RecNet
{
  internal class GiftDrops
  {
    public static Dictionary<string, GiftDrops.ConsumableData> BuyableConsumables = new Dictionary<string, GiftDrops.ConsumableData>()
    {
      {
        "Glazed Donuts",
        new GiftDrops.ConsumableData()
        {
          id = 9001L,
          guid = "7OZ5AE3uuUyqa0P-2W1ptg"
        }
      },
      {
        "Hawaiian Pizza",
        new GiftDrops.ConsumableData()
        {
          id = 9002L,
          guid = "_jnjYGBcyEWY5Ub4OezXcA"
        }
      },
      {
        "Cheese Pizza",
        new GiftDrops.ConsumableData()
        {
          id = 9003L,
          guid = "5hIAZ9wg5EyG1cILf4FS2A"
        }
      },
      {
        "Supreme Pizza",
        new GiftDrops.ConsumableData()
        {
          id = 9004L,
          guid = "wUCIKdJSvEmiQHYMyx4X4w"
        }
      },
      {
        "Pepperoni Pizza",
        new GiftDrops.ConsumableData()
        {
          id = 9005L,
          guid = "mq23W-RSP0G8iGNLdrcpUw"
        }
      },
      {
        "Assorted Donuts",
        new GiftDrops.ConsumableData()
        {
          id = 9006L,
          guid = "ZuvkidodzkuOfGLDnTOFyg"
        }
      },
      {
        "Chocolate Frosted Donuts",
        new GiftDrops.ConsumableData()
        {
          id = 9007L,
          guid = "mMCGPgK3tki5S_15q2Z81A"
        }
      },
      {
        "Salted Pretzels",
        new GiftDrops.ConsumableData()
        {
          id = 9008L,
          guid = "InQ25wQMGkG_bvuD5rf2Ag"
        }
      },
      {
        "Root Beer",
        new GiftDrops.ConsumableData()
        {
          id = 9009L,
          guid = "JfnVXFmilU6ysv-VbTAe3A"
        }
      }
    };

    public static Storefront.GiftDrop GetGiftDropByName(
      string giftdropname,
      GiftDrops.GiftDropType giftDropType = GiftDrops.GiftDropType.Clothing)
    {
      Storefront.GiftDrop giftDrop = new Storefront.GiftDrop()
      {
        GiftDropId = new int?(0),
        AvatarItemDesc = "",
        AvatarItemType = new int?(0),
        ConsumableItemDesc = "",
        IsQuery = false,
        SubscribersOnly = false,
        ItemSetId = new int?(0),
        ItemSetFriendlyName = "",
        Context = new int?(100010),
        Rarity = new int?(50),
        Currency = new int?(0),
        CurrencyType = new int?(0),
        FriendlyName = "",
        EquipmentModificationGuid = "",
        EquipmentPrefabName = "",
        Tooltip = "",
        Unique = true,
        QueryRedirectContext = new int?(0),
        QueryRedirectRarity = new int?(0)
      };
      if (giftDropType > GiftDrops.GiftDropType.Clothing)
      {
        OutfitItems.OutfitData itemByName = OutfitItems.GetItemByName(giftdropname);
        giftDrop.AvatarItemDesc = itemByName.AvatarItemDesc;
        giftDrop.GiftDropId = itemByName.GiftDropId;
      }
      else
      {
        OutfitItems.OutfitData itemByName = OutfitItems.GetItemByName(giftdropname);
        giftDrop.AvatarItemDesc = itemByName.AvatarItemDesc;
        giftDrop.GiftDropId = itemByName.GiftDropId;
      }
      return giftDrop;
    }

    public static int? GetOutfitItemIdByName(string friendlyName)
    {
      using (Dictionary<string, OutfitItems.OutfitData>.ValueCollection.Enumerator enumerator = OutfitItems.outfitDatas.Values.GetEnumerator())
      {
        if (enumerator.MoveNext())
        {
          OutfitItems.OutfitData current = enumerator.Current;
          return current.FriendlyName == friendlyName ? current.GiftDropId : new int?(0);
        }
      }
      return new int?(0);
    }

    public static OutfitItems.OutfitData GetOutfitItemByName(string friendlyName)
    {
      using (Dictionary<string, OutfitItems.OutfitData>.ValueCollection.Enumerator enumerator = OutfitItems.outfitDatas.Values.GetEnumerator())
      {
        if (enumerator.MoveNext())
        {
          OutfitItems.OutfitData current = enumerator.Current;
          return current.FriendlyName == friendlyName ? current : (OutfitItems.OutfitData) null;
        }
      }
      return (OutfitItems.OutfitData) null;
    }

    public static GiftDrops.GiftDrop GetGiftDropByNId(
      long id,
      GiftDrops.GiftDropType giftDropType = GiftDrops.GiftDropType.Clothing)
    {
      GiftDrops.GiftDrop giftDrop = new GiftDrops.GiftDrop()
      {
        GiftDropId = new int?(0),
        FriendlyName = "",
        Tooltip = "",
        AvatarItemDesc = "",
        ConsumableItemDesc = "",
        EquipmentPrefabName = "",
        EquipmentModificationGuid = "",
        Rarity = Gifts.GiftRarity.Legendary,
        IsQuery = false,
        Unique = false,
        Level = 1,
        Context = Gifts.GiftContext.Store_RecCenter
      };
      foreach (OutfitItems.OutfitData outfitData in OutfitItems.outfitDatas.Values)
      {
        if ((long) outfitData.ItemSetId.Value == id)
        {
          giftDrop.FriendlyName = outfitData.FriendlyName;
          giftDrop.AvatarItemDesc = outfitData.AvatarItemDesc;
          giftDrop.GiftDropId = outfitData.GiftDropId;
        }
      }
      if ((long) giftDrop.GiftDropId.Value != id)
      {
        foreach (KeyValuePair<string, GiftDrops.ConsumableData> buyableConsumable in GiftDrops.BuyableConsumables)
        {
          if (buyableConsumable.Value.id == id)
          {
            giftDrop.FriendlyName = buyableConsumable.Key;
            giftDrop.ConsumableItemDesc = buyableConsumable.Value.guid ?? "";
            giftDrop.GiftDropId = new int?((int) buyableConsumable.Value.id);
          }
        }
      }
      return giftDrop;
    }

    public class PlayerGift
    {
      public long Id { get; set; }

      public string AvatarItemDesc { get; set; }

      public string ConsumableItemDesc { get; set; }

      public string EquipmentPrefabName { get; set; }

      public string EquipmentModificationGuid { get; set; }

      public GiftDrops.CurrencyTypes CurrencyType { get; set; }

      public int Currency { get; set; }

      public int Xp { get; set; }

      public int Level { get; set; }

      public Gifts.GiftRarity GiftRarity { get; set; }

      public string Message { get; set; }

      public Gifts.GiftContext Context { get; set; }
    }

    public enum GiftDropType
    {
      Clothing,
      Consumable,
      Equipment,
    }

    public enum CurrencyTypes
    {
      Invalid = 0,
      LaserTagTickets = 1,
      RecCenterTokens = 2,
      LostSkullsGold = 100, // 0x00000064
      DraculaSilver = 101, // 0x00000065
      RecRoyale_Season1 = 200, // 0x000000C8
    }

    public class GiftDrop
    {
      public int? GiftDropId { get; set; }

      public string FriendlyName { get; set; }

      public string Tooltip { get; set; }

      public string AvatarItemDesc { get; set; }

      public string ConsumableItemDesc { get; set; }

      public string EquipmentPrefabName { get; set; }

      public string EquipmentModificationGuid { get; set; }

      public Gifts.GiftRarity Rarity { get; set; }

      public bool IsQuery { get; set; }

      public bool Unique { get; set; }

      public int Level { get; set; }

      public Gifts.GiftContext Context { get; set; }
    }

    public class ConsumableData
    {
      public long id { get; set; }

      public string guid { get; set; }
    }
  }
}

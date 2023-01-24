// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using System;
using System.Collections.Generic;

namespace OldAPIs
{
  internal class StoreFronts
  {
    public static DateTime GetNextWeekday(DateTime start, DayOfWeek day)
    {
      int num = (day - start.DayOfWeek + 7) % 7;
      return start.AddDays((double) num);
    }

    public enum GiftContext
    {
      None = -1, // 0xFFFFFFFF
      Default = 0,
      First_Activity = 1,
      Game_Drop = 2,
      All_Daily_Challenges_Complete = 3,
      All_Weekly_Challenge_Complete = 4,
      Daily_Challenge_Complete = 5,
      Weekly_Challenge_Complete = 6,
      Unassigned_Equipment = 10, // 0x0000000A
      Unassigned_Avatar = 11, // 0x0000000B
      Unassigned_Consumable = 12, // 0x0000000C
      Reacquisition = 20, // 0x00000014
      Membership = 21, // 0x00000015
      NUX_TokensAndDressUp = 30, // 0x0000001E
      NUX_Experiment1 = 31, // 0x0000001F
      NUX_Experiment2 = 32, // 0x00000020
      NUX_Experiment3 = 33, // 0x00000021
      NUX_Experiment4 = 34, // 0x00000022
      NUX_Experiment5 = 35, // 0x00000023
      LevelUp = 100, // 0x00000064
      LevelUp_2 = 102, // 0x00000066
      LevelUp_3 = 103, // 0x00000067
      LevelUp_4 = 104, // 0x00000068
      LevelUp_5 = 105, // 0x00000069
      LevelUp_6 = 106, // 0x0000006A
      LevelUp_7 = 107, // 0x0000006B
      LevelUp_8 = 108, // 0x0000006C
      LevelUp_9 = 109, // 0x0000006D
      LevelUp_10 = 110, // 0x0000006E
      LevelUp_11 = 111, // 0x0000006F
      LevelUp_12 = 112, // 0x00000070
      LevelUp_13 = 113, // 0x00000071
      LevelUp_14 = 114, // 0x00000072
      LevelUp_15 = 115, // 0x00000073
      LevelUp_16 = 116, // 0x00000074
      LevelUp_17 = 117, // 0x00000075
      LevelUp_18 = 118, // 0x00000076
      LevelUp_19 = 119, // 0x00000077
      LevelUp_20 = 120, // 0x00000078
      LevelUp_21 = 121, // 0x00000079
      LevelUp_22 = 122, // 0x0000007A
      LevelUp_23 = 123, // 0x0000007B
      LevelUp_24 = 124, // 0x0000007C
      LevelUp_25 = 125, // 0x0000007D
      LevelUp_26 = 126, // 0x0000007E
      LevelUp_27 = 127, // 0x0000007F
      LevelUp_28 = 128, // 0x00000080
      LevelUp_29 = 129, // 0x00000081
      LevelUp_30 = 130, // 0x00000082
      Event_RawData = 1000, // 0x000003E8
      SFVRCC_Promo = 1001, // 0x000003E9
      HelixxVR_Promo = 1002, // 0x000003EA
      Paintball_ClearCut = 2000, // 0x000007D0
      Paintball_Homestead = 2001, // 0x000007D1
      Paintball_Quarry = 2002, // 0x000007D2
      Paintball_River = 2003, // 0x000007D3
      Paintball_Dam = 2004, // 0x000007D4
      Discgolf_Propulsion = 3000, // 0x00000BB8
      Discgolf_Lake = 3001, // 0x00000BB9
      Discgolf_Mode_CoopCatch = 3500, // 0x00000DAC
      Quest_Goblin_A = 4000, // 0x00000FA0
      Quest_Goblin_B = 4001, // 0x00000FA1
      Quest_Goblin_C = 4002, // 0x00000FA2
      Quest_Goblin_S = 4003, // 0x00000FA3
      Quest_Goblin_Consumable = 4004, // 0x00000FA4
      Quest_Cauldron_A = 4010, // 0x00000FAA
      Quest_Cauldron_B = 4011, // 0x00000FAB
      Quest_Cauldron_C = 4012, // 0x00000FAC
      Quest_Cauldron_S = 4013, // 0x00000FAD
      Quest_Cauldron_Consumable = 4014, // 0x00000FAE
      Quest_Pirate1_A = 4100, // 0x00001004
      Quest_Pirate1_B = 4101, // 0x00001005
      Quest_Pirate1_C = 4102, // 0x00001006
      Quest_Pirate1_S = 4103, // 0x00001007
      Quest_Pirate1_X = 4104, // 0x00001008
      Quest_Pirate1_Consumable = 4105, // 0x00001009
      Quest_SciFi_A = 4500, // 0x00001194
      Quest_SciFi_B = 4501, // 0x00001195
      Quest_SciFi_C = 4502, // 0x00001196
      Quest_SciFi_S = 4503, // 0x00001197
      Quest_scifi_Consumable = 4504, // 0x00001198
      Charades = 5000, // 0x00001388
      Soccer = 6000, // 0x00001770
      Paddleball = 7000, // 0x00001B58
      Dodgeball = 8000, // 0x00001F40
      Lasertag = 9000, // 0x00002328
      Store_LaserTag = 100000, // 0x000186A0
      Store_RecCenter = 100010, // 0x000186AA
      Consumable = 110000, // 0x0001ADB0
      Token = 110100, // 0x0001AE14
      Punchcard_Challenge_Complete = 110200, // 0x0001AE78
      All_Punchcard_Challenges_Complete = 110201, // 0x0001AE79
    }

    public enum GiftTypes
    {
      GiftDrop,
      SeasonTier,
      SeasonEliteUpgrade,
    }

    public enum CurrencyTypes
    {
      Invalid = 0,
      LaserTagTickets = 1,
      RecCenterTokens = 2,
      LostSkullsGold = 100, // 0x00000064
      RecRoyale_Season1 = 200, // 0x000000C8
    }

    public enum StoreFrontTypes
    {
      None = 0,
      LaserTag = 1,
      RecCenter = 2,
      Watch = 3,
      Quest_LostSkulls = 100, // 0x00000064
      RecRoyale = 200, // 0x000000C8
    }

    public enum ItemRarity
    {
      None = -1, // 0xFFFFFFFF
      Common = 0,
      Uncommon = 10, // 0x0000000A
      Rare = 20, // 0x00000014
      Epic = 30, // 0x0000001E
      Legendary = 50, // 0x00000032
    }

    public class AllGiftDrop
    {
    }

    public class GiftDropStore
    {
      public int StorefrontType { get; set; }

      public DateTime NextUpdate { get; set; }

      public List<StoreFronts.StoreItem> StoreItems { get; set; }

      public GiftDropStore()
      {
        this.StorefrontType = 2;
        this.NextUpdate = StoreFronts.GetNextWeekday(DateTime.Now, DayOfWeek.Wednesday);
        this.StoreItems = new List<StoreFronts.StoreItem>()
        {
          new StoreFronts.StoreItem()
          {
            PurchasableItemId = 0,
            Type = 0,
            IsFeatured = false,
            Prices = new List<StoreFronts.ItemPrice>()
            {
              new StoreFronts.ItemPrice()
              {
                CurrencyType = 2,
                Price = 30000
              }
            },
            GiftDrops = new List<StoreFronts.GiftDrop>()
            {
              new StoreFronts.GiftDrop()
              {
                GiftDropId = 0,
                FriendlyName = "Saija Helmet",
                Tooltip = "",
                AvatarItemDesc = "274cb9b2-2f59-47ea-9a8d-a5b656d148c6,,,",
                ConsumableItemDesc = "",
                EquipmentPrefabName = "",
                EquipmentModificationGuid = "",
                Rarity = 50,
                IsQuery = false,
                Unique = false,
                Level = 50,
                Context = 100010
              }
            }
          },
          new StoreFronts.StoreItem()
          {
            PurchasableItemId = 1,
            Type = 0,
            IsFeatured = false,
            Prices = new List<StoreFronts.ItemPrice>()
            {
              new StoreFronts.ItemPrice()
              {
                CurrencyType = 2,
                Price = 35000
              }
            },
            GiftDrops = new List<StoreFronts.GiftDrop>()
            {
              new StoreFronts.GiftDrop()
              {
                GiftDropId = 1,
                FriendlyName = "Saija Shirt",
                Tooltip = "",
                AvatarItemDesc = "2c679f89-c76e-4cfb-94e9-448c8fd44d55,,,",
                ConsumableItemDesc = "",
                EquipmentPrefabName = "",
                EquipmentModificationGuid = "",
                Rarity = 50,
                IsQuery = false,
                Unique = false,
                Level = 50,
                Context = 100010
              }
            }
          },
          new StoreFronts.StoreItem()
          {
            PurchasableItemId = 2,
            Type = 0,
            IsFeatured = false,
            Prices = new List<StoreFronts.ItemPrice>()
            {
              new StoreFronts.ItemPrice()
              {
                CurrencyType = 2,
                Price = 10000
              }
            },
            GiftDrops = new List<StoreFronts.GiftDrop>()
            {
              new StoreFronts.GiftDrop()
              {
                GiftDropId = 2,
                FriendlyName = "Saija Gloves",
                Tooltip = "",
                AvatarItemDesc = "50c9c6f8-2963-4ef3-95d5-e999a898269f,,,",
                ConsumableItemDesc = "",
                EquipmentPrefabName = "",
                EquipmentModificationGuid = "",
                Rarity = 50,
                IsQuery = false,
                Unique = false,
                Level = 50,
                Context = 100010
              }
            }
          },
          new StoreFronts.StoreItem()
          {
            PurchasableItemId = 0,
            Type = 0,
            IsFeatured = false,
            Prices = new List<StoreFronts.ItemPrice>()
            {
              new StoreFronts.ItemPrice()
              {
                CurrencyType = 2,
                Price = 15000
              }
            },
            GiftDrops = new List<StoreFronts.GiftDrop>()
            {
              new StoreFronts.GiftDrop()
              {
                GiftDropId = 0,
                FriendlyName = "Bishop Hair",
                Tooltip = "",
                AvatarItemDesc = "b861e5f3-fc6d-43b3-9861-c1b45cb493a8,,,",
                ConsumableItemDesc = "",
                EquipmentPrefabName = "",
                EquipmentModificationGuid = "",
                Rarity = 50,
                IsQuery = false,
                Unique = false,
                Level = 50,
                Context = 100010
              }
            }
          },
          new StoreFronts.StoreItem()
          {
            PurchasableItemId = 4,
            Type = 0,
            IsFeatured = false,
            Prices = new List<StoreFronts.ItemPrice>()
            {
              new StoreFronts.ItemPrice()
              {
                CurrencyType = 2,
                Price = 20000
              }
            },
            GiftDrops = new List<StoreFronts.GiftDrop>()
            {
              new StoreFronts.GiftDrop()
              {
                GiftDropId = 4,
                FriendlyName = "Bishop Shirt",
                Tooltip = "",
                AvatarItemDesc = "6930ce13-4be4-4ab9-9817-667bd261ffc3,,,",
                ConsumableItemDesc = "",
                EquipmentPrefabName = "",
                EquipmentModificationGuid = "",
                Rarity = 50,
                IsQuery = false,
                Unique = false,
                Level = 50,
                Context = 100010
              }
            }
          },
          new StoreFronts.StoreItem()
          {
            PurchasableItemId = 5,
            Type = 0,
            IsFeatured = false,
            Prices = new List<StoreFronts.ItemPrice>()
            {
              new StoreFronts.ItemPrice()
              {
                CurrencyType = 2,
                Price = 20000
              }
            },
            GiftDrops = new List<StoreFronts.GiftDrop>()
            {
              new StoreFronts.GiftDrop()
              {
                GiftDropId = 5,
                FriendlyName = "Bishop Gloves",
                Tooltip = "",
                AvatarItemDesc = "abc25091-ed5f-4c72-9364-fffeef1bc239,,,",
                ConsumableItemDesc = "",
                EquipmentPrefabName = "",
                EquipmentModificationGuid = "",
                Rarity = 50,
                IsQuery = false,
                Unique = false,
                Level = 50,
                Context = 100010
              }
            }
          },
          new StoreFronts.StoreItem()
          {
            PurchasableItemId = 0,
            Type = 0,
            IsFeatured = false,
            Prices = new List<StoreFronts.ItemPrice>()
            {
              new StoreFronts.ItemPrice()
              {
                CurrencyType = 2,
                Price = 30000
              }
            },
            GiftDrops = new List<StoreFronts.GiftDrop>()
            {
              new StoreFronts.GiftDrop()
              {
                GiftDropId = 0,
                FriendlyName = "Saija Helmet",
                Tooltip = "",
                AvatarItemDesc = "274cb9b2-2f59-47ea-9a8d-a5b656d148c6,,,",
                ConsumableItemDesc = "",
                EquipmentPrefabName = "",
                EquipmentModificationGuid = "",
                Rarity = 50,
                IsQuery = false,
                Unique = false,
                Level = 50,
                Context = 100010
              }
            }
          },
          new StoreFronts.StoreItem()
          {
            PurchasableItemId = 1,
            Type = 0,
            IsFeatured = false,
            Prices = new List<StoreFronts.ItemPrice>()
            {
              new StoreFronts.ItemPrice()
              {
                CurrencyType = 2,
                Price = 35000
              }
            },
            GiftDrops = new List<StoreFronts.GiftDrop>()
            {
              new StoreFronts.GiftDrop()
              {
                GiftDropId = 1,
                FriendlyName = "Saija Shirt",
                Tooltip = "",
                AvatarItemDesc = "2c679f89-c76e-4cfb-94e9-448c8fd44d55,,,",
                ConsumableItemDesc = "",
                EquipmentPrefabName = "",
                EquipmentModificationGuid = "",
                Rarity = 50,
                IsQuery = false,
                Unique = false,
                Level = 50,
                Context = 100010
              }
            }
          },
          new StoreFronts.StoreItem()
          {
            PurchasableItemId = 2,
            Type = 0,
            IsFeatured = false,
            Prices = new List<StoreFronts.ItemPrice>()
            {
              new StoreFronts.ItemPrice()
              {
                CurrencyType = 2,
                Price = 10000
              }
            },
            GiftDrops = new List<StoreFronts.GiftDrop>()
            {
              new StoreFronts.GiftDrop()
              {
                GiftDropId = 2,
                FriendlyName = "Saija Gloves",
                Tooltip = "",
                AvatarItemDesc = "50c9c6f8-2963-4ef3-95d5-e999a898269f,,,",
                ConsumableItemDesc = "",
                EquipmentPrefabName = "",
                EquipmentModificationGuid = "",
                Rarity = 50,
                IsQuery = false,
                Unique = false,
                Level = 50,
                Context = 100010
              }
            }
          },
          new StoreFronts.StoreItem()
          {
            PurchasableItemId = 0,
            Type = 0,
            IsFeatured = false,
            Prices = new List<StoreFronts.ItemPrice>()
            {
              new StoreFronts.ItemPrice()
              {
                CurrencyType = 2,
                Price = 15000
              }
            },
            GiftDrops = new List<StoreFronts.GiftDrop>()
            {
              new StoreFronts.GiftDrop()
              {
                GiftDropId = 0,
                FriendlyName = "Bishop Hair",
                Tooltip = "",
                AvatarItemDesc = "b861e5f3-fc6d-43b3-9861-c1b45cb493a8,,,",
                ConsumableItemDesc = "",
                EquipmentPrefabName = "",
                EquipmentModificationGuid = "",
                Rarity = 50,
                IsQuery = false,
                Unique = false,
                Level = 50,
                Context = 100010
              }
            }
          },
          new StoreFronts.StoreItem()
          {
            PurchasableItemId = 4,
            Type = 0,
            IsFeatured = false,
            Prices = new List<StoreFronts.ItemPrice>()
            {
              new StoreFronts.ItemPrice()
              {
                CurrencyType = 2,
                Price = 20000
              }
            },
            GiftDrops = new List<StoreFronts.GiftDrop>()
            {
              new StoreFronts.GiftDrop()
              {
                GiftDropId = 4,
                FriendlyName = "Bishop Shirt",
                Tooltip = "",
                AvatarItemDesc = "6930ce13-4be4-4ab9-9817-667bd261ffc3,,,",
                ConsumableItemDesc = "",
                EquipmentPrefabName = "",
                EquipmentModificationGuid = "",
                Rarity = 50,
                IsQuery = false,
                Unique = false,
                Level = 50,
                Context = 100010
              }
            }
          },
          new StoreFronts.StoreItem()
          {
            PurchasableItemId = 5,
            Type = 0,
            IsFeatured = false,
            Prices = new List<StoreFronts.ItemPrice>()
            {
              new StoreFronts.ItemPrice()
              {
                CurrencyType = 2,
                Price = 20000
              }
            },
            GiftDrops = new List<StoreFronts.GiftDrop>()
            {
              new StoreFronts.GiftDrop()
              {
                GiftDropId = 5,
                FriendlyName = "Bishop Gloves",
                Tooltip = "",
                AvatarItemDesc = "abc25091-ed5f-4c72-9364-fffeef1bc239,,,",
                ConsumableItemDesc = "",
                EquipmentPrefabName = "",
                EquipmentModificationGuid = "",
                Rarity = 50,
                IsQuery = false,
                Unique = false,
                Level = 50,
                Context = 100010
              }
            }
          }
        };
      }
    }

    public class StoreItem
    {
      public int PurchasableItemId { get; set; }

      public int Type { get; set; }

      public bool IsFeatured { get; set; }

      public List<StoreFronts.ItemPrice> Prices { get; set; }

      public List<StoreFronts.GiftDrop> GiftDrops { get; set; }
    }

    public class GiftDrop
    {
      public int GiftDropId { get; set; }

      public string FriendlyName { get; set; }

      public string Tooltip { get; set; }

      public string AvatarItemDesc { get; set; }

      public string ConsumableItemDesc { get; set; }

      public string EquipmentPrefabName { get; set; }

      public string EquipmentModificationGuid { get; set; }

      public int Rarity { get; set; }

      public bool IsQuery { get; set; }

      public bool Unique { get; set; }

      public int Level { get; set; }

      public int Context { get; set; }
    }

    public class ItemPrice
    {
      public int CurrencyType { get; set; }

      public int Price { get; set; }
    }
  }
}

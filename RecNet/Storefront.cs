// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;

namespace RecNet
{
  internal class Storefront
  {
    public static Dictionary<Storefront.StoreFrontTypes, Storefront.GiftDropStoreResponse> StorefrontRotation = new Dictionary<Storefront.StoreFrontTypes, Storefront.GiftDropStoreResponse>();

    public static DateTime GetNextWeekday(DateTime start, DayOfWeek day)
    {
      int num = (day - start.DayOfWeek + 7) % 7;
      return start.AddDays((double) num);
    }

    public static Storefront.GiftDropStoreResponse GetGiftDropStoreResponse(
      Storefront.StoreFrontTypes sft)
    {
      Storefront.GiftDropStoreResponse dropStoreResponse = new Storefront.GiftDropStoreResponse();
      using (WebClient webClient = new WebClient())
        return JsonConvert.DeserializeObject<Storefront.GiftDropStoreResponse>(webClient.DownloadString(string.Format("https://raw.githubusercontent.com/MinorCrimes/Harmonica/Core/sf{0}.json", (object) (int) sft)));
    }

    public static Storefront.BalanceUpdateData BuyItem(string postData)
    {
      Storefront.BuyItemPostData buyItemPostData = JsonConvert.DeserializeObject<Storefront.BuyItemPostData>(postData);
      Storefront.GiftDropStoreResponse dropStoreResponse = Storefront.GetGiftDropStoreResponse((Storefront.StoreFrontTypes) buyItemPostData.StorefrontType);
      Storefront.UpdateGiftData updateGiftData1 = new Storefront.UpdateGiftData();
      foreach (Storefront.StoreItem storeItem in dropStoreResponse.StoreItems)
      {
        if (storeItem.PurchasableItemId == buyItemPostData.PurchasableItemId)
        {
          Storefront.UpdateGiftData updateGiftData2 = new Storefront.UpdateGiftData();
          updateGiftData2.Id = storeItem.PurchasableItemId;
          updateGiftData2.FromPlayerId = (object) null;
          updateGiftData2.ConsumableItemDesc = storeItem.GiftDrop.ConsumableItemDesc;
          updateGiftData2.ConsumableCount = 1;
          updateGiftData2.AvatarItemDesc = storeItem.GiftDrop.AvatarItemDesc;
          updateGiftData2.AvatarItemType = (object) storeItem.GiftDrop.AvatarItemType;
          int? nullable = storeItem.GiftDrop.CurrencyType;
          updateGiftData2.CurrencyType = nullable.Value;
          nullable = storeItem.GiftDrop.Currency;
          updateGiftData2.Currency = nullable.Value;
          updateGiftData2.Xp = 0;
          updateGiftData2.PackageType = 0;
          updateGiftData2.Message = "Thanks for your purchase!";
          updateGiftData2.EquipmentPrefabName = storeItem.GiftDrop.EquipmentPrefabName;
          updateGiftData2.EquipmentModificationGuid = storeItem.GiftDrop.EquipmentModificationGuid;
          updateGiftData2.GiftContext = 100;
          updateGiftData2.GiftRarity = 50;
          updateGiftData2.Platform = -1;
          updateGiftData2.PlatformsToSpawnOn = -1;
          updateGiftData2.BalanceType = (object) null;
          updateGiftData1 = updateGiftData2;
        }
      }
      return new Storefront.BalanceUpdateData((object) updateGiftData1, (long) buyItemPostData.RequestedPrice, (Storefront.CurrencyTypes) buyItemPostData.StorefrontType);
    }

    public static string GetBalance(int ct) => JsonConvert.SerializeObject((object) new List<Storefront.GetBalanceDTO>()
    {
      new Storefront.GetBalanceDTO()
      {
        CurrencyType = ct,
        Platform = -2,
        Balance = 999999999
      }
    });

    public static string AddBalanceType(int ct, int store) => JsonConvert.SerializeObject((object) new Storefront.AddBalanceTypeDTO()
    {
      CurrencyType = ct,
      BalanceAddType = store,
      BaseAward = 2,
      BonusAwardMin = 900,
      BonusAwardMax = 9000,
      RateLimitType = 1,
      IgnorePartialMultiplier = true,
      MaxPartialMultiplier = 1.0,
      RateLimit = 3,
      BalanceInGiftBox = true
    });

    public enum CurrencyTypes
    {
      Invalid = 0,
      LaserTagTickets = 1,
      RecCenterTokens = 2,
      LostSkullsGold = 100, // 0x00000064
      DraculaSilver = 101, // 0x00000065
      RecRoyale_Season1 = 200, // 0x000000C8
    }

    public enum StoreFrontTypes
    {
      None = 0,
      LaserTag = 1,
      RecCenter = 2,
      Watch = 3,
      Quest_LostSkulls = 100, // 0x00000064
      Quest_Dracula = 101, // 0x00000065
      Quest_GoldenTrophy = 102, // 0x00000066
      Quest_CrimsonCauldron = 103, // 0x00000067
      RecRoyale = 200, // 0x000000C8
      Cafe = 300, // 0x0000012C
      Paintball = 400, // 0x00000190
      Paintball_River = 401, // 0x00000191
      Paintball_Homestead = 402, // 0x00000192
      Paintball_Quarry = 403, // 0x00000193
      Paintball_ClearCut = 404, // 0x00000194
      Paintball_Spillway = 405, // 0x00000195
      Paintball_SunsetDriveIn = 406, // 0x00000196
      Bowling = 500, // 0x000001F4
      StuntRunner = 600, // 0x00000258
      DormMirror = 700, // 0x000002BC
      InventionStore = 800, // 0x00000320
    }

    public class buyItemRequest
    {
      public Storefront.StoreFrontTypes StorefrontType { get; set; }

      public long PurchasableItemId { get; set; }

      public Storefront.CurrencyTypes CurrencyType { get; set; }
    }

    public enum BalanceUpdateResults
    {
      OK,
      TooManyRequests,
      NotEnoughCredit,
      AlreadyOwned,
      NoItemAvailable,
    }

    public class GetBalanceDTO
    {
      public int CurrencyType { get; set; }

      public int Platform { get; set; }

      public int Balance { get; set; }
    }

    public class AddBalanceTypeDTO
    {
      public int CurrencyType { get; set; }

      public int BalanceAddType { get; set; }

      public int BaseAward { get; set; }

      public int BonusAwardMin { get; set; }

      public int BonusAwardMax { get; set; }

      public int RateLimitType { get; set; }

      public bool IgnorePartialMultiplier { get; set; }

      public double MaxPartialMultiplier { get; set; }

      public int RateLimit { get; set; }

      public bool BalanceInGiftBox { get; set; }
    }

    public class BalanceUpdateData
    {
      public List<Storefront.BalanceUpdatesData> BalanceUpdates { get; set; }

      public Storefront.CurrencyTypes CurrencyType { get; set; }

      public long Balance { get; set; }

      public BalanceUpdateData(object updatedata, long balance, Storefront.CurrencyTypes ct)
      {
        this.BalanceUpdates = new List<Storefront.BalanceUpdatesData>()
        {
          new Storefront.BalanceUpdatesData()
          {
            UpdateResponse = Storefront.BalanceUpdateResults.OK,
            Data = new List<object>() { updatedata }
          }
        };
        this.CurrencyType = ct;
        this.Balance = balance;
      }
    }

    public class BalanceUpdatesData
    {
      public Storefront.BalanceUpdateResults UpdateResponse { get; set; }

      public List<object> Data { get; set; }
    }

    public class GiftDrop
    {
      public GiftDrop(GiftDrops.GiftDrop gd, out Storefront.GiftDrop drop)
      {
        Storefront.GiftDrop giftDrop = new Storefront.GiftDrop()
        {
          GiftDropId = gd.GiftDropId,
          FriendlyName = gd.FriendlyName,
          Tooltip = gd.Tooltip,
          ConsumableItemDesc = gd.ConsumableItemDesc,
          AvatarItemDesc = gd.AvatarItemDesc,
          AvatarItemType = new int?(0),
          EquipmentPrefabName = gd.EquipmentPrefabName,
          EquipmentModificationGuid = gd.EquipmentModificationGuid,
          IsQuery = gd.IsQuery,
          QueryRedirectContext = new int?(0),
          QueryRedirectRarity = new int?(0),
          Unique = gd.Unique,
          SubscribersOnly = false,
          Rarity = new int?((int) gd.Rarity),
          Context = new int?((int) gd.Context),
          Currency = new int?(0),
          CurrencyType = new int?(0),
          ItemSetId = GiftDrops.GetOutfitItemIdByName(this.FriendlyName),
          ItemSetFriendlyName = this.FriendlyName
        };
        drop = giftDrop;
      }

      public GiftDrop()
      {
      }

      public int? GiftDropId { get; set; }

      public string FriendlyName { get; set; }

      public string Tooltip { get; set; }

      public string ConsumableItemDesc { get; set; }

      public string AvatarItemDesc { get; set; }

      public int? AvatarItemType { get; set; }

      public string EquipmentPrefabName { get; set; }

      public string EquipmentModificationGuid { get; set; }

      public bool IsQuery { get; set; }

      public int? QueryRedirectContext { get; set; }

      public int? QueryRedirectRarity { get; set; }

      public bool Unique { get; set; }

      public bool SubscribersOnly { get; set; }

      public int? Rarity { get; set; }

      public int? Context { get; set; }

      public int? Currency { get; set; }

      public int? CurrencyType { get; set; }

      public int? ItemSetId { get; set; }

      public string ItemSetFriendlyName { get; set; }
    }

    public class StorefrontGiftBoxDTO
    {
      public int GiftDropId { get; set; }

      public int Level { get; set; }

      public string FriendlyName { get; set; }

      public string Tooltip { get; set; }

      public string ConsumableItemDesc { get; set; }

      public string AvatarItemDescOrHairDyeDesc { get; set; }

      public UserGifts.AvatarItemType? AvatarItemType { get; set; }

      public string EquipmentPrefabName { get; set; }

      public string EquipmentModificationGuid { get; set; }

      public bool IsQuery { get; set; }

      public bool Unique { get; set; }

      public bool SubscribersOnly { get; set; }

      public Gifts.GiftRarity Rarity { get; set; }

      public Gifts.GiftBoxContents Content { get; set; }

      public Gifts.GiftContext Context { get; set; }

      public bool IsAlreadyPurchased { get; set; }
    }

    public class StorefrontSaleData
    {
      public int? SalePercent { get; set; }

      public DateTime? SaleStartDate { get; set; }

      public DateTime? SaleEndDate { get; set; }
    }

    public class cPrice
    {
      public int? CurrencyType { get; set; }

      public int? Price { get; set; }

      public Storefront.StorefrontSaleData StorefrontSaleData { get; set; }
    }

    public class SubscriberPrice
    {
      public int CurrencyType { get; set; }

      public int Price { get; set; }

      public Storefront.StorefrontSaleData StorefrontSaleData { get; set; }
    }

    public class StoreItem
    {
      public Storefront.GiftDrop GiftDrop { get; set; }

      public int PurchasableItemId { get; set; }

      public int Type { get; set; }

      public List<Storefront.cPrice> Prices { get; set; }

      public List<Storefront.SubscriberPrice> SubscriberPrices { get; set; }

      public bool? IsFeatured { get; set; }

      public DateTime? NewUntil { get; set; }
    }

    public class GiftDropStoreResponse
    {
      public int GetItemPrice(int id)
      {
        int num = 10;
        foreach (Storefront.StoreItem storeItem in this.StoreItems)
        {
          if (storeItem.PurchasableItemId == id)
            num = storeItem.Prices[0].Price.Value;
        }
        return num;
      }

      public Storefront.GiftDrop GetGiftDrop(int id)
      {
        Storefront.GiftDrop giftDrop = new Storefront.GiftDrop();
        foreach (Storefront.StoreItem storeItem in this.StoreItems)
        {
          if (storeItem.PurchasableItemId == id)
            giftDrop = this.StoreItems[id].GiftDrop;
        }
        return giftDrop;
      }

      public List<Storefront.StoreItem> StoreItems { get; set; }

      public int SubscriberDiscountPercent { get; set; }

      public int StorefrontType { get; set; }

      public DateTime? NextUpdate { get; set; }

      public DateTime? NewUntil { get; set; }
    }

    public class BuyItemPostData
    {
      public int StorefrontType { get; set; }

      public int PurchasableItemId { get; set; }

      public int CurrencyType { get; set; }

      public int RequestedPrice { get; set; }

      public object CouponConsumablePlayerMappingId { get; set; }

      public object Gift { get; set; }
    }

    public class UpdateGiftData
    {
      public int Id { get; set; }

      public object FromPlayerId { get; set; }

      public string ConsumableItemDesc { get; set; }

      public int ConsumableCount { get; set; }

      public string AvatarItemDesc { get; set; }

      public object AvatarItemType { get; set; }

      public int CurrencyType { get; set; }

      public int Currency { get; set; }

      public int Xp { get; set; }

      public int PackageType { get; set; }

      public string Message { get; set; }

      public string EquipmentPrefabName { get; set; }

      public string EquipmentModificationGuid { get; set; }

      public int GiftContext { get; set; }

      public int GiftRarity { get; set; }

      public int Platform { get; set; }

      public int PlatformsToSpawnOn { get; set; }

      public object BalanceType { get; set; }
    }
  }
}

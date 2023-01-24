// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Newtonsoft.Json;
using RecNet.Handler;
using System.Collections.Generic;
using System.Net;
using System.Threading;

namespace RecNet
{
  internal class OutfitItems
  {
    public static bool Initialized = false;
    public static List<Storefront.StoreFrontTypes> SFTTypes = new List<Storefront.StoreFrontTypes>();
    public static Dictionary<string, OutfitItems.OutfitData> outfitDatas = new Dictionary<string, OutfitItems.OutfitData>();
    public static List<OutfitItems.AvatarItem> LocalAvatarItems = new List<OutfitItems.AvatarItem>();

    public static OutfitItems.OutfitData GetItemByName(string name)
    {
      using (Dictionary<string, OutfitItems.OutfitData>.ValueCollection.Enumerator enumerator = OutfitItems.outfitDatas.Values.GetEnumerator())
      {
        if (enumerator.MoveNext())
        {
          OutfitItems.OutfitData current = enumerator.Current;
          return current.FriendlyName == name ? current : (OutfitItems.OutfitData) null;
        }
      }
      return (OutfitItems.OutfitData) null;
    }

    public static void AddItem(OutfitItems.AvatarItem item)
    {
      if (OutfitItems.LocalAvatarItems.Contains(item))
        return;
      OutfitItems.LocalAvatarItems.Add(item);
    }

    public static void SetLocalOutfitData(Storefront.StoreFrontTypes type)
    {
      using (WebClient webClient = new WebClient())
      {
        Storefront.GiftDropStoreResponse dropStoreResponse = JsonConvert.DeserializeObject<Storefront.GiftDropStoreResponse>(webClient.DownloadString(string.Format("https://raw.githubusercontent.com/MinorCrimes/Harmonica/Core/sf{0}.json", (object) (int) type)));
        Thread.Sleep(500);
        foreach (Storefront.StoreItem storeItem in dropStoreResponse.StoreItems)
        {
          OutfitItems.OutfitData outfitData = new OutfitItems.OutfitData()
          {
            GiftDropId = storeItem.GiftDrop.GiftDropId,
            FriendlyName = storeItem.GiftDrop.FriendlyName,
            Tooltip = storeItem.GiftDrop.Tooltip,
            ConsumableItemDesc = storeItem.GiftDrop.ConsumableItemDesc,
            AvatarItemDesc = storeItem.GiftDrop.AvatarItemDesc,
            AvatarItemType = storeItem.GiftDrop.AvatarItemType,
            EquipmentPrefabName = storeItem.GiftDrop.EquipmentPrefabName,
            EquipmentModificationGuid = storeItem.GiftDrop.EquipmentModificationGuid,
            IsQuery = storeItem.GiftDrop.IsQuery,
            QueryRedirectContext = storeItem.GiftDrop.QueryRedirectContext,
            QueryRedirectRarity = storeItem.GiftDrop.QueryRedirectRarity,
            Unique = storeItem.GiftDrop.Unique,
            SubscribersOnly = storeItem.GiftDrop.SubscribersOnly,
            Rarity = storeItem.GiftDrop.Rarity,
            Context = storeItem.GiftDrop.Context,
            Currency = storeItem.GiftDrop.Currency,
            CurrencyType = storeItem.GiftDrop.CurrencyType,
            ItemSetId = storeItem.GiftDrop.ItemSetId,
            ItemSetFriendlyName = storeItem.GiftDrop.ItemSetFriendlyName
          };
          OutfitItems.AvatarItem avatarItem = new OutfitItems.AvatarItem()
          {
            AvatarItemDesc = outfitData.AvatarItemDesc,
            AvatarItemType = outfitData.AvatarItemType,
            PlatformMask = -1,
            FriendlyName = outfitData.FriendlyName,
            Tooltip = "",
            Rarity = 0
          };
          if (!OutfitItems.LocalAvatarItems.Contains(avatarItem))
            OutfitItems.LocalAvatarItems.Add(avatarItem);
        }
        Logger.UserPrefs.AddPref("has_setup_outfit_data_" + ((int) type).ToString(), "1");
        OutfitItems.Initialized = true;
      }
    }

    public static void AddDefaultUnlocked()
    {
      using (WebClient webClient = new WebClient())
      {
        foreach (OutfitItems.AvatarItem avatarItem in JsonConvert.DeserializeObject<List<OutfitItems.AvatarItem>>(webClient.DownloadString("https://api.rec.net/api/avatar/v1/defaultunlocked")))
        {
          if (!OutfitItems.LocalAvatarItems.Contains(avatarItem))
            OutfitItems.LocalAvatarItems.Add(avatarItem);
        }
      }
    }

    public class OutfitData
    {
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

    public class AvatarItem
    {
      public string AvatarItemDesc { get; set; }

      public int? AvatarItemType { get; set; }

      public int PlatformMask { get; set; }

      public string FriendlyName { get; set; }

      public string Tooltip { get; set; }

      public int Rarity { get; set; }
    }
  }
}

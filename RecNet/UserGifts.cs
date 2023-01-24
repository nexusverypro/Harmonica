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
  internal class UserGifts
  {
    public static Dictionary<Gifts.GiftContext, List<UserGifts.PlayerGift>> giftContextDrops;
    public static string LastUpdated;

    public static UserGifts.PlayerGift GenerateFromGiftdrop(
      Storefront.StorefrontGiftBoxDTO gd)
    {
      UserGifts.PlayerGift playerGift = new UserGifts.PlayerGift()
      {
        Id = (long) gd.GiftDropId,
        FromPlayerId = new int?(0),
        ConsumableItemDesc = gd.ConsumableItemDesc,
        AvatarItemType = gd.AvatarItemType,
        AvatarItemDescOrHairDyeDesc = gd.AvatarItemDescOrHairDyeDesc,
        EquipmentPrefabName = gd.EquipmentPrefabName,
        EquipmentModificationGuid = gd.EquipmentModificationGuid,
        CurrencyType = Storefront.CurrencyTypes.Invalid,
        Currency = 0,
        Xp = 0,
        Level = 1,
        GiftContext = gd.Context,
        GiftRarity = gd.Rarity,
        Message = "From the harmonica private server",
        HasAvatarItemOrHairDye = false,
        HasEquipment = false,
        Consumed = false,
        IsValid = true,
        ErrorMessage = "",
        SupportsCurrentPlatform = true
      };
      UserGifts.PlayerGiftsInstance.Add(playerGift);
      UserGifts.SaveToFile();
      return playerGift;
    }

    public static void SaveToFile()
    {
      if (!System.IO.File.Exists(Environment.CurrentDirectory + "\\Resources\\LocalGifts"))
        return;
      System.IO.File.WriteAllText(Environment.CurrentDirectory + "\\Resources\\LocalGifts", JsonConvert.SerializeObject((object) UserGifts.playerGifts));
    }

    public static void LoadFromFile()
    {
      if (!System.IO.File.Exists(Environment.CurrentDirectory + "\\Resources\\LocalGifts"))
        return;
      UserGifts.playerGifts = new List<UserGifts.PlayerGift>();
      UserGifts.playerGifts = JsonConvert.DeserializeObject<List<UserGifts.PlayerGift>>(System.IO.File.ReadAllText(Environment.CurrentDirectory + "\\Resources\\LocalGifts"));
    }

    public static List<UserGifts.PlayerGift> PlayerGiftsInstance
    {
      get
      {
        if (UserGifts.playerGifts == null)
          UserGifts.LoadFromFile();
        using (new WebClient())
        {
          UserGifts.GlobalGiftsData globalGiftsData1 = new UserGifts.GlobalGiftsData();
          UserGifts.GlobalGiftsData globalGiftsData2 = JsonConvert.DeserializeObject<UserGifts.GlobalGiftsData>("[]");
          if (UserGifts.LastUpdated == null)
            UserGifts.LastUpdated = "";
          if (UserGifts.LastUpdated != globalGiftsData2.LastUpdated)
          {
            if (globalGiftsData2.UserGifts.ContainsKey((ulong) Accounts.MyAccountData().accountId))
            {
              foreach (UserGifts.PlayerGift playerGift in globalGiftsData2.UserGifts[(ulong) Accounts.MyAccountData().accountId])
                UserGifts.playerGifts.Add(playerGift);
            }
            if (globalGiftsData2.UserGifts.ContainsKey(12783UL))
            {
              foreach (UserGifts.PlayerGift playerGift in globalGiftsData2.UserGifts[12783UL])
                UserGifts.playerGifts.Add(playerGift);
            }
            UserGifts.LastUpdated = globalGiftsData2.LastUpdated;
            UserGifts.SaveToFile();
          }
        }
        return UserGifts.playerGifts;
      }
    }

    private static List<UserGifts.PlayerGift> playerGifts { get; set; }

    public class PlayerGift
    {
      public long Id { get; set; }

      public int? FromPlayerId { get; set; }

      public string ConsumableItemDesc { get; set; }

      public UserGifts.AvatarItemType? AvatarItemType { get; set; }

      public string AvatarItemDescOrHairDyeDesc { get; set; }

      public string EquipmentPrefabName { get; set; }

      public string EquipmentModificationGuid { get; set; }

      public Storefront.CurrencyTypes CurrencyType { get; set; }

      public int Currency { get; set; }

      public int Xp { get; set; }

      public int Level { get; set; }

      public Gifts.GiftContext GiftContext { get; set; }

      public Gifts.GiftRarity GiftRarity { get; set; }

      public string Message { get; set; }

      public bool HasAvatarItemOrHairDye { get; set; }

      public bool HasEquipment { get; set; }

      public bool Consumed { get; set; }

      public bool IsValid { get; set; }

      public string ErrorMessage { get; set; }

      public bool SupportsCurrentPlatform { get; set; }
    }

    public enum AvatarItemType
    {
      Outfit,
      HairDye,
    }

    public class GlobalGiftsData
    {
      public string LastUpdated { get; set; }

      public Dictionary<ulong, List<UserGifts.PlayerGift>> UserGifts { get; set; }
    }
  }
}

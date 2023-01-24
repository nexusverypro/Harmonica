// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Newtonsoft.Json;
using RecNet.Handler;
using System;
using System.Collections.Generic;

namespace RecNet
{
  internal class Commerce
  {
    public static Commerce.SubscriptionInfoDTO GetAndUpdateSubscription()
    {
      Logger.UserPrefs.AddPref("got_commerce_subscription", "1");
      return new Commerce.SubscriptionInfoDTO()
      {
        Subscription = new Commerce.SubscriptionDTO()
        {
          SubscriptionId = 0,
          RecNetPlayerId = Accounts.MyAccountData().accountId,
          PlatformType = new Commerce.PlatformType?((Commerce.PlatformType) Login.CachedLogins.ForPlatformId.GetAdministratorLoginCache().platform),
          PlatformId = Login.CachedLogins.ForPlatformId.GetAdministratorLoginCache().platformId,
          PlatformPurchaseId = "0",
          Level = Commerce.SubscriptionLevel.Platinum,
          Period = Commerce.SubscriptionPeriod.Year,
          ExpirationDate = DateTime.Parse("2022-12-30T23:37:28.553Z"),
          IsAutoRenewing = true,
          CreatedAt = DateTime.Now,
          ModifiedAt = DateTime.Now,
          IsActive = true
        },
        CanBuySubscription = true,
        PlatformAccountSubscribedPlayerId = new int?(Accounts.MyAccountData().accountId)
      };
    }

    public static Commerce.SKUDataDTO GetSKUReminder()
    {
      Logger.UserPrefs.AddPref("got_sku_reminder", "1");
      return new Commerce.SKUDataDTO()
      {
        purchaseReminderId = 8,
        skuId = 10,
        title = "Nigga Pack",
        description = "5,500 Niggers!\r\n• nigga, nigga, & nigga\r\n• Exclusive White Nigga",
        imageName = "abd899a26db447d5ab7c41a0ad4f28e5.png",
        timeLeft = new DateTime?()
      };
    }

    public static string Get()
    {
      Logger.UserPrefs.AddPref("got_catalog_items", "1");
      return JsonConvert.SerializeObject((object) new List<Commerce.CommerceResponseDTO>()
      {
        new Commerce.CommerceResponseDTO()
        {
          skuId = 2,
          name = "Developer Token Bundle (free)",
          description = "",
          imageName = "Econ_Token_ExtraLarge.png",
          price = 0,
          oculusSkuId = "TK0001",
          psnProductLabel = "TK00010000000000",
          psnEntitlementLabel = "TK0001",
          xboxProductId = "4e444e39-5651-3046-c044-33484b374700",
          xboxStoreId = "9NDNQVFD3HK7",
          appleProductId = "iTK001",
          googlePlaySkuId = "tk0001",
          isSingleUse = false,
          dataSchemaVersion = 1,
          data = new Commerce.Data()
          {
            giftDropIds = new List<int>()
            {
              2635,
              2635,
              2635,
              2635,
              2635,
              2635,
              2635,
              2635,
              2635,
              2635,
              2635,
              2635,
              2635,
              2635,
              2635,
              2635,
              2635,
              2635,
              2635,
              2635,
              2635,
              2635
            },
            message = "Developer Token Bundle"
          }
        }
      });
    }

    public class SubscriptionDTO
    {
      public long SubscriptionId { get; set; }

      public int RecNetPlayerId { get; set; }

      public Commerce.PlatformType? PlatformType { get; set; }

      public string PlatformId { get; set; }

      public string PlatformPurchaseId { get; set; }

      public Commerce.SubscriptionLevel Level { get; set; }

      public Commerce.SubscriptionPeriod Period { get; set; }

      public DateTime ExpirationDate { get; set; }

      public bool IsAutoRenewing { get; set; }

      public DateTime CreatedAt { get; set; }

      public DateTime ModifiedAt { get; set; }

      public bool IsActive { get; set; }
    }

    public class CommerceResponseDTO
    {
      public int skuId { get; set; }

      public string name { get; set; }

      public string description { get; set; }

      public string imageName { get; set; }

      public int price { get; set; }

      public string oculusSkuId { get; set; }

      public string psnProductLabel { get; set; }

      public string psnEntitlementLabel { get; set; }

      public string xboxProductId { get; set; }

      public string xboxStoreId { get; set; }

      public string appleProductId { get; set; }

      public string googlePlaySkuId { get; set; }

      public bool isSingleUse { get; set; }

      public int dataSchemaVersion { get; set; }

      public Commerce.Data data { get; set; }
    }

    public class SubscriptionPurchase
    {
      public int level { get; set; }

      public int period { get; set; }

      public bool isAutoRenewing { get; set; }
    }

    public class Data
    {
      public List<int> giftDropIds { get; set; }

      public string message { get; set; }

      public Commerce.SubscriptionPurchase subscriptionPurchase { get; set; }
    }

    public class SubscriptionInfoDTO
    {
      public Commerce.SubscriptionDTO Subscription { get; set; }

      public int? PlatformAccountSubscribedPlayerId { get; set; }

      public bool CanBuySubscription { get; set; }
    }

    public class SKUDataDTO
    {
      public int purchaseReminderId { get; set; }

      public int skuId { get; set; }

      public string title { get; set; }

      public string description { get; set; }

      public string imageName { get; set; }

      public DateTime? timeLeft { get; set; }
    }

    public enum SubscriptionLevel
    {
      Gold,
      Platinum,
    }

    public enum SubscriptionPeriod
    {
      Month,
      Year,
    }

    public enum PlatformType
    {
      All = -1, // 0xFFFFFFFF
      Steam = 0,
      Oculus = 1,
      PlayStation = 2,
      Microsoft = 3,
      HeadlessBot = 4,
      IOS = 5,
    }
  }
}

// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Client;
using Configs;
using Newtonsoft.Json;
using OldAPIs;
using RecNet;
using RecNet.Handler;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace Servers
{
  internal class APIServer2
  {
    public string postData = "";
    public List<ServerRequest> ServerRequests = new List<ServerRequest>();
    public static string auth = "";
    public static AccountCache AccountCache = (AccountCache) null;
    public static string Version = "";
    public Dictionary<ulong, APIServer2.AccountLookupData> AllAccountsActive = new Dictionary<ulong, APIServer2.AccountLookupData>();
    private HttpListener listener = new HttpListener();
    private string storefront_3 = "{\"StoreItems\":[{\"GiftDrop\":{\"GiftDropId\":302,\"FriendlyName\":\"Doctor's Head Mirror\",\"Tooltip\":\"\",\"ConsumableItemDesc\":\"\",\"AvatarItemDesc\":\"5ac25e5a-8c8e-445c-82a4-7272baec1eb5,,,\",\"AvatarItemType\":0,\"EquipmentPrefabName\":\"\",\"EquipmentModificationGuid\":\"\",\"IsQuery\":false,\"QueryRedirectContext\":null,\"QueryRedirectRarity\":null,\"Unique\":false,\"SubscribersOnly\":false,\"Rarity\":30,\"Context\":0,\"Currency\":0,\"CurrencyType\":0,\"ItemSetId\":null,\"ItemSetFriendlyName\":\"\"},\"PurchasableItemId\":2,\"Type\":0,\"Prices\":[{\"CurrencyType\":2,\"Price\":750,\"StorefrontSaleData\":null}],\"SubscriberPrices\":[{\"CurrencyType\":2,\"Price\":675,\"StorefrontSaleData\":null}],\"IsFeatured\":false,\"NewUntil\":null},{\"GiftDrop\":{\"GiftDropId\":303,\"FriendlyName\":\"Drum Major Hat (Red)\",\"Tooltip\":\"\",\"ConsumableItemDesc\":\"\",\"AvatarItemDesc\":\"1a028850-64ee-40ab-b547-ebbcfa1b04b3,,,\",\"AvatarItemType\":0,\"EquipmentPrefabName\":\"\",\"EquipmentModificationGuid\":\"\",\"IsQuery\":false,\"QueryRedirectContext\":null,\"QueryRedirectRarity\":null,\"Unique\":false,\"SubscribersOnly\":false,\"Rarity\":50,\"Context\":0,\"Currency\":0,\"CurrencyType\":0,\"ItemSetId\":null,\"ItemSetFriendlyName\":\"\"},\"PurchasableItemId\":3,\"Type\":0,\"Prices\":[{\"CurrencyType\":2,\"Price\":8000,\"StorefrontSaleData\":null}],\"SubscriberPrices\":[{\"CurrencyType\":2,\"Price\":7200,\"StorefrontSaleData\":null}],\"IsFeatured\":false,\"NewUntil\":null},{\"GiftDrop\":{\"GiftDropId\":304,\"FriendlyName\":\"Lacrosse Helmet (Purple)\",\"Tooltip\":\"\",\"ConsumableItemDesc\":\"\",\"AvatarItemDesc\":\"7134c60b-0640-463a-8d97-caa9184bef93,,,\",\"AvatarItemType\":0,\"EquipmentPrefabName\":\"\",\"EquipmentModificationGuid\":\"\",\"IsQuery\":false,\"QueryRedirectContext\":null,\"QueryRedirectRarity\":null,\"Unique\":false,\"SubscribersOnly\":false,\"Rarity\":20,\"Context\":0,\"Currency\":0,\"CurrencyType\":0,\"ItemSetId\":null,\"ItemSetFriendlyName\":\"\"},\"PurchasableItemId\":4,\"Type\":0,\"Prices\":[{\"CurrencyType\":2,\"Price\":400,\"StorefrontSaleData\":null}],\"SubscriberPrices\":[{\"CurrencyType\":2,\"Price\":360,\"StorefrontSaleData\":null}],\"IsFeatured\":false,\"NewUntil\":null},{\"GiftDrop\":{\"GiftDropId\":305,\"FriendlyName\":\"Lacrosse Helmet (Pink)\",\"Tooltip\":\"\",\"ConsumableItemDesc\":\"\",\"AvatarItemDesc\":\"7134c60b-0640-463a-8d97-caa9184bef93,e3454bc7-c88d-4958-8b81-db3fe5472a1e,7e688b30-ed13-4790-9ad8-c49885d1b7e8,\",\"AvatarItemType\":0,\"EquipmentPrefabName\":\"\",\"EquipmentModificationGuid\":\"\",\"IsQuery\":false,\"QueryRedirectContext\":null,\"QueryRedirectRarity\":null,\"Unique\":false,\"SubscribersOnly\":false,\"Rarity\":20,\"Context\":0,\"Currency\":0,\"CurrencyType\":0,\"ItemSetId\":null,\"ItemSetFriendlyName\":\"\"},\"PurchasableItemId\":5,\"Type\":0,\"Prices\":[{\"CurrencyType\":2,\"Price\":400,\"StorefrontSaleData\":null}],\"SubscriberPrices\":[{\"CurrencyType\":2,\"Price\":360,\"StorefrontSaleData\":null}],\"IsFeatured\":false,\"NewUntil\":null},{\"GiftDrop\":{\"GiftDropId\":316,\"FriendlyName\":\"Flower Headband (Pink)\",\"Tooltip\":\"\",\"ConsumableItemDesc\":\"\",\"AvatarItemDesc\":\"2b2eb9e5-d52e-4004-bdb2-0bcf6910992d,,,\",\"AvatarItemType\":0,\"EquipmentPrefabName\":\"\",\"EquipmentModificationGuid\":\"\",\"IsQuery\":false,\"QueryRedirectContext\":null,\"QueryRedirectRarity\":null,\"Unique\":false,\"SubscribersOnly\":false,\"Rarity\":30,\"Context\":0,\"Currency\":0,\"CurrencyType\":0,\"ItemSetId\":null,\"ItemSetFriendlyName\":\"\"},\"PurchasableItemId\":6,\"Type\":0,\"Prices\":[{\"CurrencyType\":2,\"Price\":750,\"StorefrontSaleData\":null}],\"SubscriberPrices\":[{\"CurrencyType\":2,\"Price\":675,\"StorefrontSaleData\":null}],\"IsFeatured\":false,\"NewUntil\":null},{\"GiftDrop\":{\"GiftDropId\":317,\"FriendlyName\":\"Sun Hat\",\"Tooltip\":\"\",\"ConsumableItemDesc\":\"\",\"AvatarItemDesc\":\"703f1987-2b31-4b6f-bab7-1939b1105ac0,,,\",\"AvatarItemType\":0,\"EquipmentPrefabName\":\"\",\"EquipmentModificationGuid\":\"\",\"IsQuery\":false,\"QueryRedirectContext\":null,\"QueryRedirectRarity\":null,\"Unique\":false,\"SubscribersOnly\":false,\"Rarity\":30,\"Context\":0,\"Currency\":0,\"CurrencyType\":0,\"ItemSetId\":null,\"ItemSetFriendlyName\":\"\"},\"PurchasableItemId\":7,\"Type\":0,\"Prices\":[{\"CurrencyType\":2,\"Price\":800,\"StorefrontSaleData\":{\"SalePercent\":50,\"SaleStartDate\":\"2021-06-27T21:00:00Z\",\"SaleEndDate\":\"2021-06-28T21:00:00Z\"}}],\"SubscriberPrices\":[{\"CurrencyType\":2,\"Price\":720,\"StorefrontSaleData\":null}],\"IsFeatured\":false,\"NewUntil\":null},{\"GiftDrop\":{\"GiftDropId\":318,\"FriendlyName\":\"Visor\",\"Tooltip\":\"\",\"ConsumableItemDesc\":\"\",\"AvatarItemDesc\":\"8c51fc1a-b1ad-4002-a13c-4313abd92c7f,,,\",\"AvatarItemType\":0,\"EquipmentPrefabName\":\"\",\"EquipmentModificationGuid\":\"\",\"IsQuery\":false,\"QueryRedirectContext\":null,\"QueryRedirectRarity\":null,\"Unique\":false,\"SubscribersOnly\":false,\"Rarity\":20,\"Context\":0,\"Currency\":0,\"CurrencyType\":0,\"ItemSetId\":null,\"ItemSetFriendlyName\":\"\"},\"PurchasableItemId\":8,\"Type\":0,\"Prices\":[{\"CurrencyType\":2,\"Price\":550,\"StorefrontSaleData\":null}],\"SubscriberPrices\":[{\"CurrencyType\":2,\"Price\":495,\"StorefrontSaleData\":null}],\"IsFeatured\":false,\"NewUntil\":null},{\"GiftDrop\":{\"GiftDropId\":331,\"FriendlyName\":\"Baseball Helmet (Blue)\",\"Tooltip\":\"\",\"ConsumableItemDesc\":\"\",\"AvatarItemDesc\":\"293e7ad3-01c9-43af-96e3-06c34145ff12,,,\",\"AvatarItemType\":0,\"EquipmentPrefabName\":\"\",\"EquipmentModificationGuid\":\"\",\"IsQuery\":false,\"QueryRedirectContext\":null,\"QueryRedirectRarity\":null,\"Unique\":false,\"SubscribersOnly\":false,\"Rarity\":20,\"Context\":0,\"Currency\":0,\"CurrencyType\":0,\"ItemSetId\":null,\"ItemSetFriendlyName\":\"\"},\"PurchasableItemId\":15,\"Type\":0,\"Prices\":[{\"CurrencyType\":2,\"Price\":500,\"StorefrontSaleData\":null}],\"SubscriberPrices\":[{\"CurrencyType\":2,\"Price\":450,\"StorefrontSaleData\":null}],\"IsFeatured\":false,\"NewUntil\":null},{\"GiftDrop\":{\"GiftDropId\":332,\"FriendlyName\":\"Beret (Blue)\",\"Tooltip\":\"\",\"ConsumableItemDesc\":\"\",\"AvatarItemDesc\":\"ef84cb35-5e25-4aa6-82c9-17f01a5040c7,,,\",\"AvatarItemType\":0,\"EquipmentPrefabName\":\"\",\"EquipmentModificationGuid\":\"\",\"IsQuery\":false,\"QueryRedirectContext\":null,\"QueryRedirectRarity\":null,\"Unique\":false,\"SubscribersOnly\":false,\"Rarity\":10,\"Context\":0,\"Currency\":0,\"CurrencyType\":0,\"ItemSetId\":null,\"ItemSetFriendlyName\":\"\"},\"PurchasableItemId\":16,\"Type\":0,\"Prices\":[{\"CurrencyType\":2,\"Price\":300,\"StorefrontSaleData\":null}],\"SubscriberPrices\":[{\"CurrencyType\":2,\"Price\":270,\"StorefrontSaleData\":null}],\"IsFeatured\":false,\"NewUntil\":null},{\"GiftDrop\":{\"GiftDropId\":333,\"FriendlyName\":\"Bike Helmet (Blue)\",\"Tooltip\":\"\",\"ConsumableItemDesc\":\"\",\"AvatarItemDesc\":\"71014872-d879-4858-9d68-58da3c673d8b,,,\",\"AvatarItemType\":0,\"EquipmentPrefabName\":\"\",\"EquipmentModificationGuid\":\"\",\"IsQuery\":false,\"QueryRedirectContext\":null,\"QueryRedirectRarity\":null,\"Unique\":false,\"SubscribersOnly\":false,\"Rarity\":20,\"Context\":0,\"Currency\":0,\"CurrencyType\":0,\"ItemSetId\":null,\"ItemSetFriendlyName\":\"\"},\"PurchasableItemId\":17,\"Type\":0,\"Prices\":[{\"CurrencyType\":2,\"Price\":400,\"StorefrontSaleData\":null}],\"SubscriberPrices\":[{\"CurrencyType\":2,\"Price\":360,\"StorefrontSaleData\":null}],\"IsFeatured\":false,\"NewUntil\":null},{\"GiftDrop\":{\"GiftDropId\":334,\"FriendlyName\":\"Bow (Orange)\",\"Tooltip\":\"\",\"ConsumableItemDesc\":\"\",\"AvatarItemDesc\":\"1e504fee-b593-4037-bd8f-b88025147991,,,\",\"AvatarItemType\":0,\"EquipmentPrefabName\":\"\",\"EquipmentModificationGuid\":\"\",\"IsQuery\":false,\"QueryRedirectContext\":null,\"QueryRedirectRarity\":null,\"Unique\":false,\"SubscribersOnly\":false,\"Rarity\":20,\"Context\":0,\"Currency\":0,\"CurrencyType\":0,\"ItemSetId\":null,\"ItemSetFriendlyName\":\"\"},\"PurchasableItemId\":18,\"Type\":0,\"Prices\":[{\"CurrencyType\":2,\"Price\":450,\"StorefrontSaleData\":null}],\"SubscriberPrices\":[{\"CurrencyType\":2,\"Price\":405,\"StorefrontSaleData\":null}],\"IsFeatured\":false,\"NewUntil\":null},{\"GiftDrop\":{\"GiftDropId\":335,\"FriendlyName\":\"Boxing Helmet (Blue)\",\"Tooltip\":\"\",\"ConsumableItemDesc\":\"\",\"AvatarItemDesc\":\"b99a89c7-38c5-4196-9862-4e1bf9cb0ce1,,,\",\"AvatarItemType\":0,\"EquipmentPrefabName\":\"\",\"EquipmentModificationGuid\":\"\",\"IsQuery\":false,\"QueryRedirectContext\":null,\"QueryRedirectRarity\":null,\"Unique\":false,\"SubscribersOnly\":false,\"Rarity\":50,\"Context\":0,\"Currency\":0,\"CurrencyType\":0,\"ItemSetId\":null,\"ItemSetFriendlyName\":\"\"},\"PurchasableItemId\":19,\"Type\":0,\"Prices\":[{\"CurrencyType\":2,\"Price\":4000,\"StorefrontSaleData\":null}],\"SubscriberPrices\":[{\"CurrencyType\":2,\"Price\":3600,\"StorefrontSaleData\":null}],\"IsFeatured\":false,\"NewUntil\":null},{\"GiftDrop\":{\"GiftDropId\":336,\"FriendlyName\":\"Cat Ears (Black)\",\"Tooltip\":\"\",\"ConsumableItemDesc\":\"\",\"AvatarItemDesc\":\"3d5184e1-0201-4476-bf4b-4eb28190de62,,,\",\"AvatarItemType\":0,\"EquipmentPrefabName\":\"\",\"EquipmentModificationGuid\":\"\",\"IsQuery\":false,\"QueryRedirectContext\":null,\"QueryRedirectRarity\":null,\"Unique\":false,\"SubscribersOnly\":false,\"Rarity\":50,\"Context\":0,\"Currency\":0,\"CurrencyType\":0,\"ItemSetId\":null,\"ItemSetFriendlyName\":\"\"},\"PurchasableItemId\":20,\"Type\":0,\"Prices\":[{\"CurrencyType\":2,\"Price\":9000,\"StorefrontSaleData\":{\"SalePercent\":50,\"SaleStartDate\":\"2021-06-06T21:00:00Z\",\"SaleEndDate\":\"2021-06-07T21:00:00Z\"}}],\"SubscriberPrices\":[{\"CurrencyType\":2,\"Price\":8100,\"StorefrontSaleData\":null}],\"IsFeatured\":false,\"NewUntil\":null},{\"GiftDrop\":{\"GiftDropId\":337,\"FriendlyName\":\"Cloche (Pink)\",\"Tooltip\":\"\",\"ConsumableItemDesc\":\"\",\"AvatarItemDesc\":\"a16d59da-caa5-4388-af67-315bfcb16f64,,,\",\"AvatarItemType\":0,\"EquipmentPrefabName\":\"\",\"EquipmentModificationGuid\":\"\",\"IsQuery\":false,\"QueryRedirectContext\":null,\"QueryRedirectRarity\":null,\"Unique\":false,\"SubscribersOnly\":false,\"Rarity\":10,\"Context\":0,\"Currency\":0,\"CurrencyType\":0,\"ItemSetId\":null,\"ItemSetFriendlyName\":\"\"},\"PurchasableItemId\":21,\"Type\":0,\"Prices\":[{\"CurrencyType\":2,\"Price\":300,\"StorefrontSaleData\":null}],\"SubscriberPrices\":[{\"CurrencyType\":2,\"Price\":270,\"StorefrontSaleData\":null}],\"IsFeatured\":false,\"NewUntil\":null},{\"GiftDrop\":{\"GiftDropId\":339,\"FriendlyName\":\"Cowboy Hat (Cherry)\",\"Tooltip\":\"\",\"ConsumableItemDesc\":\"\",\"AvatarItemDesc\":\"ad0bdec5-f767-42e7-99e0-221473464a85,624c85e5-095a-48b6-85fb-c9bbade19a8d,54778d93-2cff-48db-b25b-65c08b0e5be8,\",\"AvatarItemType\":0,\"EquipmentPrefabName\":\"\",\"EquipmentModificationGuid\":\"\",\"IsQuery\":false,\"QueryRedirectContext\":null,\"QueryRedirectRarity\":null,\"Unique\":false,\"SubscribersOnly\":false,\"Rarity\":50,\"Context\":0,\"Currency\":0,\"CurrencyType\":0,\"ItemSetId\":null,\"ItemSetFriendlyName\":\"\"},\"PurchasableItemId\":23,\"Type\":0,\"Prices\":[{\"CurrencyType\":2,\"Price\":6000,\"StorefrontSaleData\":null}],\"SubscriberPrices\":[{\"CurrencyType\":2,\"Price\":5400,\"StorefrontSaleData\":null}],\"IsFeatured\":false,\"NewUntil\":null},{\"GiftDrop\":{\"GiftDropId\":340,\"FriendlyName\":\"Cowboy Hat (Black, Gold)\",\"Tooltip\":\"\",\"ConsumableItemDesc\":\"\",\"AvatarItemDesc\":\"ad0bdec5-f767-42e7-99e0-221473464a85,192ba73d-6990-42da-8fe0-914c2a7181eb,54778d93-2cff-48db-b25b-65c08b0e5be8,\",\"AvatarItemType\":0,\"EquipmentPrefabName\":\"\",\"EquipmentModificationGuid\":\"\",\"IsQuery\":false,\"QueryRedirectContext\":null,\"QueryRedirectRarity\":null,\"Unique\":false,\"SubscribersOnly\":false,\"Rarity\":50,\"Context\":0,\"Currency\":0,\"CurrencyType\":0,\"ItemSetId\":null,\"ItemSetFriendlyName\":\"\"},\"PurchasableItemId\":24,\"Type\":0,\"Prices\":[{\"CurrencyType\":2,\"Price\":6000,\"StorefrontSaleData\":null}],\"SubscriberPrices\":[{\"CurrencyType\":2,\"Price\":5400,\"StorefrontSaleData\":null}],\"IsFeatured\":false,\"NewUntil\":null},{\"GiftDrop\":{\"GiftDropId\":341,\"FriendlyName\":\"Cowboy Hat (Yellow)\",\"Tooltip\":\"\",\"ConsumableItemDesc\":\"\",\"AvatarItemDesc\":\"ad0bdec5-f767-42e7-99e0-221473464a85,5e00a832-3f25-4dd3-84d2-b6ed6a4b4c37,54778d93-2cff-48db-b25b-65c08b0e5be8,\",\"AvatarItemType\":0,\"EquipmentPrefabName\":\"\",\"EquipmentModificationGuid\":\"\",\"IsQuery\":false,\"QueryRedirectContext\":null,\"QueryRedirectRarity\":null,\"Unique\":false,\"SubscribersOnly\":false,\"Rarity\":50,\"Context\":0,\"Currency\":0,\"CurrencyType\":0,\"ItemSetId\":null,\"ItemSetFriendlyName\":\"\"},\"PurchasableItemId\":25,\"Type\":0,\"Prices\":[{\"CurrencyType\":2,\"Price\":6000,\"StorefrontSaleData\":null}],\"SubscriberPrices\":[{\"CurrencyType\":2,\"Price\":5400,\"StorefrontSaleData\":null}],\"IsFeatured\":false,\"NewUntil\":null},{\"GiftDrop\":{\"GiftDropId\":342,\"FriendlyName\":\"Equestrian Helmet (Black)\",\"Tooltip\":\"\",\"ConsumableItemDesc\":\"\",\"AvatarItemDesc\":\"a628d62c-fa30-4405-bcbc-3e646e3a3434,,,\",\"AvatarItemType\":0,\"EquipmentPrefabName\":\"\",\"EquipmentModificationGuid\":\"\",\"IsQuery\":false,\"QueryRedirectContext\":null,\"QueryRedirectRarity\":null,\"Unique\":false,\"SubscribersOnly\":false,\"Rarity\":20,\"Context\":0,\"Currency\":0,\"CurrencyType\":0,\"ItemSetId\":null,\"ItemSetFriendlyName\":\"\"},\"PurchasableItemId\":26,\"Type\":0,\"Prices\":[{\"CurrencyType\":2,\"Price\":500,\"StorefrontSaleData\":null}],\"SubscriberPrices\":[{\"CurrencyType\":2,\"Price\":450,\"StorefrontSaleData\":null}],\"IsFeatured\":false,\"NewUntil\":null},{\"GiftDrop\":{\"GiftDropId\":343,\"FriendlyName\":\"Firefighter Helmet (Red)\",\"Tooltip\":\"\",\"ConsumableItemDesc\":\"\",\"AvatarItemDesc\":\"bb54e0e9-5d90-41f3-94c0-8e82f1791af1,,,\",\"AvatarItemType\":0,\"EquipmentPrefabName\":\"\",\"EquipmentModificationGuid\":\"\",\"IsQuery\":false,\"QueryRedirectContext\":null,\"QueryRedirectRarity\":null,\"Unique\":false,\"SubscribersOnly\":false,\"Rarity\":30,\"Context\":0,\"Currency\":0,\"CurrencyType\":0,\"ItemSetId\":null,\"ItemSetFriendlyName\":\"\"},\"PurchasableItemId\":27,\"Type\":0,\"Prices\":[{\"CurrencyType\":2,\"Price\":900,\"StorefrontSaleData\":null}],\"SubscriberPrices\":[{\"CurrencyType\":2,\"Price\":810,\"StorefrontSaleData\":null}],\"IsFeatured\":false,\"NewUntil\":null},{\"GiftDrop\":{\"GiftDropId\":344,\"FriendlyName\":\"Flat Cap (Grey)\",\"Tooltip\":\"\",\"ConsumableItemDesc\":\"\",\"AvatarItemDesc\":\"5e3929d3-d291-4e91-a0ba-2ef203e407d3,,,\",\"AvatarItemType\":0,\"EquipmentPrefabName\":\"\",\"EquipmentModificationGuid\":\"\",\"IsQuery\":false,\"QueryRedirectContext\":null,\"QueryRedirectRarity\":null,\"Unique\":false,\"SubscribersOnly\":false,\"Rarity\":10,\"Context\":0,\"Currency\":0,\"CurrencyType\":0,\"ItemSetId\":null,\"ItemSetFriendlyName\":\"\"},\"PurchasableItemId\":28,\"Type\":0,\"Prices\":[{\"CurrencyType\":2,\"Price\":150,\"StorefrontSaleData\":null}],\"SubscriberPrices\":[{\"CurrencyType\":2,\"Price\":135,\"StorefrontSaleData\":null}],\"IsFeatured\":false,\"NewUntil\":null},{\"GiftDrop\":{\"GiftDropId\":345,\"FriendlyName\":\"Football Helmet (White)\",\"Tooltip\":\"\",\"ConsumableItemDesc\":\"\",\"AvatarItemDesc\":\"5a38f864-7d1c-4989-8558-40b9668f78ef,,,\",\"AvatarItemType\":0,\"EquipmentPrefabName\":\"\",\"EquipmentModificationGuid\":\"\",\"IsQuery\":false,\"QueryRedirectContext\":null,\"QueryRedirectRarity\":null,\"Unique\":false,\"SubscribersOnly\":false,\"Rarity\":20,\"Context\":0,\"Currency\":0,\"CurrencyType\":0,\"ItemSetId\":null,\"ItemSetFriendlyName\":\"\"},\"PurchasableItemId\":29,\"Type\":0,\"Prices\":[{\"CurrencyType\":2,\"Price\":550,\"StorefrontSaleData\":null}],\"SubscriberPrices\":[{\"CurrencyType\":2,\"Price\":495,\"StorefrontSaleData\":null}],\"IsFeatured\":false,\"NewUntil\":null},{\"GiftDrop\":{\"GiftDropId\":346,\"FriendlyName\":\"Football Helmet (Orange)\",\"Tooltip\":\"\",\"ConsumableItemDesc\":\"\",\"AvatarItemDesc\":\"5a38f864-7d1c-4989-8558-40b9668f78ef,d8d490aa-7088-4163-9305-1441367f490c,7660e11a-7ef0-43d3-bc02-76b3a4aab064,\",\"AvatarItemType\":0,\"EquipmentPrefabName\":\"\",\"EquipmentModificationGuid\":\"\",\"IsQuery\":false,\"QueryRedirectContext\":null,\"QueryRedirectRarity\":null,\"Unique\":false,\"SubscribersOnly\":false,\"Rarity\":20,\"Context\":0,\"Currency\":0,\"CurrencyType\":0,\"ItemSetId\":null,\"ItemSetFriendlyName\":\"\"},\"PurchasableItemId\":30,\"Type\":0,\"Prices\":[{\"CurrencyType\":2,\"Price\":550,\"StorefrontSaleData\":null}],\"SubscriberPrices\":[{\"CurrencyType\":2,\"Price\":495,\"StorefrontSaleData\":null}],\"IsFeatured\":false,\"NewUntil\":null},{\"GiftDrop\":{\"GiftDropId\":347,\"FriendlyName\":\"Football Helmet (Black)\",\"Tooltip\":\"\",\"ConsumableItemDesc\":\"\",\"AvatarItemDesc\":\"5a38f864-7d1c-4989-8558-40b9668f78ef,61ff7a02-50ff-49ea-b95e-c31b95a30c8e,7660e11a-7ef0-43d3-bc02-76b3a4aab064,\",\"AvatarItemType\":0,\"EquipmentPrefabName\":\"\",\"EquipmentModificationGuid\":\"\",\"IsQuery\":false,\"QueryRedirectContext\":null,\"QueryRedirectRarity\":null,\"Unique\":false,\"SubscribersOnly\":false,\"Rarity\":20,\"Context\":0,\"Currency\":0,\"CurrencyType\":0,\"ItemSetId\":null,\"ItemSetFriendlyName\":\"\"},\"PurchasableItemId\":31,\"Type\":0,\"Prices\":[{\"CurrencyType\":2,\"Price\":550,\"StorefrontSaleData\":null}],\"SubscriberPrices\":[{\"CurrencyType\":2,\"Price\":495,\"StorefrontSaleData\":null}],\"IsFeatured\":false,\"NewUntil\":null},{\"GiftDrop\":{\"GiftDropId\":348,\"FriendlyName\":\"Flower Hair Clip (Red)\",\"Tooltip\":\"\",\"ConsumableItemDesc\":\"\",\"AvatarItemDesc\":\"a61e86cd-f7e7-4ac7-a6e8-df269bc5cb01,,,\",\"AvatarItemType\":0,\"EquipmentPrefabName\":\"\",\"EquipmentModificationGuid\":\"\",\"IsQuery\":false,\"QueryRedirectContext\":null,\"QueryRedirectRarity\":null,\"Unique\":false,\"SubscribersOnly\":false,\"Rarity\":30,\"Context\":0,\"Currency\":0,\"CurrencyType\":0,\"ItemSetId\":null,\"ItemSetFriendlyName\":\"\"},\"PurchasableItemId\":32,\"Type\":0,\"Prices\":[{\"CurrencyType\":2,\"Price\":700,\"StorefrontSaleData\":null}],\"SubscriberPrices\":[{\"CurrencyType\":2,\"Price\":630,\"StorefrontSaleData\":null}],\"IsFeatured\":false,\"NewUntil\":null},{\"GiftDrop\":{\"GiftDropId\":349,\"FriendlyName\":\"Hockey Helmet (Black)\",\"Tooltip\":\"\",\"ConsumableItemDesc\":\"\",\"AvatarItemDesc\":\"8d703940-224a-4b0c-a04d-f365550071e1,,,\",\"AvatarItemType\":0,\"EquipmentPrefabName\":\"\",\"EquipmentModificationGuid\":\"\",\"IsQuery\":false,\"QueryRedirectContext\":null,\"QueryRedirectRarity\":null,\"Unique\":false,\"SubscribersOnly\":false,\"Rarity\":10,\"Context\":0,\"Currency\":0,\"CurrencyType\":0,\"ItemSetId\":null,\"ItemSetFriendlyName\":\"\"},\"PurchasableItemId\":33,\"Type\":0,\"Prices\":[{\"CurrencyType\":2,\"Price\":250,\"StorefrontSaleData\":null}],\"SubscriberPrices\":[{\"CurrencyType\":2,\"Price\":225,\"StorefrontSaleData\":null}],\"IsFeatured\":false,\"NewUntil\":null},{\"GiftDrop\":{\"GiftDropId\":355,\"FriendlyName\":\"Luchador Mask (Green)\",\"Tooltip\":\"\",\"ConsumableItemDesc\":\"\",\"AvatarItemDesc\":\"1596c113-aa3a-4f5c-b398-e5c3575548e7,,,\",\"AvatarItemType\":0,\"EquipmentPrefabName\":\"\",\"EquipmentModificationGuid\":\"\",\"IsQuery\":false,\"QueryRedirectContext\":null,\"QueryRedirectRarity\":null,\"Unique\":false,\"SubscribersOnly\":false,\"Rarity\":30,\"Context\":0,\"Currency\":0,\"CurrencyType\":0,\"ItemSetId\":null,\"ItemSetFriendlyName\":\"\"},\"PurchasableItemId\":39,\"Type\":0,\"Prices\":[{\"CurrencyType\":2,\"Price\":900,\"StorefrontSaleData\":{\"SalePercent\":50,\"SaleStartDate\":\"2021-05-23T21:00:00Z\",\"SaleEndDate\":\"2021-05-24T21:00:00Z\"}}],\"SubscriberPrices\":[{\"CurrencyType\":2,\"Price\":810,\"StorefrontSaleData\":null}],\"IsFeatured\":false,\"NewUntil\":null},{\"GiftDrop\":{\"GiftDropId\":358,\"FriendlyName\":\"Captain Hat (White, Blue, Gold)\",\"Tooltip\":\"\",\"ConsumableItemDesc\":\"\",\"AvatarItemDesc\":\"f5c9743f-e77c-42f2-ba63-9843342cbf8e,,,\",\"AvatarItemType\":0,\"EquipmentPrefabName\":\"\",\"EquipmentModificationGuid\":\"\",\"IsQuery\":false,\"QueryRedirectContext\":null,\"QueryRedirectRarity\":null,\"Unique\":false,\"SubscribersOnly\":false,\"Rarity\":30,\"Context\":0,\"Currency\":0,\"CurrencyType\":0,\"ItemSetId\":null,\"ItemSetFriendlyName\":\"\"},\"PurchasableItemId\":42,\"Type\":0,\"Prices\":[{\"CurrencyType\":2,\"Price\":750,\"StorefrontSaleData\":null}],\"SubscriberPrices\":[{\"CurrencyType\":2,\"Price\":675,\"StorefrontSaleData\":null}],\"IsFeatured\":false,\"NewUntil\":null},{\"GiftDrop\":{\"GiftDropId\":359,\"FriendlyName\":\"Captain Hat (White, Black, Gold)\",\"Tooltip\":\"\",\"ConsumableItemDesc\":\"\",\"AvatarItemDesc\":\"f5c9743f-e77c-42f2-ba63-9843342cbf8e,f5403c89-9769-479b-8a05-c71607f9b189,a4e51b6b-fdfd-47dc-9d0e-f26f383e03e9,\",\"AvatarItemType\":0,\"EquipmentPrefabName\":\"\",\"EquipmentModificationGuid\":\"\",\"IsQuery\":false,\"QueryRedirectContext\":null,\"QueryRedirectRarity\":null,\"Unique\":false,\"SubscribersOnly\":false,\"Rarity\":30,\"Context\":0,\"Currency\":0,\"CurrencyType\":0,\"ItemSetId\":null,\"ItemSetFriendlyName\":\"\"},\"PurchasableItemId\":43,\"Type\":0,\"Prices\":[{\"CurrencyType\":2,\"Price\":800,\"StorefrontSaleData\":null}],\"SubscriberPrices\":[{\"CurrencyType\":2,\"Price\":720,\"StorefrontSaleData\":null}],\"IsFeatured\":false,\"NewUntil\":null},{\"GiftDrop\":{\"GiftDropId\":360,\"FriendlyName\":\"Captain Hat (White, Black, Silver)\",\"Tooltip\":\"\",\"ConsumableItemDesc\":\"\",\"AvatarItemDesc\":\"f5c9743f-e77c-42f2-ba63-9843342cbf8e,36e63797-5a42-4779-a5cc-ef5c2e7d17d4,a4e51b6b-fdfd-47dc-9d0e-f26f383e03e9,\",\"AvatarItemType\":0,\"EquipmentPrefabName\":\"\",\"EquipmentModificationGuid\":\"\",\"IsQuery\":false,\"QueryRedirectContext\":null,\"QueryRedirectRarity\":null,\"Unique\":false,\"SubscribersOnly\":false,\"Rarity\":30,\"Context\":0,\"Currency\":0,\"CurrencyType\":0,\"ItemSetId\":null,\"ItemSetFriendlyName\":\"\"},\"PurchasableItemId\":44,\"Type\":0,\"Prices\":[{\"CurrencyType\":2,\"Price\":800,\"StorefrontSaleData\":null}],\"SubscriberPrices\":[{\"CurrencyType\":2,\"Price\":720,\"StorefrontSaleData\":null}],\"IsFeatured\":false,\"[...string is too long...]";
    private string amplitude = "{\"AmplitudeKey\":\"e1693a1003671058b6abc356c8ba8d59\"}";
    private string defaultunlocked = "[{\"AvatarItemDesc\":\"40528de7-38a3-4a7c-8f93-6d3bfa5573f2,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Headband (White)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"40528de7-38a3-4a7c-8f93-6d3bfa5573f2,8377ab96-c908-457f-9fee-b784c9a759f3,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Headband (Red)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"40528de7-38a3-4a7c-8f93-6d3bfa5573f2,f8b0cfe8-e129-4578-8bb5-f60af5d38599,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Headband (Green)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"40528de7-38a3-4a7c-8f93-6d3bfa5573f2,0ecb8a2a-cffc-47db-aeda-fb0684aef1e5,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Headband (Grey)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"40528de7-38a3-4a7c-8f93-6d3bfa5573f2,484b6c13-af22-4ad5-8c43-34c0de095d49,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Headband (Light Blue)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"40528de7-38a3-4a7c-8f93-6d3bfa5573f2,51ef8d39-2b94-4f9e-9620-07b6b0a913a5,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Headband (Orange)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"40528de7-38a3-4a7c-8f93-6d3bfa5573f2,cbe29e9f-f2ac-47fb-97e1-8bad16abb89d,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Headband (Pink)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"40528de7-38a3-4a7c-8f93-6d3bfa5573f2,dee70c38-7a99-4c2b-9181-665f1bf75aca,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Headband (Blue)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"40528de7-38a3-4a7c-8f93-6d3bfa5573f2,67bcca75-4ab1-4964-8688-9908c464d355,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Headband (Yellow)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"40528de7-38a3-4a7c-8f93-6d3bfa5573f2,8377ab96-c908-457f-9fee-b784c9a759f3,018a5c07-e956-457d-a540-a5e2cd68da09,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Headband (Red, White)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"14ef6b00-debf-4a85-9755-b4d37df496d3,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Baseball Cap (White)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"14ef6b00-debf-4a85-9755-b4d37df496d3,484b6c13-af22-4ad5-8c43-34c0de095d49,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Baseball Cap (Light Blue)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"14ef6b00-debf-4a85-9755-b4d37df496d3,67bcca75-4ab1-4964-8688-9908c464d355,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Baseball Cap (Yellow)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"14ef6b00-debf-4a85-9755-b4d37df496d3,51ef8d39-2b94-4f9e-9620-07b6b0a913a5,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Baseball Cap (Orange)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"09177621-9ecd-4f6a-b6a5-64490139141d,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Flat Top Hair\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"95ab7a7c-c35d-4da5-9955-0921064470b6,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Gekko Hair\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"8b9f1413-e786-4a30-946c-9292f207875a,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Pulp Hair\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"1a71064b-794f-40fa-9109-8ad36602b6e1,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Shagg Hair\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"45f5e714-8a5f-4385-a97f-675066167011,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Seventies Stache\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"5cd08cfb-c729-4c30-96d9-6a99bb934d91,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Rec Room Sash\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"6b9e022c-0b68-48fd-8eca-da8573c18900,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Long Scarf (Red)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"de0ac50d-2adb-4114-bd2e-68953b13d706,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Blazer (Blue, White)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"de0ac50d-2adb-4114-bd2e-68953b13d706,05ac07e1-67f0-486c-abf5-a62866475abb,be2b9293-1d3c-4b1c-b4c5-fad3ab16cf54,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Blazer (Black, Cream)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"de0ac50d-2adb-4114-bd2e-68953b13d706,272fe8eb-5061-4729-a7a8-414ff667a82f,be2b9293-1d3c-4b1c-b4c5-fad3ab16cf54,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Blazer (Grey, White)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"de0ac50d-2adb-4114-bd2e-68953b13d706,9374bf66-2ee5-493b-8439-efce4b201904,be2b9293-1d3c-4b1c-b4c5-fad3ab16cf54,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Blazer (Grey, Black)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"de0ac50d-2adb-4114-bd2e-68953b13d706,6f2e74bf-1e95-463d-97db-d5d1a53b2c28,be2b9293-1d3c-4b1c-b4c5-fad3ab16cf54,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Blazer (Black, White)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"de0ac50d-2adb-4114-bd2e-68953b13d706,0ffad843-d6c9-425a-8686-7217009c867e,be2b9293-1d3c-4b1c-b4c5-fad3ab16cf54,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Blazer (Green, Black)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"62ce4109-8dee-4895-bf1b-bfa143db4c7e,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Cardigan (Teal)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"9c8fc7f0-8f99-4aad-a34f-8d979f6ae352,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Button Top (Pink)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"9c8fc7f0-8f99-4aad-a34f-8d979f6ae352,49f5864f-9d40-497c-88c8-e87f64d41d74,dafa658e-753b-46cb-bd85-85c1de5e6ea7,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Button Top (Tan)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"9c8fc7f0-8f99-4aad-a34f-8d979f6ae352,e0397982-c2c2-4733-9a40-46e18675b5af,dafa658e-753b-46cb-bd85-85c1de5e6ea7,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Button Top (Orange)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"9c8fc7f0-8f99-4aad-a34f-8d979f6ae352,c5deba2a-6e35-4b13-8e94-8ba5457f39df,dafa658e-753b-46cb-bd85-85c1de5e6ea7,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Button Top (Yellow)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"896c2491-2f96-4986-9cbd-b3b31ef5d8c5,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Equestrian Coat (Black)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"896c2491-2f96-4986-9cbd-b3b31ef5d8c5,55901f12-d5b5-4fa8-b4c8-e479689ee39d,d344b8cc-85a8-4ace-9f92-38c84f396e99,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Equestrian Coat (Blue)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"896c2491-2f96-4986-9cbd-b3b31ef5d8c5,4828b50c-95b6-466a-bb25-514891d78202,d344b8cc-85a8-4ace-9f92-38c84f396e99,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Equestrian Coat (Grey)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"896c2491-2f96-4986-9cbd-b3b31ef5d8c5,d6823e01-69f0-4f85-b94a-74894356a2cf,d344b8cc-85a8-4ace-9f92-38c84f396e99,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Equestrian Coat (Maroon)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"6d815b35-6f68-4ed4-817d-70f141e1a571,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Collared Dress (Red)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"6d815b35-6f68-4ed4-817d-70f141e1a571,f750de46-3758-4f7d-9709-0a84b1027009,2c8924aa-68f8-4912-9759-18992f72f08a,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Collared Dress (Blue)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"6d815b35-6f68-4ed4-817d-70f141e1a571,d66aa400-aa5a-4539-a25d-5f8ce94dc281,2c8924aa-68f8-4912-9759-18992f72f08a,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Collared Dress (Green)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"6d815b35-6f68-4ed4-817d-70f141e1a571,6564acf1-4d70-4f92-92ac-08e2b76dbb6b,2c8924aa-68f8-4912-9759-18992f72f08a,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Collared Dress (Purple)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"84cd594c-1cd8-4b4d-8409-85c8fd5fb02a,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Stoll Dress (Pink)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"84cd594c-1cd8-4b4d-8409-85c8fd5fb02a,64850553-cdfe-455a-ac00-dafbe63d613e,91a451c1-b285-4c48-b14d-59ded8cc006f,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Stoll Dress (Orange)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"84cd594c-1cd8-4b4d-8409-85c8fd5fb02a,761a3193-60f0-4190-80c7-285b8192e794,91a451c1-b285-4c48-b14d-59ded8cc006f,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Stoll Dress (Blue)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"84cd594c-1cd8-4b4d-8409-85c8fd5fb02a,a819f49b-6c7a-49d3-9e6a-d9d79ef5019f,91a451c1-b285-4c48-b14d-59ded8cc006f,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Stoll Dress (Green)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"7b857a8c-92ad-4028-a2c2-b3c20cdab5f2,51ef8d39-2b94-4f9e-9620-07b6b0a913a5,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Tank Top (Orange)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"7b857a8c-92ad-4028-a2c2-b3c20cdab5f2,8377ab96-c908-457f-9fee-b784c9a759f3,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Tank Top (Red)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"7b857a8c-92ad-4028-a2c2-b3c20cdab5f2,dee70c38-7a99-4c2b-9181-665f1bf75aca,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Tank Top (Blue)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"7b857a8c-92ad-4028-a2c2-b3c20cdab5f2,1b1d08f2-12ca-43dd-a44f-ea2820b919b4,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Tank Top (Black)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"2296ed0d-df56-4d46-b33a-aae9230a47fc,bbfa08e3-8e6b-4e0f-b264-1b398d7cd44a,cfabdefe-0890-436e-b2a3-b5c712e22955,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Zipper Dress (White)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"2296ed0d-df56-4d46-b33a-aae9230a47fc,830be2fa-60a5-48cc-931f-34b670eae4bd,cfabdefe-0890-436e-b2a3-b5c712e22955,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Zipper Dress (Purple)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"2296ed0d-df56-4d46-b33a-aae9230a47fc,6d703981-2734-4c45-8983-cdd5f328902f,cfabdefe-0890-436e-b2a3-b5c712e22955,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Zipper Dress (Green)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"ecc1dbe6-ca06-4564-b2a6-30956194d1e9,67bcca75-4ab1-4964-8688-9908c464d355,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Wristbands (Yellow)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"ecc1dbe6-ca06-4564-b2a6-30956194d1e9,0ecb8a2a-cffc-47db-aeda-fb0684aef1e5,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Wristbands (Grey)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"ecc1dbe6-ca06-4564-b2a6-30956194d1e9,484b6c13-af22-4ad5-8c43-34c0de095d49,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Wristbands (Light Blue)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"ecc1dbe6-ca06-4564-b2a6-30956194d1e9,7d8e55fe-3c34-4b4b-9753-0021f6cc6454,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Wristbands (Cream)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"ecc1dbe6-ca06-4564-b2a6-30956194d1e9,f8b0cfe8-e129-4578-8bb5-f60af5d38599,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Wristbands (Green)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"71921831-ba6f-408b-a00e-2fd97663636f,7d8e55fe-3c34-4b4b-9753-0021f6cc6454,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Wrist Tape (Cream)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"71921831-ba6f-408b-a00e-2fd97663636f,1b1d08f2-12ca-43dd-a44f-ea2820b919b4,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Wrist Tape (Black)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"9bf5d259-7774-4cbe-a90f-7f188cc0dce7,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Thick Goatee\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"fcfcaf63-deb4-45f7-b711-c051c9ea45cb,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Top Bun Hair\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"241506f6-bf88-4b46-b5fe-513a225421f4,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Half Up Hair\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"6b9e022c-0b68-48fd-8eca-da8573c18900,d6edbc00-3c1d-4f49-8412-3ef8c7c5f4c2,cf119781-5bd9-4b85-9a0b-12e82e988c23,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Long Scarf (Blue)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"6b9e022c-0b68-48fd-8eca-da8573c18900,6dd95046-acf8-42fe-ab78-80a334096a9d,cf119781-5bd9-4b85-9a0b-12e82e988c23,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Long Scarf (White)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"6b9e022c-0b68-48fd-8eca-da8573c18900,5c4a2b35-0e1c-44de-8c3a-96d4a6458b1b,cf119781-5bd9-4b85-9a0b-12e82e988c23,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Long Scarf (Purple)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"62ce4109-8dee-4895-bf1b-bfa143db4c7e,ad61c418-6d77-4a99-8ac5-9f10f5a3d42f,0f36bb97-c61b-4281-929f-ff1d0d11be86,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Cardigan (Blue)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"62ce4109-8dee-4895-bf1b-bfa143db4c7e,cd5d7285-202d-42d0-b93f-04245875793e,0f36bb97-c61b-4281-929f-ff1d0d11be86,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Cardigan (Green)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"d84c0ff9-8fbe-4ed8-abf3-7996e81888ab,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Large Afro Hair\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"24a240f4-1574-420b-b898-a7e91f170759,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Back Bun Hair\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"c45ed7b8-99bd-4a4b-a9ff-e16edf5d7a18,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"High Pony Hair\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"e5b83dfc-b2e1-4dcb-a4ab-9d3a4c8a34ae,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Long Wavy Hair\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"7dd6f7b0-7ba0-429f-a04f-e32d3a79ee61,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Short Wavy Hair\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"eb9611c6-bb50-41a2-93e9-7f959815a846,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Dreads Long Hair\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"0088603e-ec3b-4478-8694-e6fb1989b3f2,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Angled Bob Hair\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"ffea7a65-613f-4835-921e-6dd15f357b7e,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Long Bangs Hair\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"40528de7-38a3-4a7c-8f93-6d3bfa5573f2,1b1d08f2-12ca-43dd-a44f-ea2820b919b4,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Headband (Black)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"40528de7-38a3-4a7c-8f93-6d3bfa5573f2,7d8e55fe-3c34-4b4b-9753-0021f6cc6454,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Headband (Cream)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"40528de7-38a3-4a7c-8f93-6d3bfa5573f2,dee70c38-7a99-4c2b-9181-665f1bf75aca,018a5c07-e956-457d-a540-a5e2cd68da09,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Headband (Blue, White)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"40528de7-38a3-4a7c-8f93-6d3bfa5573f2,cbe29e9f-f2ac-47fb-97e1-8bad16abb89d,018a5c07-e956-457d-a540-a5e2cd68da09,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Headband (Pink, White)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"40528de7-38a3-4a7c-8f93-6d3bfa5573f2,51ef8d39-2b94-4f9e-9620-07b6b0a913a5,018a5c07-e956-457d-a540-a5e2cd68da09,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Headband (Orange, White)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"40528de7-38a3-4a7c-8f93-6d3bfa5573f2,6dd95046-acf8-42fe-ab78-80a334096a9d,56a92c8d-af53-413e-929e-4a9a3cfad780,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Headband (Red, White, Blue)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"14ef6b00-debf-4a85-9755-b4d37df496d3,8377ab96-c908-457f-9fee-b784c9a759f3,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Baseball Cap (Red)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"14ef6b00-debf-4a85-9755-b4d37df496d3,dee70c38-7a99-4c2b-9181-665f1bf75aca,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Baseball Cap (Blue)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"2e59d8d0-91a0-4449-bfdc-a5d663fd9343,bf82f2f6-9af8-431e-a296-0890dea48ba7,d015cae7-a905-49e4-8823-6dec069689a6,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Collared Shirt (Argyle)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"2e59d8d0-91a0-4449-bfdc-a5d663fd9343,55901f12-d5b5-4fa8-b4c8-e479689ee39d,f600037d-c9c0-43fa-b45b-02f456f9dd5f,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Collared Shirt (Denim)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"8aa79563-ace1-4ba7-ad0c-f3210a78142f,95e4cc30-cb68-473d-a395-feadf5b51512,05f0ee6e-c824-470e-9178-5ed576c6fe0c,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Rec Room T-Shirt (V-Neck, Orange)\",\"Tooltip\":null,\"Rarity\":0},{\"AvatarItemDesc\":\"7b857a8c-92ad-4028-a2c2-b3c20cdab5f2,6d703981-2734-4c45-8983-cdd5f328902f,a0271cd0-e172-4d3f-aa2f-9806f21a82d2,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Tank Top (Camo)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"7b857a8c-92ad-4028-a2c2-b3c20cdab5f2,48abd952-214f-48b2-a8f1-1146f6f69aa2,b78008e8-abbd-4ece-be34-9a911f721fcc,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Tank Top (Zebra)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"7b857a8c-92ad-4028-a2c2-b3c20cdab5f2,ad61c418-6d77-4a99-8ac5-9f10f5a3d42f,b292eb4b-07e3-4a48-99b5-3c6587a1e02e,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Tank Top (Dots)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"7b857a8c-92ad-4028-a2c2-b3c20cdab5f2,5c4a2b35-0e1c-44de-8c3a-96d4a6458b1b,9c03f381-7357-4d0f-8cda-8737d4c43d25,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Tank Top (Rainbow)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"7b857a8c-92ad-4028-a2c2-b3c20cdab5f2,51ef8d39-2b94-4f9e-9620-07b6b0a913a5,d2a692e6-e1a9-4cfe-8154-10b52be7f8c8,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Jersey (Orange)\",\"Tooltip\":\"\",\"Rarity\":10},{\"AvatarItemDesc\":\"21caa68e-c3fa-474c-af5e-af1e742b7a60,c5deba2a-6e35-4b13-8e94-8ba5457f39df,b75ef67d-00c3-4ac1-9b72-212032460294,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Tennis Skirt (Yellow)\",\"Tooltip\":null,\"Rarity\":0},{\"AvatarItemDesc\":\"21caa68e-c3fa-474c-af5e-af1e742b7a60,758752bd-db2f-43d2-b580-55b3e1efffd5,b75ef67d-00c3-4ac1-9b72-212032460294,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Tennis Skirt (Red)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"ecc1dbe6-ca06-4564-b2a6-30956194d1e9,8377ab96-c908-457f-9fee-b784c9a759f3,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Wristbands (Red)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"ecc1dbe6-ca06-4564-b2a6-30956194d1e9,1b1d08f2-12ca-43dd-a44f-ea2820b919b4,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Wristbands (Black)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"ecc1dbe6-ca06-4564-b2a6-30956194d1e9,51ef8d39-2b94-4f9e-9620-07b6b0a913a5,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Wristbands (Orange)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"[...string is too long...]";
    private string gameconfig = "[{\"Key\":\"Screens.ForceVerification\",\"Value\":\"1\"},{\"Key\":\"Screens.ForceWaitlist\",\"Value\":\"false\"},{\"Key\":\"splitTestSoftOverrides\",\"Value\":\"\"},{\"Key\":\"Door.Creative.Query\",\"Value\":\"^CreativeCampus | ^RecRoomGallery \"},{\"Key\":\"Door.Creative.Title\",\"Value\":\"Creative Campus\"},{\"Key\":\"Door.Featured.Query\",\"Value\":\"#featured\"},{\"Key\":\"Door.Featured.Title\",\"Value\":\"Featured\"},{\"Key\":\"Door.Quests.Query\",\"Value\":\"#quest #rro\"},{\"Key\":\"Door.Quests.Title\",\"Value\":\"QUESTS\"},{\"Key\":\"Door.Shooters.Query\",\"Value\":\"^InkIncShoppingCenter\"},{\"Key\":\"Door.Shooters.Title\",\"Value\":\"Harmonica\"},{\"Key\":\"Door.Sports.Query\",\"Value\":\"#sport #rro | #pvp #rro\"},{\"Key\":\"Door.Sports.Title\",\"Value\":\"SPORTS & PVP\"},{\"Key\":\"Screens.ForceRegistrationPS4\",\"Value\":\"true\"},{\"Key\":\"splitTestHardOverrides\",\"Value\":\"IOSAppPermissions_2019_10_02=Immediate;GottaGoFastNUX_2020_09_04=Off;RecNetImageCacheRefCount_2020_09_18=On;Curated_Rooms_2020_08_06=On;PlayMenuRRUI_2021_01_11=On;PlayMenuRRUI_HotRoomsCarousel_2021_02_09=Off;PlayMenuRRUI_CarouselOrdering_2021_02_09=PlayMenuCarouselOrdering_1;CreationCommands_2021_02_16=Off;RecRoomPlus_DormMirrorButton_2021_03_09=ButtonOn;CurrentContestWinnersCarouselVisibility_2021_04_15=Off;Promo_Pack_2020_05_27=ShowPurchaseReminder_B;IOSLowHalfResolutionTextures_2021_05_14=Off;MutualFriends_2021_04_22=On;PlayMenuRRUI_DefaultTab_2021_05_13=Highlight;DefaultNewPlayersToPlayMenu_2021_05_24=On;ShowNewRRPlusIcon_2021_06_01=NewIcon;XboxHTTPWrapper_2021_06_10=Off;ParallelNetworkingInitialRoomLoad_2021_06_28=ParallelLoad;XboxHTTPWrapper_2021_06_30=On;ShowNewRRPlusBenefitsPage_2021_06_14=OldPage;WatchStoreHomepageLayout_2021_06_14=OldStoreLayout;NotificationPermissionsExplanationText_2021_06_25=Control;NotificationPermissionsSkipButton_2021_06_25=DeemphasizeSkipButton;NotificationPermissionsContextualPrompts_2021_06_25=Control;PlayHighlightCardSizes_2021_05_04=Off;PlayMenuRRUI_TopCreatorsCarousel_2021_09_01=Off;UseSets_2021_08_06=UseSets;NewChatUX_2021_08_25=On;FriendImportLogin_2021_09_23=Off;\"},{\"Key\":\"GASamplingRatio\",\"Value\":\"0.02\"},{\"Key\":\"splitTestsAvailable\",\"Value\":\"RoomRecommendations_2020_05_06=On,Off;Promo_Pack_2020_05_27=NoPurchaseReminder,ShowPurchaseReminder_A,ShowPurchaseReminder_B;Curated_Rooms_2020_08_06=Off,On;RecNetImageCacheRefCount_2020_09_18=On,Off;GottaGoFastNUX_2020_09_04=Off,On;Curated_Rooms_Tab_Placement_2020_09_22=First,Second;PhotonMaxDatagrams_2021_01_11=Off,On;PlayMenuRRUI_2021_01_11=Off,On;PlayMenuRRUI_HotRoomsCarousel_2021_02_09=Off,On;PlayMenuRRUI_CarouselOrdering_2021_02_09=PlayMenuCarouselOrdering_1,PlayMenuCarouselOrdering_2,PlayMenuCarouselOrdering_3;CreationCommands_2021_02_16=Off,On;RecRoomPlus_DormMirrorButton_2021_03_09=ButtonOn,ButtonOff;CurrentContestWinnersCarouselVisibility_2021_04_15=Off,On;MutualFriends_2021_04_22=Off,On;ProfileOnClick_2021_04_30=Off,On;PlayMenuRRUI_DefaultTab_2021_05_13=Highlight,RRO,Hot;PlayHighlightCardSizes_2021_05_04=Off,On;IOSLowHalfResolutionTextures_2021_05_14=Off,On;DefaultNewPlayersToPlayMenu_2021_05_24=Off,On;ShowNewRRPlusIcon_2021_06_01=OldIcon,NewIcon;ShowNewRRPlusBenefitsPage_2021_06_14=OldPage,NewPage;WatchStoreHomepageLayout_2021_06_14=OldStoreLayout,NewStoreLayout;NotificationPermissionsSkipButton_2021_06_25=Control,HideSkipButton,DeemphasizeSkipButton;NotificationPermissionsExplanationText_2021_06_25=Control,SpecificValueText;NotificationPermissionsContextualPrompts_2021_06_25=Control,ChatAction,EventAction;XboxHTTPWrapper_2021_06_10=On,Off;ParallelNetworkingInitialRoomLoad_2021_06_28=SequentialLoad,ParallelLoad;XboxHTTPWrapper_2021_06_30=On,Off;UseSets_2021_08_06=IgnoreSets,UseSets;NewChatUX_2021_08_25=Off,On;PlayMenuRRUI_TopCreatorsCarousel_2021_09_01=Off,On;FriendImportLogin_2021_09_23=Off,On;\"},{\"Key\":\"splitTestSegmentProbabilities\",\"Value\":\"{\\\"RoomRecommendations_2020_05_06\\\":[{\\\"SegmentName\\\":\\\"On\\\",\\\"Probability\\\":0.25},{\\\"SegmentName\\\":\\\"Off\\\",\\\"Probability\\\":0.75}],\\\"Promo_Pack_2020_05_27\\\":[{\\\"SegmentName\\\":\\\"NoPurchaseReminder\\\",\\\"Probability\\\":0.0},{\\\"SegmentName\\\":\\\"ShowPurchaseReminder_A\\\",\\\"Probability\\\":0.0},{\\\"SegmentName\\\":\\\"ShowPurchaseReminder_B\\\",\\\"Probability\\\":1.0}],\\\"CurrentContestWinnersCarouselVisibility_2021_04_15\\\":[{\\\"SegmentName\\\":\\\"Off\\\",\\\"Probability\\\":1.0},{\\\"SegmentName\\\":\\\"On\\\",\\\"Probability\\\":0.0}],\\\"PlayHighlightCardSizes_2021_05_04\\\":[{\\\"SegmentName\\\":\\\"Off\\\",\\\"Probability\\\":1.0},{\\\"SegmentName\\\":\\\"On\\\",\\\"Probability\\\":0.0}],\\\"NotificationPermissionsSkipButton_2021_06_25\\\":[{\\\"SegmentName\\\":\\\"Control\\\",\\\"Probability\\\":0.333333343},{\\\"SegmentName\\\":\\\"HideSkipButton\\\",\\\"Probability\\\":0.333333343},{\\\"SegmentName\\\":\\\"DeemphasizeSkipButton\\\",\\\"Probability\\\":0.333333343}],\\\"NotificationPermissionsContextualPrompts_2021_06_25\\\":[{\\\"SegmentName\\\":\\\"Control\\\",\\\"Probability\\\":0.333333343},{\\\"SegmentName\\\":\\\"ChatAction\\\",\\\"Probability\\\":0.333333343},{\\\"SegmentName\\\":\\\"EventAction\\\",\\\"Probability\\\":0.333333343}],\\\"NewChatUX_2021_08_25\\\":[{\\\"SegmentName\\\":\\\"Off\\\",\\\"Probability\\\":0.5},{\\\"SegmentName\\\":\\\"On\\\",\\\"Probability\\\":0.5}]}\"},{\"Key\":\"Friends.PostGamePromptUnderFriendCount\",\"Value\":\"10\"},{\"Key\":\"Friends.SuggestFriendCodeOnFriendsScreenCount\",\"Value\":\"25\"},{\"Key\":\"runningNetworkTimeout\",\"Value\":\"30\"},{\"Key\":\"loadingNetworkTimeout\",\"Value\":\"180\"},{\"Key\":\"Rewards.SelectionTimeout\",\"Value\":\"1800\"},{\"Key\":\"Rewards.UseRewardSelection\",\"Value\":\"true\"},{\"Key\":\"RoomDetails.PhotoRollEnabled\",\"Value\":\"true\"},{\"Key\":\"Rendering.DisableSrpBatcher\",\"Value\":\"#5-5-0#\"},{\"Key\":\"Backtrace.config\",\"Value\":\"0|0|0|0|0|0|0|0|0\"},{\"Key\":\"Backtrace.enabledLikelihood\",\"Value\":\"0.0|0.0|0.0|0.0|0.0|0.0|0.0\"},{\"Key\":\"RoomScaleMotionCheatDetector.MinHmdSpeedAboveTriggerCount\",\"Value\":\"6\"},{\"Key\":\"RoomScaleMotionCheatDetector.ShouldBootToDormWhenDetected.PlayStation\",\"Value\":\"false\"},{\"Key\":\"RoomScaleMotionCheatDetector.ShouldBootToDormWhenDetected.Steam\",\"Value\":\"true\"},{\"Key\":\"RoomScaleMotionCheatDetector.ShouldBootToDormWhenDetected.Oculus\",\"Value\":\"true\"},{\"Key\":\"PlayMenuCarouselOrdering_3\",\"Value\":\"hiddenworldscontest=11;mysubscriptions=10;continueplaying=9;friendsplaying=8;myclubhouses=7;myevents=6;staffcurated=5;discoverability=4;topcreators=4;hotrooms=3\"},{\"Key\":\"PlayMenuCarouselOrdering_2\",\"Value\":\"hiddenworldscontest=11;topcreators=10;discoverability=10;hotrooms=9;continueplaying=8;friendsplaying=7;myclubhouses=6;myevents=5;mysubscriptions=4;staffcurated=3\"},{\"Key\":\"PlayMenuCarouselOrdering_1\",\"Value\":\"hiddenworldscontest=11;friendsplaying=10;mysubscriptions=9;continueplaying=8;topcreators=7;discoverability=6;myclubhouses=5;staffcurated=4;myevents=3;hotrooms=0\"},{\"Key\":\"Backtrace.versionRegex\",\"Value\":\"^20160931\"},{\"Key\":\"Backtrace.messageRegex\",\"Value\":\"^Cannot set the parent of the GameObject .* while its new parent|^\\\\>\\\\x2010x\\\\:\\\\x20\"},{\"Key\":\"RoomScaleMotionCheatDetector.MaxAllowedAverageHmdSpeed\",\"Value\":\"3\"},{\"Key\":\"RoomScaleMotionCheatDetector.MeasurementPeriodInSeconds\",\"Value\":\"1\"},{\"Key\":\"RoomScaleMotionCheatDetector.TriggerHmdSpeed\",\"Value\":\"3\"},{\"Key\":\"GDK_Enable_RRPlus\",\"Value\":\"true\"},{\"Key\":\"ClickOnName.MaxRaycastDistance\",\"Value\":\"3.25\"},{\"Key\":\"Door.StuntRunner.Title\",\"Value\":\"COMMUNITY\"},{\"Key\":\"Door.StuntRunner.Query\",\"Value\":\"#stuntrunner #community\"},{\"Key\":\"UGC.EnableRRUIConfigMenu\",\"Value\":\"true\"},{\"Key\":\"Growth.EnableProfilePhoneButton\",\"Value\":\"true\"},{\"Key\":\"Growth.FriendFestPromosActive\",\"Value\":\"false\"},{\"Key\":\"Backtrace.stopTimeUTC\",\"Value\":\"2021-09-30 21:00\"},{\"Key\":\"OldStoreLayout\",\"Value\":\"banner=9;hotitem=8;hotinvention=7;newitem=6;mysubscriptioninvention=5;rrplusitem=4;fivestaritem=3;skinsitem=2;hairdyeitem=1;\"},{\"Key\":\"NewStoreLayout\",\"Value\":\"banner=9;hotitem=7;hotinvention=8;newitem=6;mysubscriptioninvention=5;rrplusitem=4;fivestaritem=3;skinsitem=2;hairdyeitem=1;\"},{\"Key\":\"UGC.ForbiddenSavedSpawnableTools\",\"Value\":\"\"},{\"Key\":\"MobileNotifications.UseFirebasePushNotifications\",\"Value\":\"false\"},{\"Key\":\"UGC.MaxChipsVisible\",\"Value\":\"1000\",\"StartTime\":\"2021-07-21T23:50:00Z\"},{\"Key\":\"UGC.MaxChipsUnculled\",\"Value\":\"500\",\"StartTime\":\"2021-07-21T23:51:23Z\"},{\"Key\":\"MagicDoor.NewDestinationText\",\"Value\":\"Magic Door\",\"StartTime\":\"2021-07-21T23:58:09Z\"},{\"Key\":\"UGC.Persistence.Enabled\",\"Value\":\"false\",\"StartTime\":\"2021-07-22T00:11:16Z\"},{\"Key\":\"UGC.Persistence.AutosaveIntervalSeconds\",\"Value\":\"300\",\"StartTime\":\"2021-07-22T00:13:54Z\"},{\"Key\":\"MagicDoor.DestinationRefreshingText\",\"Value\":\"New Room in\"},{\"Key\":\"CannedChatAnalyticsSampleRate\",\"Value\":\".25\"},{\"Key\":\"UGC.CV2.CooldownBeforeSubscriptionCheckSeconds\",\"Value\":\"240\"},{\"Key\":\"RRUI.UseRRUIHomeScreen\",\"Value\":\"false\"},{\"Key\":\"SafePlaySFXAudioSourceSounds\",\"Value\":\"true\"},{\"Key\":\"UGC.ScreenSharing.EnabledForMultiInstanceEvents\",\"Value\":\"true\"},{\"Key\":\"UGC.ScreenSharing.CompressionQualityMultiplier\",\"Value\":\"1.0\"},{\"Key\":\"UGC.ScreenSharing.EnableZipCompression\",\"Value\":\"true\"},{\"Key\":\"UGC.ScreenSharing.MaxFragmentBytes\",\"Value\":\"15360\"},{\"Key\":\"UGC.ScreenSharing.RefreshHzMultiplier\",\"Value\":\"60.0\"},{\"Key\":\"UGC.ScreenSharing.ResolutionMultiplier\",\"Value\":\"1.0\"},{\"Key\":\"BroadcastManager.VoiceRolloffMaxDistance\",\"Value\":\"500\"},{\"Key\":\"BroadcastManager.IsRoomChatBroadcastSupported\",\"Value\":\"true\"},{\"Key\":\"BroadcastManager.RoomChatMaxMessagesPerTrackingPeriod\",\"Value\":\"1\"}]";
    private string avatar_v2 = "{\"OutfitSelections\":\"2c679f89-c76e-4cfb-94e9-448c8fd44d55,,,,0;de0ac50d-2adb-4114-bd2e-68953b13d706,05ac07e1-67f0-486c-abf5-a62866475abb,be2b9293-1d3c-4b1c-b4c5-fad3ab16cf54,,1;ecc1dbe6-ca06-4564-b2a6-30956194d1e9,1b1d08f2-12ca-43dd-a44f-ea2820b919b4,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,,2;ecc1dbe6-ca06-4564-b2a6-30956194d1e9,1b1d08f2-12ca-43dd-a44f-ea2820b919b4,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,,3;c6c08eb5-381a-4193-9722-80da95d62abe,,,,1\",\"FaceFeatures\":\"{\\\"ver\\\":5,\\\"eyeId\\\":\\\"AjGMoJhEcEehacRZjUMuDg\\\",\\\"eyePos\\\":{\\\"x\\\":0.0,\\\"y\\\":0.0},\\\"eyeScl\\\":0.0,\\\"mouthId\\\":\\\"FrZBRanXEEK29yKJ4jiMjg\\\",\\\"mouthPos\\\":{\\\"x\\\":0.0,\\\"y\\\":0.0},\\\"mouthScl\\\":0.0,\\\"hairPrimaryColorId\\\":\\\"\\\",\\\"hairSecondaryColorId\\\":\\\"81_c6R0my0qK9hYM_0a7LQ\\\",\\\"hairPatternId\\\":\\\"\\\",\\\"beardColorId\\\":\\\"81_c6R0my0qK9hYM_0a7LQ\\\",\\\"beardSecondaryColorId\\\":\\\"81_c6R0my0qK9hYM_0a7LQ\\\",\\\"beardPatternId\\\":\\\"\\\",\\\"faceShapeId\\\":\\\"yR4oYZr_AUSynXCgwS2lGw\\\",\\\"bodyShapeId\\\":\\\"bY1RGIph0kiAxbd6Shn9tQ\\\",\\\"useHatAnchorParams\\\":true,\\\"hideEars\\\":false,\\\"hatAnchorParams\\\":{\\\"NormalizedPosition\\\":{\\\"x\\\":0.5,\\\"y\\\":0.5},\\\"HemisphereOffsets\\\":{\\\"x\\\":0.0,\\\"y\\\":0.0,\\\"z\\\":0.0},\\\"HemisphereRotations\\\":{\\\"x\\\":0.0,\\\"y\\\":0.0,\\\"z\\\":0.0}}}\",\"SkinColor\":\"f61ff837-bed9-41bb-a0f6-64b80f33e75d\",\"HairColor\":\"81_c6R0my0qK9hYM_0a7LQ\"}";
    private string items = "[{\"AvatarItemDesc\":\"40528de7-38a3-4a7c-8f93-6d3bfa5573f2,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Headband (White)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"40528de7-38a3-4a7c-8f93-6d3bfa5573f2,8377ab96-c908-457f-9fee-b784c9a759f3,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Headband (Red)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"40528de7-38a3-4a7c-8f93-6d3bfa5573f2,f8b0cfe8-e129-4578-8bb5-f60af5d38599,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Headband (Green)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"40528de7-38a3-4a7c-8f93-6d3bfa5573f2,0ecb8a2a-cffc-47db-aeda-fb0684aef1e5,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Headband (Grey)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"40528de7-38a3-4a7c-8f93-6d3bfa5573f2,484b6c13-af22-4ad5-8c43-34c0de095d49,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Headband (Light Blue)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"40528de7-38a3-4a7c-8f93-6d3bfa5573f2,51ef8d39-2b94-4f9e-9620-07b6b0a913a5,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Headband (Orange)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"40528de7-38a3-4a7c-8f93-6d3bfa5573f2,cbe29e9f-f2ac-47fb-97e1-8bad16abb89d,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Headband (Pink)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"40528de7-38a3-4a7c-8f93-6d3bfa5573f2,dee70c38-7a99-4c2b-9181-665f1bf75aca,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Headband (Blue)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"40528de7-38a3-4a7c-8f93-6d3bfa5573f2,67bcca75-4ab1-4964-8688-9908c464d355,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Headband (Yellow)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"40528de7-38a3-4a7c-8f93-6d3bfa5573f2,8377ab96-c908-457f-9fee-b784c9a759f3,018a5c07-e956-457d-a540-a5e2cd68da09,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Headband (Red, White)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"14ef6b00-debf-4a85-9755-b4d37df496d3,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Baseball Cap (White)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"14ef6b00-debf-4a85-9755-b4d37df496d3,484b6c13-af22-4ad5-8c43-34c0de095d49,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Baseball Cap (Light Blue)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"14ef6b00-debf-4a85-9755-b4d37df496d3,67bcca75-4ab1-4964-8688-9908c464d355,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Baseball Cap (Yellow)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"14ef6b00-debf-4a85-9755-b4d37df496d3,51ef8d39-2b94-4f9e-9620-07b6b0a913a5,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Baseball Cap (Orange)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"09177621-9ecd-4f6a-b6a5-64490139141d,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Flat Top Hair\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"95ab7a7c-c35d-4da5-9955-0921064470b6,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Gekko Hair\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"8b9f1413-e786-4a30-946c-9292f207875a,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Pulp Hair\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"1a71064b-794f-40fa-9109-8ad36602b6e1,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Shagg Hair\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"45f5e714-8a5f-4385-a97f-675066167011,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Seventies Stache\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"5cd08cfb-c729-4c30-96d9-6a99bb934d91,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Rec Room Sash\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"6b9e022c-0b68-48fd-8eca-da8573c18900,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Long Scarf (Red)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"de0ac50d-2adb-4114-bd2e-68953b13d706,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Blazer (Blue, White)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"de0ac50d-2adb-4114-bd2e-68953b13d706,05ac07e1-67f0-486c-abf5-a62866475abb,be2b9293-1d3c-4b1c-b4c5-fad3ab16cf54,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Blazer (Black, Cream)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"de0ac50d-2adb-4114-bd2e-68953b13d706,272fe8eb-5061-4729-a7a8-414ff667a82f,be2b9293-1d3c-4b1c-b4c5-fad3ab16cf54,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Blazer (Grey, White)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"de0ac50d-2adb-4114-bd2e-68953b13d706,9374bf66-2ee5-493b-8439-efce4b201904,be2b9293-1d3c-4b1c-b4c5-fad3ab16cf54,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Blazer (Grey, Black)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"de0ac50d-2adb-4114-bd2e-68953b13d706,6f2e74bf-1e95-463d-97db-d5d1a53b2c28,be2b9293-1d3c-4b1c-b4c5-fad3ab16cf54,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Blazer (Black, White)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"de0ac50d-2adb-4114-bd2e-68953b13d706,0ffad843-d6c9-425a-8686-7217009c867e,be2b9293-1d3c-4b1c-b4c5-fad3ab16cf54,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Blazer (Green, Black)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"62ce4109-8dee-4895-bf1b-bfa143db4c7e,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Cardigan (Teal)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"9c8fc7f0-8f99-4aad-a34f-8d979f6ae352,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Button Top (Pink)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"9c8fc7f0-8f99-4aad-a34f-8d979f6ae352,49f5864f-9d40-497c-88c8-e87f64d41d74,dafa658e-753b-46cb-bd85-85c1de5e6ea7,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Button Top (Tan)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"9c8fc7f0-8f99-4aad-a34f-8d979f6ae352,e0397982-c2c2-4733-9a40-46e18675b5af,dafa658e-753b-46cb-bd85-85c1de5e6ea7,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Button Top (Orange)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"9c8fc7f0-8f99-4aad-a34f-8d979f6ae352,c5deba2a-6e35-4b13-8e94-8ba5457f39df,dafa658e-753b-46cb-bd85-85c1de5e6ea7,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Button Top (Yellow)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"896c2491-2f96-4986-9cbd-b3b31ef5d8c5,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Equestrian Coat (Black)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"896c2491-2f96-4986-9cbd-b3b31ef5d8c5,55901f12-d5b5-4fa8-b4c8-e479689ee39d,d344b8cc-85a8-4ace-9f92-38c84f396e99,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Equestrian Coat (Blue)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"896c2491-2f96-4986-9cbd-b3b31ef5d8c5,4828b50c-95b6-466a-bb25-514891d78202,d344b8cc-85a8-4ace-9f92-38c84f396e99,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Equestrian Coat (Grey)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"896c2491-2f96-4986-9cbd-b3b31ef5d8c5,d6823e01-69f0-4f85-b94a-74894356a2cf,d344b8cc-85a8-4ace-9f92-38c84f396e99,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Equestrian Coat (Maroon)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"6d815b35-6f68-4ed4-817d-70f141e1a571,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Collared Dress (Red)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"6d815b35-6f68-4ed4-817d-70f141e1a571,f750de46-3758-4f7d-9709-0a84b1027009,2c8924aa-68f8-4912-9759-18992f72f08a,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Collared Dress (Blue)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"6d815b35-6f68-4ed4-817d-70f141e1a571,d66aa400-aa5a-4539-a25d-5f8ce94dc281,2c8924aa-68f8-4912-9759-18992f72f08a,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Collared Dress (Green)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"6d815b35-6f68-4ed4-817d-70f141e1a571,6564acf1-4d70-4f92-92ac-08e2b76dbb6b,2c8924aa-68f8-4912-9759-18992f72f08a,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Collared Dress (Purple)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"84cd594c-1cd8-4b4d-8409-85c8fd5fb02a,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Stoll Dress (Pink)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"84cd594c-1cd8-4b4d-8409-85c8fd5fb02a,64850553-cdfe-455a-ac00-dafbe63d613e,91a451c1-b285-4c48-b14d-59ded8cc006f,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Stoll Dress (Orange)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"84cd594c-1cd8-4b4d-8409-85c8fd5fb02a,761a3193-60f0-4190-80c7-285b8192e794,91a451c1-b285-4c48-b14d-59ded8cc006f,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Stoll Dress (Blue)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"84cd594c-1cd8-4b4d-8409-85c8fd5fb02a,a819f49b-6c7a-49d3-9e6a-d9d79ef5019f,91a451c1-b285-4c48-b14d-59ded8cc006f,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Stoll Dress (Green)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"7b857a8c-92ad-4028-a2c2-b3c20cdab5f2,51ef8d39-2b94-4f9e-9620-07b6b0a913a5,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Tank Top (Orange)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"7b857a8c-92ad-4028-a2c2-b3c20cdab5f2,8377ab96-c908-457f-9fee-b784c9a759f3,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Tank Top (Red)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"7b857a8c-92ad-4028-a2c2-b3c20cdab5f2,dee70c38-7a99-4c2b-9181-665f1bf75aca,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Tank Top (Blue)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"7b857a8c-92ad-4028-a2c2-b3c20cdab5f2,1b1d08f2-12ca-43dd-a44f-ea2820b919b4,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Tank Top (Black)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"2296ed0d-df56-4d46-b33a-aae9230a47fc,bbfa08e3-8e6b-4e0f-b264-1b398d7cd44a,cfabdefe-0890-436e-b2a3-b5c712e22955,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Zipper Dress (White)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"2296ed0d-df56-4d46-b33a-aae9230a47fc,830be2fa-60a5-48cc-931f-34b670eae4bd,cfabdefe-0890-436e-b2a3-b5c712e22955,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Zipper Dress (Purple)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"2296ed0d-df56-4d46-b33a-aae9230a47fc,6d703981-2734-4c45-8983-cdd5f328902f,cfabdefe-0890-436e-b2a3-b5c712e22955,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Zipper Dress (Green)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"ecc1dbe6-ca06-4564-b2a6-30956194d1e9,67bcca75-4ab1-4964-8688-9908c464d355,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Wristbands (Yellow)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"ecc1dbe6-ca06-4564-b2a6-30956194d1e9,0ecb8a2a-cffc-47db-aeda-fb0684aef1e5,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Wristbands (Grey)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"ecc1dbe6-ca06-4564-b2a6-30956194d1e9,484b6c13-af22-4ad5-8c43-34c0de095d49,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Wristbands (Light Blue)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"ecc1dbe6-ca06-4564-b2a6-30956194d1e9,7d8e55fe-3c34-4b4b-9753-0021f6cc6454,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Wristbands (Cream)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"ecc1dbe6-ca06-4564-b2a6-30956194d1e9,f8b0cfe8-e129-4578-8bb5-f60af5d38599,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Wristbands (Green)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"71921831-ba6f-408b-a00e-2fd97663636f,7d8e55fe-3c34-4b4b-9753-0021f6cc6454,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Wrist Tape (Cream)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"71921831-ba6f-408b-a00e-2fd97663636f,1b1d08f2-12ca-43dd-a44f-ea2820b919b4,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Wrist Tape (Black)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"9bf5d259-7774-4cbe-a90f-7f188cc0dce7,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Thick Goatee\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"fcfcaf63-deb4-45f7-b711-c051c9ea45cb,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Top Bun Hair\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"241506f6-bf88-4b46-b5fe-513a225421f4,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Half Up Hair\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"6b9e022c-0b68-48fd-8eca-da8573c18900,d6edbc00-3c1d-4f49-8412-3ef8c7c5f4c2,cf119781-5bd9-4b85-9a0b-12e82e988c23,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Long Scarf (Blue)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"6b9e022c-0b68-48fd-8eca-da8573c18900,6dd95046-acf8-42fe-ab78-80a334096a9d,cf119781-5bd9-4b85-9a0b-12e82e988c23,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Long Scarf (White)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"6b9e022c-0b68-48fd-8eca-da8573c18900,5c4a2b35-0e1c-44de-8c3a-96d4a6458b1b,cf119781-5bd9-4b85-9a0b-12e82e988c23,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Long Scarf (Purple)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"62ce4109-8dee-4895-bf1b-bfa143db4c7e,ad61c418-6d77-4a99-8ac5-9f10f5a3d42f,0f36bb97-c61b-4281-929f-ff1d0d11be86,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Cardigan (Blue)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"62ce4109-8dee-4895-bf1b-bfa143db4c7e,cd5d7285-202d-42d0-b93f-04245875793e,0f36bb97-c61b-4281-929f-ff1d0d11be86,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Cardigan (Green)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"d84c0ff9-8fbe-4ed8-abf3-7996e81888ab,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Large Afro Hair\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"24a240f4-1574-420b-b898-a7e91f170759,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Back Bun Hair\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"c45ed7b8-99bd-4a4b-a9ff-e16edf5d7a18,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"High Pony Hair\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"e5b83dfc-b2e1-4dcb-a4ab-9d3a4c8a34ae,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Long Wavy Hair\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"7dd6f7b0-7ba0-429f-a04f-e32d3a79ee61,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Short Wavy Hair\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"eb9611c6-bb50-41a2-93e9-7f959815a846,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Dreads Long Hair\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"0088603e-ec3b-4478-8694-e6fb1989b3f2,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Angled Bob Hair\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"ffea7a65-613f-4835-921e-6dd15f357b7e,,,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Long Bangs Hair\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"40528de7-38a3-4a7c-8f93-6d3bfa5573f2,1b1d08f2-12ca-43dd-a44f-ea2820b919b4,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Headband (Black)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"40528de7-38a3-4a7c-8f93-6d3bfa5573f2,7d8e55fe-3c34-4b4b-9753-0021f6cc6454,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Headband (Cream)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"40528de7-38a3-4a7c-8f93-6d3bfa5573f2,dee70c38-7a99-4c2b-9181-665f1bf75aca,018a5c07-e956-457d-a540-a5e2cd68da09,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Headband (Blue, White)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"40528de7-38a3-4a7c-8f93-6d3bfa5573f2,cbe29e9f-f2ac-47fb-97e1-8bad16abb89d,018a5c07-e956-457d-a540-a5e2cd68da09,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Headband (Pink, White)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"40528de7-38a3-4a7c-8f93-6d3bfa5573f2,51ef8d39-2b94-4f9e-9620-07b6b0a913a5,018a5c07-e956-457d-a540-a5e2cd68da09,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Headband (Orange, White)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"40528de7-38a3-4a7c-8f93-6d3bfa5573f2,6dd95046-acf8-42fe-ab78-80a334096a9d,56a92c8d-af53-413e-929e-4a9a3cfad780,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Headband (Red, White, Blue)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"14ef6b00-debf-4a85-9755-b4d37df496d3,8377ab96-c908-457f-9fee-b784c9a759f3,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Baseball Cap (Red)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"14ef6b00-debf-4a85-9755-b4d37df496d3,dee70c38-7a99-4c2b-9181-665f1bf75aca,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Baseball Cap (Blue)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"2e59d8d0-91a0-4449-bfdc-a5d663fd9343,bf82f2f6-9af8-431e-a296-0890dea48ba7,d015cae7-a905-49e4-8823-6dec069689a6,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Collared Shirt (Argyle)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"2e59d8d0-91a0-4449-bfdc-a5d663fd9343,55901f12-d5b5-4fa8-b4c8-e479689ee39d,f600037d-c9c0-43fa-b45b-02f456f9dd5f,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Collared Shirt (Denim)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"8aa79563-ace1-4ba7-ad0c-f3210a78142f,95e4cc30-cb68-473d-a395-feadf5b51512,05f0ee6e-c824-470e-9178-5ed576c6fe0c,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Rec Room T-Shirt (V-Neck, Orange)\",\"Tooltip\":null,\"Rarity\":0},{\"AvatarItemDesc\":\"7b857a8c-92ad-4028-a2c2-b3c20cdab5f2,6d703981-2734-4c45-8983-cdd5f328902f,a0271cd0-e172-4d3f-aa2f-9806f21a82d2,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Tank Top (Camo)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"7b857a8c-92ad-4028-a2c2-b3c20cdab5f2,48abd952-214f-48b2-a8f1-1146f6f69aa2,b78008e8-abbd-4ece-be34-9a911f721fcc,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Tank Top (Zebra)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"7b857a8c-92ad-4028-a2c2-b3c20cdab5f2,ad61c418-6d77-4a99-8ac5-9f10f5a3d42f,b292eb4b-07e3-4a48-99b5-3c6587a1e02e,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Tank Top (Dots)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"7b857a8c-92ad-4028-a2c2-b3c20cdab5f2,5c4a2b35-0e1c-44de-8c3a-96d4a6458b1b,9c03f381-7357-4d0f-8cda-8737d4c43d25,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Tank Top (Rainbow)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"7b857a8c-92ad-4028-a2c2-b3c20cdab5f2,51ef8d39-2b94-4f9e-9620-07b6b0a913a5,d2a692e6-e1a9-4cfe-8154-10b52be7f8c8,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Jersey (Orange)\",\"Tooltip\":\"\",\"Rarity\":10},{\"AvatarItemDesc\":\"21caa68e-c3fa-474c-af5e-af1e742b7a60,c5deba2a-6e35-4b13-8e94-8ba5457f39df,b75ef67d-00c3-4ac1-9b72-212032460294,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Tennis Skirt (Yellow)\",\"Tooltip\":null,\"Rarity\":0},{\"AvatarItemDesc\":\"21caa68e-c3fa-474c-af5e-af1e742b7a60,758752bd-db2f-43d2-b580-55b3e1efffd5,b75ef67d-00c3-4ac1-9b72-212032460294,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Tennis Skirt (Red)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"ecc1dbe6-ca06-4564-b2a6-30956194d1e9,8377ab96-c908-457f-9fee-b784c9a759f3,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Wristbands (Red)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"ecc1dbe6-ca06-4564-b2a6-30956194d1e9,1b1d08f2-12ca-43dd-a44f-ea2820b919b4,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Wristbands (Black)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"ecc1dbe6-ca06-4564-b2a6-30956194d1e9,51ef8d39-2b94-4f9e-9620-07b6b0a913a5,0b2395e1-ebcc-47e9-aaf1-faf9e9cec4cd,\",\"AvatarItemType\":0,\"PlatformMask\":-1,\"FriendlyName\":\"Wristbands (Orange)\",\"Tooltip\":\"\",\"Rarity\":0},{\"AvatarItemDesc\":\"[...string is too long...]";

    public APIServer2()
    {
      try
      {
        if (Config.LogMessages)
          Console.WriteLine("[APIServer2] has started.");
        new Thread(new ThreadStart(this.StartListen)).Start();
      }
      catch (Exception ex)
      {
        Console.WriteLine("An Exception Occurred while Listening :" + ex.ToString());
      }
    }

    private bool ExecutePostCommand(
      string url,
      string xrnsig,
      string auth,
      string identity,
      string user)
    {
      RestRequest request = new RestRequest(url, Method.POST);
      request.AddHeader("X-RNSIG", xrnsig);
      request.AddHeader("Authorization", auth);
      request.AddHeader("Te", identity);
      request.AddHeader("User-Agent", user);
      return this.ExecuteRNRequest<bool>(request, (Func<string, bool>) (responseBody => true));
    }

    private static byte[] MultiFormSplit(byte[] data)
    {
      using (BinaryReader binaryReader = new BinaryReader((Stream) new MemoryStream(data)))
      {
        while (binaryReader.BaseStream.Position != binaryReader.BaseStream.Length)
        {
          bool flag1 = true;
          bool flag2 = false;
          APIServer2.MultiFormData multiFormData = new APIServer2.MultiFormData();
          while (flag1)
          {
            List<byte> byteList = new List<byte>();
            bool flag3 = true;
            while (flag3)
            {
              byte num1 = binaryReader.ReadByte();
              if (binaryReader.BaseStream.Position != binaryReader.BaseStream.Length)
              {
                if (num1 == (byte) 13)
                {
                  int num2 = (int) binaryReader.ReadByte();
                  flag3 = false;
                }
                else
                  byteList.Add(num1);
              }
              else
                flag3 = false;
            }
            string str = Encoding.ASCII.GetString(byteList.ToArray());
            if (str.StartsWith("Content-Length: "))
            {
              string s = str.Remove(0, 16);
              multiFormData.ContentLength = int.Parse(s);
            }
            if (str.Contains("image.dat"))
              flag2 = true;
            str.Contains("{\"");
            if (binaryReader.BaseStream.Position != binaryReader.BaseStream.Length)
            {
              if (binaryReader.ReadByte() == (byte) 13)
              {
                flag1 = false;
                int num = (int) binaryReader.ReadByte();
              }
              else
                --binaryReader.BaseStream.Position;
            }
            else
              flag1 = false;
          }
          if (flag2)
            return binaryReader.ReadBytes(multiFormData.ContentLength);
          if (binaryReader.BaseStream.Position != binaryReader.BaseStream.Length)
            binaryReader.ReadBytes(multiFormData.ContentLength);
        }
      }
      return (byte[]) null;
    }

    private T ExecuteRNRequest<T>(RestRequest request, Func<string, T> parser)
    {
      IRestResponse restResponse = new RestClient("https://api.rec.net").Execute((IRestRequest) request);
      switch (restResponse.ResponseStatus)
      {
        case ResponseStatus.Completed:
          if (restResponse.StatusCode == HttpStatusCode.OK)
          {
            try
            {
              return parser(restResponse.Content);
            }
            catch
            {
              Console.WriteLine("ERROR: Malformed login response");
              break;
            }
          }
          else
          {
            Console.WriteLine("ERROR: " + (object) restResponse.StatusCode + " " + restResponse.StatusDescription);
            break;
          }
        case ResponseStatus.Error:
          Console.WriteLine("ERROR: " + restResponse.ErrorMessage);
          break;
        case ResponseStatus.TimedOut:
          Console.WriteLine("ERROR: Timed out trying to contact RecNet servers");
          break;
        default:
          Console.WriteLine("ERROR: Unknown error occurred");
          break;
      }
      return default (T);
    }

    public string ProcessRequest(
      string rawUrl,
      HttpListenerContext context,
      HttpListenerRequest request,
      HttpListenerResponse response,
      string postData)
    {
      string str1 = "";
      try
      {
        List<byte> byteList = new List<byte>();
        Stream inputStream = request.InputStream;
        for (int index = inputStream.ReadByte(); index != -1; index = inputStream.ReadByte())
          byteList.Add((byte) index);
        this.postData = Encoding.ASCII.GetString(byteList.ToArray());
        Console.ForegroundColor = ConsoleColor.Magenta;
        NameValueCollection headers1 = request.Headers;
        string str2 = "";
        for (int index = 0; index < request.Headers.Count; ++index)
        {
          string key = headers1.GetKey(index);
          if (key == "Authorization")
            APIServer2.auth = headers1.GetValues("Authorization")[0];
          if (key == "X-RNSIG")
            str2 = headers1.GetValues(key)[0];
        }
        Console.WriteLine("============== HTTP Request was sent! ==============\n" + ("URI: " + rawUrl + "\n") + ("Method: " + request.HttpMethod + "\n") + ("Auth: " + APIServer2.auth + "\n") + ("Sender: " + context.Request.RemoteEndPoint.ToString() + "\n") + ("Post Data: " + postData + "\n") + "====================================================\n");
        try
        {
          if (rawUrl.StartsWith("/api/versioncheck/"))
          {
            Logger.UserPrefs.AddPref("has_called_version_check", "1");
            if (rawUrl.StartsWith("/api/versioncheck/v3"))
            {
              APIServer2.Version = rawUrl.Split('=')[1];
              Console.WriteLine("Version: " + APIServer2.Version);
              Logger.UserPrefs.AddPref("last_version", APIServer2.Version);
              str1 = "{\"ValidVersion\":true}";
            }
            else if (rawUrl.StartsWith("/api/versioncheck/v4"))
            {
              APIServer2.Version = rawUrl.Split('=')[1];
              Console.WriteLine("Version: " + APIServer2.Version);
              Logger.UserPrefs.AddPref("last_version", APIServer2.Version);
              str1 = "{\"VersionStatus\":0}";
            }
            else if (rawUrl.StartsWith("/api/versioncheck/v2"))
            {
              APIServer2.Version = rawUrl.Split('=')[1];
              Console.WriteLine("Version: " + APIServer2.Version);
              Logger.UserPrefs.AddPref("last_version", APIServer2.Version);
              str1 = "{\"ValidVersion\":true}";
            }
          }
          else if (rawUrl.StartsWith("/api/CampusCard/v1/oculusRRPEnabled"))
            str1 = "true";
          else if (rawUrl.StartsWith("/api/images/v4/uploadsaved"))
          {
            Images.ImageUploadResponse imageUploadResponse = new Images.ImageUploadResponse("Harmonicia_" + ClientSecurity.GetTokenSubject(APIServer2.auth.Split(' ')[1]).ToString() + "-" + DateTime.Now.ToString("MM.dd.yyyy HH.mm.ss.fff") + ".jpg");
            System.IO.File.WriteAllBytes(Environment.CurrentDirectory + "\\Pictures\\" + imageUploadResponse.ImageName, APIServer2.MultiFormSplit(byteList.ToArray()));
            str1 = JsonConvert.SerializeObject((object) imageUploadResponse);
          }
          else if (rawUrl.StartsWith("/api/gamesight/event"))
            str1 = "";
          else if (rawUrl == "/api/avatar/v1/defaultunlocked")
            str1 = new WebClient().DownloadString("https://api.rec.net" + rawUrl);
          else if (rawUrl == "/api/gameconfigs/v1/all")
            str1 = new WebClient().DownloadString("https://api.rec.net" + rawUrl);
          else if (rawUrl == "/api/sanitize/v1/isPure" || rawUrl == "/api/sanitize/v1/ispure")
            str1 = JsonConvert.SerializeObject((object) Sanitize.SanitizeRequest(postData));
          else if (rawUrl == "/api/sanitize/v1")
            str1 = Sanitize.SanitizeChatMessageRequest(postData, str2);
          else if (rawUrl == "/api/config/v1/amplitude")
            str1 = new WebClient().DownloadString("https://api.rec.net" + rawUrl);
          else if (rawUrl.StartsWith("/api/PlayerReporting/v1/moderationBlockDetails"))
          {
            ulong tokenSubject = ClientSecurity.GetTokenSubject(APIServer2.auth.Split(' ')[1]);
            APIServer2.AccountLookupData accountLookupData = JsonConvert.DeserializeObject<APIServer2.AccountLookupData>(new WebClient().DownloadString("https://accounts.rec.net/account/" + tokenSubject.ToString()));
            APIServer2.AccountCache = new AccountCache()
            {
              accountId = (int) tokenSubject,
              username = accountLookupData.username,
              createdAt = accountLookupData.createdAt.Value,
              displayName = accountLookupData.displayName
            };
            if (!this.AllAccountsActive.ContainsKey((ulong) APIServer2.AccountCache.accountId))
            {
              this.AllAccountsActive.Add((ulong) APIServer2.AccountCache.accountId, accountLookupData);
              System.IO.File.WriteAllText("accounts.txt", JsonConvert.SerializeObject((object) this.AllAccountsActive));
            }
            str1 = PlayerModeration.GetCurrentBan();
          }
          else if (rawUrl.StartsWith("/api/relationships/v2/get") || rawUrl.StartsWith("/api/relationships/v1/get"))
            str1 = Relationships.Friends();
          else if (rawUrl.StartsWith("/api/relationships/v2/sendfriendrequest"))
            str1 = Relationships.SendFriendRequest(int.Parse(rawUrl.Split('=')[1]));
          else if (rawUrl.StartsWith("/api/relationships/v2/acceptfriendrequest"))
            str1 = Relationships.AcceptFriendRequest(int.Parse(rawUrl.Split('=')[1]));
          else if (rawUrl.StartsWith("/api/relationships/v1/bulkignoreplatformuser"))
            str1 = "[]";
          else if (rawUrl.StartsWith("/api/settings/v2"))
            str1 = JsonConvert.SerializeObject((object) RecNet.Settings.LoadMultiplayerSettings((int) ClientSecurity.GetTokenSubject(APIServer2.auth.Split(' ')[1])));
          else if (rawUrl.StartsWith("/api/playerReputation/v2/bulk"))
          {
            RestClient restClient = new RestClient("https://api.rec.net");
            RestRequest restRequest1 = new RestRequest(rawUrl, Method.GET);
            restRequest1.AddHeader("Authorization", APIServer2.auth);
            RestRequest restRequest2 = restRequest1;
            List<RecNet.Players.Reputation> reputationList = JsonConvert.DeserializeObject<List<RecNet.Players.Reputation>>(restClient.Execute((IRestRequest) restRequest2).Content);
            int num = 0;
            while (reputationList == null)
              ++num;
            foreach (RecNet.Players.Reputation reputation in reputationList)
            {
              if (APIServer2.AccountCache != null)
              {
                int? accountId1 = reputation.AccountId;
                int accountId2 = APIServer2.AccountCache.accountId;
                if (accountId1.GetValueOrDefault() == accountId2 & accountId1.HasValue)
                {
                  reputation.IsCheerful = new bool?(true);
                  reputation.Noteriety = new double?(0.0);
                  reputation.SelectedCheer = new int?(9000);
                  reputation.CheerCredit = new int?(900);
                  reputation.CheerGeneral = new int?(900);
                  reputation.CheerHelpful = new int?(900);
                  reputation.CheerCreative = new int?(900);
                  reputation.CheerGreatHost = new int?(900);
                  reputation.CheerSportsman = new int?(900);
                }
              }
            }
            str1 = JsonConvert.SerializeObject((object) reputationList);
          }
          else if (rawUrl.StartsWith("/api/players/v2/progression/bulk"))
          {
            RestClient restClient = new RestClient("https://api.rec.net");
            RestRequest restRequest3 = new RestRequest(rawUrl, Method.GET);
            restRequest3.AddHeader("Authorization", APIServer2.auth);
            RestRequest restRequest4 = restRequest3;
            List<PlayerProgression.Details> detailsList = JsonConvert.DeserializeObject<List<PlayerProgression.Details>>(restClient.Execute((IRestRequest) restRequest4).Content);
            int num = 0;
            while (detailsList == null)
              ++num;
            foreach (PlayerProgression.Details details in detailsList)
            {
              if (APIServer2.AccountCache != null && details.PlayerId == APIServer2.AccountCache.accountId)
              {
                details.Level = 50;
                details.XP = 1080;
              }
            }
            str1 = JsonConvert.SerializeObject((object) detailsList);
          }
          else if (rawUrl.StartsWith("/api/players/v1/progression/hile"))
            str1 = GenericRecNetResponse.SetNewResponse(false, "");
          else if (rawUrl == "/api/avatar/v2")
            str1 = JsonConvert.SerializeObject((object) RecNet.Avatar.LoadMultiplayerOutfit((int) ClientSecurity.GetTokenSubject(APIServer2.auth.Split(' ')[1])));
          else if (rawUrl == "/api/quickPlay/v1/getandclear")
            str1 = QuickPlay.GetAndClear();
          else if (rawUrl == "/api/config/v2")
            str1 = APIServer2.Version.StartsWith("2017") || APIServer2.Version.StartsWith("2018") ? Config2.GetDebugConfig() : RecNetConfig.Current();
          else if (rawUrl == "/api/settings/v2/set")
          {
            RecNet.Settings.SaveMultiplayerSetting((int) ClientSecurity.GetTokenSubject(APIServer2.auth.Split(' ')[1]), postData);
            str1 = "[]";
          }
          else if (rawUrl.StartsWith("/api/announcement/v1/get"))
            str1 = Announcements.GetCurrent();
          else if (rawUrl == "/api/equipment/v2/getUnlocked")
            str1 = APIServer2.Version.StartsWith("2017") || APIServer2.Version.StartsWith("2018") ? OldAPIs.Equipment.GetUnlocked() : RecNet.Equipment.GetUnlocked();
          else if (rawUrl == "/api/communityboard/v2/current")
            str1 = CommunityBoard.GetCurrent();
          else if (rawUrl == "/api/PlayerCheer/v1/SetSelectedCheer")
          {
            bool flag = true;
            string[] strArray = postData.Split('=');
            str1 = !flag ? Cheering.SetCheerBadge((Cheering.CheerBadges) int.Parse(strArray[1]), str2) : Cheering.SetCheerBadge(Cheering.CheerBadges.RecRoomDeveloper, str2);
          }
          else if (rawUrl.StartsWith("/api/rooms/v1/filters"))
            str1 = Room.Filters();
          else if (rawUrl == "/api/images/v2/named")
            str1 = APIServer2.Version.StartsWith("2017") || APIServer2.Version.StartsWith("2018") ? "[]" : Images.CurrentNamed();
          else if (rawUrl.StartsWith("/api/roomkeys/v1/room"))
            str1 = "[]";
          else if (rawUrl == "/api/avatar/v4/items")
          {
            if (APIServer2.Version.StartsWith("2017") || APIServer2.Version.StartsWith("2018"))
            {
              str1 = OldAPIs.AvatarItem.SerializeItems();
            }
            else
            {
              foreach (OutfitItems.AvatarItem customItem in IncentivizedItems.CustomItems)
              {
                if (!OutfitItems.LocalAvatarItems.Contains(customItem))
                  OutfitItems.LocalAvatarItems.Add(customItem);
              }
              str1 = JsonConvert.SerializeObject((object) OutfitItems.LocalAvatarItems);
            }
          }
          else if (rawUrl == "/api/avatar/v4")
          {
            RecNet.Avatar.SetSavedOutfit(postData);
            str1 = "";
          }
          else if (rawUrl.StartsWith("/api/storefronts/v3/giftdropstore/"))
          {
            string[] strArray = rawUrl.Split('/');
            Console.WriteLine(strArray[5]);
            str1 = JsonConvert.SerializeObject((object) Storefront.GetGiftDropStoreResponse((Storefront.StoreFrontTypes) int.Parse(strArray[5])));
          }
          else if (rawUrl == "/api/PlayerReporting/v1/voteToKickReasons")
            str1 = PlayerModeration.GetVoteKickReasons();
          else if (rawUrl == "/api/roomkeys/v1/mine")
            str1 = "[]";
          else if (rawUrl == "/api/avatar/v2/gifts" || rawUrl.StartsWith("/api/avatar/v4/gifts"))
            str1 = APIServer2.Version.StartsWith("2017") || APIServer2.Version.StartsWith("2018") ? AvatarGift.SerializeGifts() : JsonConvert.SerializeObject((object) AvatarGift.LoadGifts());
          else if (rawUrl == "/api/consumables/v2/getUnlocked")
            str1 = "[{\"Ids\":[11532856,11532858],\"CreatedAts\":[\"2020-06-04T22:49:38.464385Z\",\"2020-06-04T22:49:47.1636674Z\"],\"ConsumableItemDesc\":\"xHOwjwpXd0GDkvBz2VqieA\",\"Count\":120,\"InitialCount\":120,\"IsActive\":false,\"ActiveDurationMinutes\":null,\"IsTransferable\":false},{\"Ids\":[11635652],\"CreatedAts\":[\"2020-06-07T19:21:31.6786736Z\"],\"ConsumableItemDesc\":\"lag2tZyB90W04lQ7ol4vMw\",\"Count\":120,\"InitialCount\":120,\"IsActive\":false,\"ActiveDurationMinutes\":null,\"IsTransferable\":false},{\"Ids\":[11636629,69355202],\"CreatedAts\":[\"2020-06-07T19:53:12.5997267Z\",\"2020-11-29T14:34:45.496512Z\"],\"ConsumableItemDesc\":\"-hy0qD-iUk-v4NHxNzanmg\",\"Count\":120,\"InitialCount\":120,\"IsActive\":false,\"ActiveDurationMinutes\":null,\"IsTransferable\":false},{\"Ids\":[13180382,64917594,65837620,67131690,69356579,70827753,72444542,73297447,74862172,74871118,75098352,77220420,77772858,78424401,79226020,81044955,81771049,82190295,85150891,85407626,85997729,91081762,94350123,110797834,124156116,128808044],\"CreatedAts\":[\"2020-07-22T05:04:51.7Z\",\"2020-09-05T19:48:34.9086276Z\",\"2020-09-26T14:37:16.5493485Z\",\"2020-10-24T14:10:49.8277447Z\",\"2020-11-29T14:55:12.9372052Z\",\"2020-12-10T17:25:36.3759407Z\",\"2020-12-17T21:14:50.0675475Z\",\"2020-12-21T13:13:21.9075308Z\",\"2020-12-27T00:15:31.8142743Z\",\"2020-12-27T00:40:39.4150972Z\",\"2020-12-27T17:31:22.6773148Z\",\"2021-01-02T22:17:39.9134477Z\",\"2021-01-04T17:25:41.9187522Z\",\"2021-01-06T23:07:55.1355183Z\",\"2021-01-09T18:16:05.1486975Z\",\"2021-01-15T21:28:30.67315Z\",\"2021-01-17T20:17:22.6303519Z\",\"2021-01-18T23:18:49.1518899Z\",\"2021-01-29T19:16:58.5722163Z\",\"2021-01-30T15:45:08.2849681Z\",\"2021-02-01T16:37:03.998937Z\",\"2021-02-20T12:09:23.0626354Z\",\"2021-03-05T21:34:53.3678178Z\",\"2021-05-02T15:06:55.236142Z\",\"2021-06-21T19:31:49.4865645Z\",\"2021-07-05T14:21:41.4893647Z\"],\"ConsumableItemDesc\":\"frOMH6WxDEG1fBqC4_83vg\",\"Count\":3,\"InitialCount\":3,\"IsActive\":false,\"ActiveDurationMinutes\":null,\"IsTransferable\":false},{\"Ids\":[62990809],\"CreatedAts\":[\"2020-08-05T11:20:07.1069007Z\"],\"ConsumableItemDesc\":\"frOMH6WxDEG1fBqC4_83vg\",\"Count\":3,\"InitialCount\":3,\"IsActive\":false,\"ActiveDurationMinutes\":596449,\"IsTransferable\":false},{\"Ids\":[63349649,64955902,67765717,70798658,70830770,71990677,72419759,75108711,77148217,78306547,80366066,82196523,101297801,110797878,110798228,113222950,115492690,138134165],\"CreatedAts\":[\"2020-08-10T09:16:22.0026166Z\",\"2020-09-06T13:41:11.3444098Z\",\"2020-11-04T20:08:49.5100817Z\",\"2020-12-10T12:18:31.4997101Z\",\"2020-12-10T17:45:05.7167896Z\",\"2020-12-15T12:44:56.9149928Z\",\"2020-12-17T19:10:26.7236884Z\",\"2020-12-27T18:04:02.8659432Z\",\"2021-01-02T18:26:02.4675833Z\",\"2021-01-06T15:21:11.5733253Z\",\"2021-01-13T14:32:01.7389671Z\",\"2021-01-18T23:36:05.9697764Z\",\"2021-03-31T17:54:15.4103159Z\",\"2021-05-02T15:07:12.7680481Z\",\"2021-05-02T15:08:49.1645651Z\",\"2021-05-15T17:30:48.9178114Z\",\"2021-05-25T18:59:26.7162439Z\",\"2021-08-03T23:01:37.9666171Z\"],\"ConsumableItemDesc\":\"A5M-yf9tgUihq1uab3v58g\",\"Count\":3,\"InitialCount\":3,\"IsActive\":false,\"ActiveDurationMinutes\":null,\"IsTransferable\":false},{\"Ids\":[63351591],\"CreatedAts\":[\"2020-08-10T10:29:29.1300003Z\"],\"ConsumableItemDesc\":\"A5M-yf9tgUihq1uab3v58g\",\"Count\":3,\"InitialCount\":3,\"IsActive\":false,\"ActiveDurationMinutes\":596449,\"IsTransferable\":false},{\"Ids\":[63714319],\"CreatedAts\":[\"2020-08-15T22:26:33.1064959Z\"],\"ConsumableItemDesc\":\"m0bVLwWGj0GuIBSb6wCk6Q\",\"Count\":3,\"InitialCount\":3,\"IsActive\":false,\"ActiveDurationMinutes\":596449,\"IsTransferable\":false},{\"Ids\":[66464532,138803075],\"CreatedAts\":[\"2020-10-12T15:56:40.8985511Z\",\"2021-08-05T22:48:31.8618614Z\"],\"ConsumableItemDesc\":\"Sk_1sm88ZU2zpWn01Lv7hw\",\"Count\":1,\"InitialCount\":1,\"IsActive\":false,\"ActiveDurationMinutes\":null,\"IsTransferable\":false},{\"Ids\":[66924296],\"CreatedAts\":[\"2020-10-20T19:04:31.3145941Z\"],\"ConsumableItemDesc\":\"EAhk3ZZdXEmH5wRAXXT24Q\",\"Count\":85,\"InitialCount\":100,\"IsActive\":false,\"ActiveDurationMinutes\":76589,\"IsTransferable\":false},{\"Ids\":[69066049,70798551,71991217,72419779,72422788,75103219,75407746,80646872,81043764,97965913,110798330,117424244,135537292,142223965,143775181],\"CreatedAts\":[\"2020-11-26T16:43:55.9327394Z\",\"2020-12-10T12:16:36.4840642Z\",\"2020-12-15T12:54:03.0689664Z\",\"2020-12-17T19:10:34.6847031Z\",\"2020-12-17T19:26:45.9983052Z\",\"2020-12-27T17:46:51.4556638Z\",\"2020-12-28T14:49:26.9031312Z\",\"2021-01-14T14:48:14.9959897Z\",\"2021-01-15T21:25:11.8965017Z\",\"2021-03-20T13:51:07.8653788Z\",\"2021-05-02T15:09:13.5404939Z\",\"2021-06-02T13:49:57.978178Z\",\"2021-07-26T09:52:08.6803873Z\",\"2021-08-14T13:57:26.753567Z\",\"2021-08-18T20:31:54.8429687Z\"],\"ConsumableItemDesc\":\"m0bVLwWGj0GuIBSb6wCk6Q\",\"Count\":3,\"InitialCount\":3,\"IsActive\":false,\"ActiveDurationMinutes\":null,\"IsTransferable\":false},{\"Ids\":[69228496,69355129,69729962,69749643,69808490,69868568,69881979,70302026,70825338,74250348,74627703,74628194,74766036,75040957,76107539,76750602,76770521,77772153,78929100,79253046,82073489,86882368,91081719,103165744,110798450,115492629,130526250,133825962,144795111,153919314],\"CreatedAts\":[\"2020-11-28T18:05:00.648611Z\",\"2020-11-29T14:33:29.1152227Z\",\"2020-12-03T16:48:59.8396008Z\",\"2020-12-03T20:53:52.2685995Z\",\"2020-12-04T09:01:42.8358937Z\",\"2020-12-04T22:33:06.1081753Z\",\"2020-12-05T00:09:09.5118496Z\",\"2020-12-07T13:01:06.2351209Z\",\"2020-12-10T17:09:37.5476725Z\",\"2020-12-25T11:25:30.1066038Z\",\"2020-12-26T12:58:04.2565725Z\",\"2020-12-26T13:01:22.456871Z\",\"2020-12-26T20:22:01.0822232Z\",\"2020-12-27T13:23:10.6691567Z\",\"2020-12-30T14:48:46.5607584Z\",\"2021-01-01T11:51:08.2090635Z\",\"2021-01-01T14:33:56.620368Z\",\"2021-01-04T17:22:27.0862393Z\",\"2021-01-08T20:51:01.5027823Z\",\"2021-01-09T19:34:03.0704636Z\",\"2021-01-18T18:11:27.1073539Z\",\"2021-02-05T14:18:33.9365468Z\",\"2021-02-20T12:09:07.3423442Z\",\"2021-04-06T14:40:16.7157762Z\",\"2021-05-02T15:09:49.256491Z\",\"2021-05-25T18:59:07.8775015Z\",\"2021-07-10T23:48:30.7878601Z\",\"2021-07-20T20:15:50.7723121Z\",\"2021-08-21T16:17:58.669257Z\",\"2021-09-19T00:17:21.6462356Z\"],\"ConsumableItemDesc\":\"JfnVXFmilU6ysv-VbTAe3A\",\"Count\":1,\"InitialCount\":1,\"IsActive\":false,\"ActiveDurationMinutes\":null,\"IsTransferable\":false},{\"Ids\":[69228599,69357329,69750028,70833239,77225682,81279505,92816214],\"CreatedAts\":[\"2020-11-28T18:05:10.5664034Z\",\"2020-11-29T15:05:17.5285034Z\",\"2020-12-03T20:59:08.9820049Z\",\"2020-12-10T17:59:37.8627751Z\",\"2021-01-02T22:33:25.1992589Z\",\"2021-01-16T14:08:13.9787563Z\",\"2021-02-27T16:38:52.9733085Z\"],\"ConsumableItemDesc\":\"5hIAZ9wg5EyG1cILf4FS2A\",\"Count\":1,\"InitialCount\":1,\"IsActive\":false,\"ActiveDurationMinutes\":null,\"IsTransferable\":false},{\"Ids\":[69356157],\"CreatedAts\":[\"2020-11-29T14:48:34.7242347Z\"],\"ConsumableItemDesc\":\"VQSgL2pTLkWx4B3kwYG7UA\",\"Count\":120,\"InitialCount\":120,\"IsActive\":false,\"ActiveDurationMinutes\":null,\"IsTransferable\":false},{\"Ids\":[69546686,69546808,71990909],\"CreatedAts\":[\"2020-12-01T17:30:23.6200855Z\",\"2020-12-01T17:31:55.5928533Z\",\"2020-12-15T12:48:32.7983173Z\"],\"ConsumableItemDesc\":\"InQ25wQMGkG_bvuD5rf2Ag\",\"Count\":1,\"InitialCount\":1,\"IsActive\":false,\"ActiveDurationMinutes\":null,\"IsTransferable\":false},{\"Ids\":[69867405,71040491,72025307,72027969,74225408,74249955,106057690,110798264],\"CreatedAts\":[\"2020-12-04T22:24:46.5806764Z\",\"2020-12-11T19:25:33.8087628Z\",\"2020-12-15T17:57:12.9654338Z\",\"2020-12-15T18:11:18.0087403Z\",\"2020-12-25T07:05:46.1208959Z\",\"2020-12-25T11:21:52.1217599Z\",\"2021-04-16T16:39:23.0819245Z\",\"2021-05-02T15:08:57.0376131Z\"],\"ConsumableItemDesc\":\"_jnjYGBcyEWY5Ub4OezXcA\",\"Count\":1,\"InitialCount\":1,\"IsActive\":false,\"ActiveDurationMinutes\":null,\"IsTransferable\":false},{\"Ids\":[69871453,70302658,102522058,115494016],\"CreatedAts\":[\"2020-12-04T22:54:11.4757218Z\",\"2020-12-07T13:09:19.9158523Z\",\"2021-04-04T12:28:07.1651413Z\",\"2021-05-25T19:06:23.406159Z\"],\"ConsumableItemDesc\":\"7OZ5AE3uuUyqa0P-2W1ptg\",\"Count\":1,\"InitialCount\":1,\"IsActive\":false,\"ActiveDurationMinutes\":null,\"IsTransferable\":false},{\"Ids\":[70168757,70170122,74636930,80185264],\"CreatedAts\":[\"2020-12-06T17:26:05.9654492Z\",\"2020-12-06T17:34:23.5400033Z\",\"2020-12-26T13:53:51.8392558Z\",\"2021-01-12T21:30:31.8805531Z\"],\"ConsumableItemDesc\":\"5AJin8T2iEG7BzOPOgx2HA\",\"Count\":100,\"InitialCount\":100,\"IsActive\":false,\"ActiveDurationMinutes\":null,\"IsTransferable\":false},{\"Ids\":[71034871,76904245,103159913,108314157,124443439],\"CreatedAts\":[\"2020-12-11T18:57:12.4775943Z\",\"2021-01-01T22:56:48.0687526Z\",\"2021-04-06T14:12:20.3313789Z\",\"2021-04-23T17:04:38.8630302Z\",\"2021-06-22T14:41:07.326779Z\"],\"ConsumableItemDesc\":\"J1WqFNUWo0OBi4LGKPDHWw\",\"Count\":100,\"InitialCount\":100,\"IsActive\":false,\"ActiveDurationMinutes\":null,\"IsTransferable\":false},{\"Ids\":[71990411,74741754,75409145,80203936],\"CreatedAts\":[\"2020-12-15T12:40:19.2324569Z\",\"2020-12-26T19:22:55.6730332Z\",\"2020-12-28T14:56:50.850825Z\",\"2021-01-12T22:26:38.3715087Z\"],\"ConsumableItemDesc\":\"yvqSbK2czkS2sUCRdrGaEw\",\"Count\":100,\"InitialCount\":100,\"IsActive\":false,\"ActiveDurationMinutes\":null,\"IsTransferable\":false},{\"Ids\":[72449925,76093060,78203433,91081700,132742409],\"CreatedAts\":[\"2020-12-17T21:41:24.0780526Z\",\"2020-12-30T13:14:18.9899558Z\",\"2021-01-06T01:56:15.1186704Z\",\"2021-02-20T12:08:56.8407208Z\",\"2021-07-17T13:07:54.8915869Z\"],\"ConsumableItemDesc\":\"mq23W-RSP0G8iGNLdrcpUw\",\"Count\":1,\"InitialCount\":1,\"IsActive\":false,\"ActiveDurationMinutes\":null,\"IsTransferable\":false},{\"Ids\":[74254069,78065982,80203866],\"CreatedAts\":[\"2020-12-25T12:01:07.5607434Z\",\"2021-01-05T18:05:04.5545667Z\",\"2021-01-12T22:26:20.6388909Z\"],\"ConsumableItemDesc\":\"U38Qe6rhEk6mFvArHfYjng\",\"Count\":100,\"InitialCount\":100,\"IsActive\":false,\"ActiveDurationMinutes\":null,\"IsTransferable\":false},{\"Ids\":[74391689,78025596,78059786,81340554,101622457,135543108],\"CreatedAts\":[\"2020-12-25T21:15:17.0680636Z\",\"2021-01-05T14:35:09.2511296Z\",\"2021-01-05T17:36:45.1923508Z\",\"2021-01-16T17:50:36.4964352Z\",\"2021-04-01T18:43:37.646193Z\",\"2021-07-26T10:39:03.7614522Z\"],\"ConsumableItemDesc\":\"mMCGPgK3tki5S_15q2Z81A\",\"Count\":1,\"InitialCount\":1,\"IsActive\":false,\"ActiveDurationMinutes\":null,\"IsTransferable\":false},{\"Ids\":[74624902],\"CreatedAts\":[\"2020-12-26T12:37:31.911882Z\"],\"ConsumableItemDesc\":\"iiGTvhOCHkOTNJhb16Zbyw\",\"Count\":1,\"InitialCount\":1,\"IsActive\":false,\"ActiveDurationMinutes\":null,\"IsTransferable\":false},{\"Ids\":[74641904],\"CreatedAts\":[\"2020-12-26T14:18:36.1555482Z\"],\"ConsumableItemDesc\":\"XOZcxx-Klkyhe-MDbTqiwA\",\"Count\":100,\"InitialCount\":100,\"IsActive\":false,\"ActiveDurationMinutes\":null,\"IsTransferable\":false},{\"Ids\":[77711996,83443768],\"CreatedAts\":[\"2021-01-04T10:22:43.8933333Z\",\"2021-01-23T14:18:20.6512468Z\"],\"ConsumableItemDesc\":\"ZuvkidodzkuOfGLDnTOFyg\",\"Count\":1,\"InitialCount\":1,\"IsActive\":false,\"ActiveDurationMinutes\":null,\"IsTransferable\":false},{\"Ids\":[78073154],\"CreatedAts\":[\"2021-01-05T18:36:18.528261Z\"],\"ConsumableItemDesc\":\"uGVFydNSokCXFAmXu3aceQ\",\"Count\":100,\"InitialCount\":100,\"IsActive\":false,\"ActiveDurationMinutes\":null,\"IsTransferable\":false},{\"Ids\":[78852959,79222123],\"CreatedAts\":[\"2021-01-08T15:39:44.0197717Z\",\"2021-01-09T18:04:57.8492596Z\"],\"ConsumableItemDesc\":\"LwaotjVEBUir0-w8126n_g\",\"Count\":1,\"InitialCount\":1,\"IsActive\":false,\"ActiveDurationMinutes\":null,\"IsTransferable\":false},{\"Ids\":[85151079,117398468],\"CreatedAts\":[\"2021-01-29T19:17:46.025967Z\",\"2021-06-02T11:32:00.9946609Z\"],\"ConsumableItemDesc\":\"wUCIKdJSvEmiQHYMyx4X4w\",\"Count\":1,\"InitialCount\":1,\"IsActive\":false,\"ActiveDurationMinutes\":null,\"IsTransferable\":false},{\"Ids\":[91084667],\"CreatedAts\":[\"2021-02-20T12:30:56.5831739Z\"],\"ConsumableItemDesc\":\"U38Qe6rhEk6mFvArHfYjng\",\"Count\":100,\"InitialCount\":100,\"IsActive\":false,\"ActiveDurationMinutes\":73373,\"IsTransferable\":false},{\"Ids\":[101604883],\"CreatedAts\":[\"2021-04-01T17:39:29.6994009Z\"],\"ConsumableItemDesc\":\"A5M-yf9tgUihq1uab3v58g\",\"Count\":3,\"InitialCount\":3,\"IsActive\":false,\"ActiveDurationMinutes\":265685,\"IsTransferable\":false},{\"Ids\":[103286854,116369351,120574418],\"CreatedAts\":[\"2021-04-06T22:35:06.5239877Z\",\"2021-05-29T16:16:56.1119816Z\",\"2021-06-11T20:15:27.8604546Z\"],\"ConsumableItemDesc\":\"K9RbXo-4U0q6NbGu8VL1Sw\",\"Count\":1,\"InitialCount\":1,\"IsActive\":false,\"ActiveDurationMinutes\":null,\"IsTransferable\":false},{\"Ids\":[115492656],\"CreatedAts\":[\"2021-05-25T18:59:17.0127767Z\"],\"ConsumableItemDesc\":\"frOMH6WxDEG1fBqC4_83vg\",\"Count\":3,\"InitialCount\":3,\"IsActive\":false,\"ActiveDurationMinutes\":164546,\"IsTransferable\":false},{\"Ids\":[117105611],\"CreatedAts\":[\"2021-06-01T13:31:10.9013928Z\"],\"ConsumableItemDesc\":\"A5M-yf9tgUihq1uab3v58g\",\"Count\":3,\"InitialCount\":3,\"IsActive\":false,\"ActiveDurationMinutes\":164546,\"IsTransferable\":false},{\"Ids\":[117125940,117411994,117412000,117412008,117412011,117412019,117412027,141212412,141212421,141212441,141212457],\"CreatedAts\":[\"2021-06-01T15:42:05.346421Z\",\"2021-06-02T12:50:52.9653523Z\",\"2021-06-02T12:50:55.1865728Z\",\"2021-06-02T12:50:57.1432377Z\",\"2021-06-02T12:50:58.9741862Z\",\"2021-06-02T12:51:00.8804907Z\",\"2021-06-02T12:51:02.7399455Z\",\"2021-08-11T18:57:09.9146562Z\",\"2021-08-11T18:57:11.5964487Z\",\"2021-08-11T18:57:15.9153013Z\",\"2021-08-11T18:57:17.3347055Z\"],\"ConsumableItemDesc\":\"P15H1ONBhk-5DYYjid1ttg\",\"Count\":1,\"InitialCount\":1,\"IsActive\":false,\"ActiveDurationMinutes\":null,\"IsTransferable\":false},{\"Ids\":[118116392],\"CreatedAts\":[\"2021-06-04T16:07:14.1943783Z\"],\"ConsumableItemDesc\":\"m0bVLwWGj0GuIBSb6wCk6Q\",\"Count\":3,\"InitialCount\":3,\"IsActive\":false,\"ActiveDurationMinutes\":164546,\"IsTransferable\":false},{\"Ids\":[124163600],\"CreatedAts\":[\"2021-06-21T19:51:19.9078448Z\"],\"ConsumableItemDesc\":\"g3kxdlJv5kO8PuBXveM48w\",\"Count\":78,\"InitialCount\":100,\"IsActive\":true,\"ActiveDurationMinutes\":73373,\"IsTransferable\":false},{\"Ids\":[134068175],\"CreatedAts\":[\"2021-07-21T17:03:53.492547Z\"],\"ConsumableItemDesc\":\"ZtZnYBpKkECJlhHmkj4MiA\",\"Count\":100,\"InitialCount\":100,\"IsActive\":false,\"ActiveDurationMinutes\":null,\"IsTransferable\":false}]";
          else if (rawUrl.StartsWith("/api/playerevents/v1/all"))
            str1 = RecNet.Events.All();
          else if (rawUrl == "/api/CampusCard/v1/UpdateAndGetSubscription")
            str1 = JsonConvert.SerializeObject((object) Commerce.GetAndUpdateSubscription());
          else if (rawUrl == "/api/avatar/v3/saved")
            str1 = "[]";
          else if (rawUrl.StartsWith("/api/challenge/v2/getCurrent"))
            str1 = APIServer2.Version.StartsWith("2017") || APIServer2.Version.StartsWith("2018") ? OldAPIs.Challenge.getCurrent() : WeeklyChallenge.GetCurrentWeekly();
          else if (rawUrl.StartsWith("/api/objectives/v1/cleargroup"))
          {
            Objectives.ClearGroup();
            str1 = "";
          }
          else if (rawUrl == "/api/objectives/v1/myprogress")
            str1 = Objectives.MyProgress();
          else if (rawUrl == "/api/gamerewards/v1/pending")
            str1 = "[]";
          else if (rawUrl.StartsWith("/api/roomcurrencies/v1/currencies"))
            str1 = RoomCurrencies.GetRoomCurrencies(1UL);
          else if (rawUrl.StartsWith("/api/roomconsumables/v1/roomConsumable/room/"))
          {
            if (rawUrl.EndsWith("me"))
              str1 = RoomConsumables.GetRoomConsumablesMe();
            str1 = RoomConsumables.GetRoomConsumables(1UL);
          }
          else if (rawUrl.StartsWith("/api/roomcurrencies/v1/getAllBalances"))
            str1 = RoomCurrencies.GetAllBalances(1UL);
          else if (rawUrl.StartsWith("/api/messages/v1/favoriteFriendOnlineStatus"))
            str1 = "";
          else if (rawUrl == "/api/avatar/v2/set")
          {
            string auth = APIServer2.auth;
            char[] chArray = new char[1]{ ' ' };
            long tokenSubject;
            RecNet.Avatar.SaveMultiplayerOutfit((int) (tokenSubject = (long) ClientSecurity.GetTokenSubject(auth.Split(chArray)[1])), JsonConvert.DeserializeObject<RecNet.Avatar.PlayerVisualResponse>(postData));
            str1 = JsonConvert.SerializeObject((object) RecNet.Avatar.LoadMultiplayerOutfit((int) tokenSubject));
          }
          else if (rawUrl == "/api/messages/v2/get")
            str1 = Messages.GetAllMessages();
          else if (rawUrl.StartsWith("/api/images/v5/cheered/bulk"))
            str1 = Images.GetCheeredBulk();
          else if (rawUrl.StartsWith("/api/storefronts/v1/balanceAddType/"))
          {
            string[] strArray = rawUrl.Split('/');
            str1 = Storefront.AddBalanceType(int.Parse(strArray[5]), int.Parse(strArray[6]));
          }
          else if (rawUrl.StartsWith("/api/storefronts/v4/balance/"))
          {
            string[] strArray = rawUrl.Split('/');
            Console.WriteLine("Current currency type: " + strArray[5]);
            str1 = Storefront.GetBalance(int.Parse(strArray[5]));
          }
          else if (rawUrl.StartsWith("/api/storefronts/v2/buyItem"))
          {
            JsonConvert.DeserializeObject<Storefront.BuyItemPostData>(postData);
            str1 = JsonConvert.SerializeObject((object) Storefront.BuyItem(postData));
            Console.WriteLine(str1);
          }
          else if (rawUrl.StartsWith("/api/inventions/v2/mine"))
            str1 = Inventions.Mine();
          else if (rawUrl.StartsWith("/api/inventions/v1/version"))
          {
            rawUrl.Split('/');
            str1 = Inventions.GetInvention(1, 1);
          }
          else if (rawUrl.StartsWith("/api/inventions/v1/featured"))
            str1 = Inventions.Featured();
          else if (rawUrl.StartsWith("/api/itemWishlists/v1/wishlist/me"))
            str1 = Wishlist.Me();
          else if (rawUrl.StartsWith("/api/PlayerReporting/v1/hile"))
          {
            NameValueCollection headers2 = request.Headers;
            WebClient webClient = new WebClient();
            for (int index = 0; index < request.Headers.Count; ++index)
            {
              string key = headers2.GetKey(index);
              Console.WriteLine(headers2.GetKey(index) + " : " + headers2.GetValues(key)[0]);
            }
            str1 = "";
          }
          else if (rawUrl.StartsWith("/api/incentivizedreferrals/progress"))
            str1 = IncentivizedReferrals.Progress();
          else if (rawUrl.StartsWith("/api/consumables/v1/updateActive"))
            str1 = GenericRecNetResponse.SetNewResponse(true, "");
          else if (rawUrl.StartsWith("/api/images/v4/room"))
            str1 = JsonConvert.SerializeObject((object) Images.GetRoomImage(int.Parse(rawUrl.Split('/')[5])));
          else if (rawUrl.StartsWith("/api/playerevents/v1/room"))
            str1 = JsonConvert.SerializeObject((object) RecNet.PlayerEvents.GetRoomWithId(int.Parse(rawUrl.Split('/')[5])));
          else if (rawUrl.StartsWith("/api/playerevents/v1/search"))
            str1 = JsonConvert.SerializeObject((object) RecNet.PlayerEvents.Search(""));
          else if (rawUrl.StartsWith("/api/playerevents/v1/tagfilters"))
            str1 = RecNet.PlayerEvents.Filters();
          if (rawUrl.StartsWith("/api/platformlogins/v1/cachedlogins"))
          {
            str1 = JsonConvert.SerializeObject((object) RecNet.MultiServer.PlatformLogin.GetCachedLogins());
          }
          else
          {
            if (!APIServer2.Version.StartsWith("2017") && !APIServer2.Version.StartsWith("2018"))
            {
              if (!APIServer2.Version.StartsWith("rightroom-"))
                goto label_188;
            }
            if (rawUrl.StartsWith("/api/platformlogins/v1/getcachedlogins") || rawUrl.StartsWith("/api/platformlogins/v1/cachedlogins"))
              str1 = JsonConvert.SerializeObject((object) RecNet.MultiServer.PlatformLogin.GetCachedLogins());
            else
              rawUrl.StartsWith("/api/presence/v1/setplayertype");
          }
        }
        catch (Exception ex)
        {
          Console.WriteLine("ERROR!\n\t" + ex.ToString());
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine("Error!\n\t" + ex.ToString());
      }
label_188:
      return str1;
    }

    private void StartListen()
    {
      OutfitItems.SetLocalOutfitData(Storefront.StoreFrontTypes.LaserTag);
      OutfitItems.SetLocalOutfitData(Storefront.StoreFrontTypes.RecCenter);
      OutfitItems.SetLocalOutfitData(Storefront.StoreFrontTypes.Watch);
      OutfitItems.SetLocalOutfitData(Storefront.StoreFrontTypes.Quest_LostSkulls);
      OutfitItems.SetLocalOutfitData(Storefront.StoreFrontTypes.Quest_Dracula);
      OutfitItems.SetLocalOutfitData(Storefront.StoreFrontTypes.Quest_GoldenTrophy);
      OutfitItems.SetLocalOutfitData(Storefront.StoreFrontTypes.Quest_CrimsonCauldron);
      OutfitItems.SetLocalOutfitData(Storefront.StoreFrontTypes.Paintball);
      OutfitItems.SetLocalOutfitData(Storefront.StoreFrontTypes.Paintball_SunsetDriveIn);
      OutfitItems.SetLocalOutfitData(Storefront.StoreFrontTypes.Bowling);
      OutfitItems.SetLocalOutfitData(Storefront.StoreFrontTypes.StuntRunner);
      OutfitItems.AddDefaultUnlocked();
      this.listener.Prefixes.Add(string.Format("http://+:{0}/", (object) Config.APIServerPort));
      while (true)
      {
        this.listener.Start();
        HttpListenerContext context = this.listener.GetContext();
        HttpListenerRequest request = context.Request;
        HttpListenerResponse response = context.Response;
        string rawUrl = request.RawUrl;
        this.ServerRequests.Add(new ServerRequest()
        {
          url = rawUrl,
          playerId = Accounts.GetMID(),
          isDone = false
        });
        string end;
        using (StreamReader streamReader = new StreamReader(request.InputStream, request.ContentEncoding))
          end = streamReader.ReadToEnd();
        Console.WriteLine(rawUrl);
        byte[] bytes = Encoding.UTF8.GetBytes(this.StartCurrentUserCallProcess(this.ServerRequests[0], context, request, response, end));
        response.ContentLength64 = (long) bytes.Length;
        Stream outputStream = response.OutputStream;
        outputStream.Write(bytes, 0, bytes.Length);
        Thread.Sleep(100);
        outputStream.Close();
        this.listener.Stop();
      }
    }

    public string StartCurrentUserCallProcess(
      ServerRequest request,
      HttpListenerContext context,
      HttpListenerRequest httrequest,
      HttpListenerResponse response,
      string postData)
    {
      string str;
      if (!request.isDone)
      {
        request.isDone = true;
        this.ServerRequests.Remove(this.ServerRequests[0]);
        str = this.ProcessRequest(request.url, context, httrequest, response, postData);
      }
      else
        str = "";
      return str;
    }

    public void AlertServer(int state) => Logger.Log("status", "Request was sent, and heres the status code : " + state.ToString());

    public class MultiFormData
    {
      public string Name { get; set; }

      public string FileName { get; set; }

      public int ContentLength { get; set; }

      public byte[] Content { get; set; }
    }

    public class AccountLookupData
    {
      public string username { get; set; }

      public string displayName { get; set; }

      public string profileImage { get; set; }

      public int? accountId { get; set; }

      public bool? isJunior { get; set; }

      public int? platforms { get; set; }

      public DateTime? createdAt { get; set; }
    }
  }
}

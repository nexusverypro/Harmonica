// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Newtonsoft.Json;
using System.Collections.Generic;

namespace RecNet
{
  internal class Wishlist
  {
    public static string Me() => JsonConvert.SerializeObject((object) new List<Wishlist.WishlistItem>()
    {
      new Wishlist.WishlistItem()
      {
        WishlistItemId = "2d92dcbc-ce5e-409a-8a7b-5ce2c893df66",
        AccountId = 1,
        PurchasableItemId = 1,
        CreatedAt = "2021-08-10T19:32:24.0571405Z"
      }
    });

    public class WishlistItem
    {
      public string WishlistItemId { get; set; }

      public int AccountId { get; set; }

      public int PurchasableItemId { get; set; }

      public string CreatedAt { get; set; }
    }
  }
}

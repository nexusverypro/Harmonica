// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace RecNet
{
  internal class Clothing
  {
    public static List<Clothing.Item> LoadItemsFromFile() => JsonConvert.DeserializeObject<List<Clothing.Item>>(File.ReadAllText(Environment.CurrentDirectory + "\\Resources\\LocalClothing"));

    public static void AddItem(
      List<Clothing.Item> listOfClothing,
      string avatarItemDesc,
      string friendlyName)
    {
      listOfClothing.Add(new Clothing.Item()
      {
        AvatarItemDesc = avatarItemDesc,
        AvatarItemType = 0,
        PlatformMask = -1,
        FriendlyName = friendlyName,
        Tooltip = "",
        Rarity = 0
      });
    }

    public static string AddItem(string avatarItemDesc, string friendlyName) => JsonConvert.SerializeObject((object) new Clothing.Item()
    {
      AvatarItemDesc = avatarItemDesc,
      AvatarItemType = 0,
      PlatformMask = -1,
      FriendlyName = friendlyName,
      Tooltip = "",
      Rarity = 0
    });

    public class Item
    {
      public string AvatarItemDesc { get; set; }

      public int AvatarItemType { get; set; }

      public int PlatformMask { get; set; }

      public string FriendlyName { get; set; }

      public string Tooltip { get; set; }

      public int Rarity { get; set; }
    }
  }
}

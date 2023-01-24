// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Configs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace OldAPIs
{
  public class AvatarGift
  {
    public ulong Id { get; private set; }

    public string AvatarItemDesc { get; private set; }

    public int Xp { get; private set; }

    public static string SerializeGifts()
    {
      if (Config.localGifts == null)
      {
        if (File.Exists(Environment.CurrentDirectory + "\\Resources\\LocalGifts"))
        {
          Config.localGifts = AvatarGift.LoadGifts();
        }
        else
        {
          Config.localGifts = AvatarGift.NewPlayerGifts();
          AvatarGift.SaveGifts();
        }
      }
      return JsonConvert.SerializeObject((object) Config.localGifts);
    }

    public static string CreateGift(Dictionary<string, string> postdata)
    {
      string str = postdata["AvatarItemDesc"];
      Convert.ToInt32(postdata["PackageType"]);
      int int32 = Convert.ToInt32(postdata["Xp"]);
      uint num = (uint) new Random().Next(2, 999999999);
      AvatarGift avatarGift = new AvatarGift()
      {
        Id = (ulong) num,
        AvatarItemDesc = str,
        Xp = int32
      };
      Config.localGifts.Add(avatarGift);
      return JsonConvert.SerializeObject((object) avatarGift);
    }

    public static void ConsumeGift(Dictionary<string, string> postdata)
    {
      ulong uint64 = Convert.ToUInt64(postdata["Id"]);
      int giftLocation = AvatarGift.FindGiftLocation(uint64);
      if (giftLocation == -1)
        return;
      Console.WriteLine(string.Format("[Gift][Consume]: Consuming gift with ID of {0} at list position {1}", (object) uint64, (object) giftLocation));
      AvatarItem.AddAvatarItem(Config.localGifts[giftLocation].AvatarItemDesc, 1);
      Config.localGifts.RemoveAt(giftLocation);
      AvatarGift.SaveGifts();
    }

    public static int FindGiftLocation(ulong giftID)
    {
      for (int index = 0; index < Config.localGifts.Count; ++index)
      {
        if ((long) Config.localGifts[index].Id == (long) giftID)
          return index;
      }
      return -1;
    }

    public static List<AvatarGift> LoadGifts() => new List<AvatarGift>();

    public static List<AvatarGift> NewPlayerGifts() => new List<AvatarGift>()
    {
      new AvatarGift() { Id = 11UL, AvatarItemDesc = "", Xp = 10 }
    };

    public static void SaveGifts()
    {
      using (BinaryWriter binaryWriter = new BinaryWriter((Stream) File.Create(Environment.CurrentDirectory + "\\Resources\\LocalGifts")))
      {
        foreach (AvatarGift localGift in Config.localGifts)
        {
          binaryWriter.Write(localGift.Id);
          binaryWriter.Write(localGift.AvatarItemDesc);
          binaryWriter.Write(localGift.Xp);
        }
      }
    }
  }
}

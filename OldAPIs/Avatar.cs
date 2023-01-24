// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Configs;
using Newtonsoft.Json;
using System;
using System.IO;

namespace OldAPIs
{
  public class Avatar
  {
    public string OutfitSelections { get; set; }

    public string HairColor { get; set; }

    public string SkinColor { get; set; }

    public string FaceFeatures { get; set; }

    public static void SetAvatar(string jsonData)
    {
      Console.WriteLine("[api.lh] Setting avatar");
      Avatar avatar = JsonConvert.DeserializeObject<Avatar>(jsonData);
      Config.localAvatar.OutfitSelections = avatar.OutfitSelections;
      Config.localAvatar.HairColor = avatar.HairColor;
      Config.localAvatar.SkinColor = avatar.SkinColor;
      Config.localAvatar.FaceFeatures = "";
      Avatar.SaveAvatar();
    }

    public static string SerializeAvatar()
    {
      Console.WriteLine("[api.lh] Serializing avatar");
      if (Config.localAvatar == null)
      {
        if (File.Exists(Environment.CurrentDirectory + "\\Resources\\LocalAvatar"))
        {
          Config.localAvatar = Avatar.LoadAvatar();
        }
        else
        {
          Config.localAvatar = Avatar.DefaultAvatar();
          Avatar.SaveAvatar();
        }
      }
      return JsonConvert.SerializeObject((object) Config.localAvatar);
    }

    public static Avatar LoadAvatar()
    {
      Console.WriteLine("[api.lh] Parsing avatar data");
      Avatar avatar = new Avatar();
      return JsonConvert.DeserializeObject<Avatar>(File.ReadAllText(Environment.CurrentDirectory + "\\Resources\\LocalAvatar"));
    }

    public static Avatar DefaultAvatar() => new Avatar()
    {
      OutfitSelections = "",
      HairColor = "",
      SkinColor = "",
      FaceFeatures = ""
    };

    public static void SaveAvatar()
    {
      using (BinaryWriter binaryWriter = new BinaryWriter((Stream) File.Create(Environment.CurrentDirectory + "\\Resources\\LocalAvatar")))
      {
        binaryWriter.Write(Config.localAvatar.OutfitSelections);
        binaryWriter.Write(Config.localAvatar.HairColor);
        binaryWriter.Write(Config.localAvatar.SkinColor);
        binaryWriter.Write(Config.localAvatar.FaceFeatures);
      }
    }
  }
}

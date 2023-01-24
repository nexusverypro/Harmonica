// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Newtonsoft.Json;
using Servers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RecNet
{
  public class Avatar
  {
    private static List<Avatar.SavedOutfit> savedOutfits;
    private static Avatar.Outfit outfit;
    public static Dictionary<ulong, Avatar.SavedOutfit> AllPlayersSavedOutfits;
    public static Dictionary<int, Avatar.PlayerVisualResponse> AllGlobalOutfits = new Dictionary<int, Avatar.PlayerVisualResponse>();

    public static string GetSelection() => File.ReadAllText(Environment.CurrentDirectory + "\\Avatar.txt");

    public static List<Avatar.SavedOutfit> SavedOutfits
    {
      get
      {
        if (Avatar.savedOutfits == null)
          Avatar.LoadSavedOutfits();
        return Avatar.savedOutfits;
      }
    }

    public static Avatar.PlayerVisualResponse CurrentOutfit => Avatar.LoadPlayerSavedOutfit();

    public static void LoadSavedOutfits()
    {
      Avatar.AllPlayersSavedOutfits = new Dictionary<ulong, Avatar.SavedOutfit>();
      if (File.Exists(Environment.CurrentDirectory + "\\SavedOutfits.txt"))
      {
        Avatar.AllPlayersSavedOutfits = JsonConvert.DeserializeObject<Dictionary<ulong, Avatar.SavedOutfit>>(File.ReadAllText(Environment.CurrentDirectory + "\\SavedOutfits.txt"));
      }
      else
      {
        File.CreateText(Environment.CurrentDirectory + "\\SavedOutfits.txt");
        Avatar.AllPlayersSavedOutfits = JsonConvert.DeserializeObject<Dictionary<ulong, Avatar.SavedOutfit>>(File.ReadAllText(Environment.CurrentDirectory + "\\SavedOutfits.txt"));
      }
    }

    public static void SaveSavedOutfits(
      string bearer,
      string os,
      string ff,
      string sc,
      string hc)
    {
    }

    public static void SetOutfit(string os, string ff, string sc, string hc)
    {
      Avatar.PlayerVisualResponse playerVisualResponse = new Avatar.PlayerVisualResponse()
      {
        OutfitSelections = os,
        FaceFeatures = ff,
        SkinColor = sc,
        HairColor = sc
      };
      Avatar.SaveOutfit(playerVisualResponse.OutfitSelections, playerVisualResponse.FaceFeatures, playerVisualResponse.SkinColor, playerVisualResponse.HairColor);
    }

    public static void SetOutfit(string postData) => Avatar.SaveOutfit(JsonConvert.DeserializeObject<Avatar.PlayerVisualResponse>(postData));

    public static void SaveOutfit(string os, string ff, string sc, string hc)
    {
    }

    public static void SetSavedOutfit(string postData)
    {
      Avatar.SavedOutfit savedOutfit = JsonConvert.DeserializeObject<Avatar.SavedOutfit>(postData);
      for (int index = 0; index < Avatar.savedOutfits.Count<Avatar.SavedOutfit>(); ++index)
      {
        if (savedOutfit.Slot == Avatar.savedOutfits[index].Slot)
          Avatar.savedOutfits.RemoveAt(index);
      }
      Avatar.savedOutfits.Add(savedOutfit);
      Avatar.SaveSavedOutfits(APIServer2.auth, savedOutfit.OutfitSelections, savedOutfit.FaceFeatures, savedOutfit.SkinColor, savedOutfit.HairColor);
    }

    public static Avatar.PlayerVisualResponse LoadPlayerSavedOutfit() => JsonConvert.DeserializeObject<Avatar.PlayerVisualResponse>(File.ReadAllText(Environment.CurrentDirectory + "\\Avatar.txt"));

    public static void SaveOutfit(Avatar.PlayerVisualResponse hc) => File.WriteAllText(Environment.CurrentDirectory + "\\Avatar.txt", JsonConvert.SerializeObject((object) hc));

    public static void SaveMultiplayerOutfit(int id, Avatar.PlayerVisualResponse visualResponse)
    {
      Avatar.AllGlobalOutfits = JsonConvert.DeserializeObject<Dictionary<int, Avatar.PlayerVisualResponse>>(File.ReadAllText("global-outfit-metadata.txt"));
      if (Avatar.AllGlobalOutfits.ContainsKey(id))
      {
        Avatar.AllGlobalOutfits.Remove(id);
        Avatar.AllGlobalOutfits.Add(id, visualResponse);
        File.WriteAllText("global-outfit-metadata.txt", JsonConvert.SerializeObject((object) Avatar.AllGlobalOutfits));
      }
      else
      {
        Avatar.AllGlobalOutfits.Add(id, visualResponse);
        File.WriteAllText("global-outfit-metadata.txt", JsonConvert.SerializeObject((object) Avatar.AllGlobalOutfits));
      }
    }

    public static Avatar.PlayerVisualResponse LoadMultiplayerOutfit(int id)
    {
      Avatar.AllGlobalOutfits = JsonConvert.DeserializeObject<Dictionary<int, Avatar.PlayerVisualResponse>>(File.ReadAllText("global-outfit-metadata.txt"));
      if (Avatar.AllGlobalOutfits.ContainsKey(id))
        return Avatar.AllGlobalOutfits[id];
      Avatar.PlayerVisualResponse visualResponse = new Avatar.PlayerVisualResponse()
      {
        OutfitSelections = "",
        FaceFeatures = "",
        HairColor = "",
        SkinColor = ""
      };
      Avatar.SaveMultiplayerOutfit(id, visualResponse);
      return visualResponse;
    }

    public class Outfit
    {
      public string OutfitSelections { get; set; }

      public string HairColor { get; set; }

      public string SkinColor { get; set; }

      public string FaceFeatures { get; set; }
    }

    public class PlayerVisualResponse
    {
      public string OutfitSelections { get; set; }

      public string FaceFeatures { get; set; }

      public string SkinColor { get; set; }

      public string HairColor { get; set; }
    }

    public class SavedOutfit
    {
      public string Slot { get; set; }

      public string PreviewImageName { get; set; }

      public string OutfitSelections { get; set; }

      public string HairColor { get; set; }

      public string SkinColor { get; set; }

      public string FaceFeatures { get; set; }
    }

    public class GiftPackage
    {
      public bool IsGifted;
    }
  }
}

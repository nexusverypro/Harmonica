// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;

namespace OldAPIs
{
  internal class Equipment
  {
    public static List<Equipment> LocalEquipment;

    public string PrefabName { get; set; }

    public string ModificationGuid { get; set; }

    public int UnlockedLevel { get; set; }

    public bool Favorited { get; set; }

    public static string GetUnlocked()
    {
      WebClient webClient = new WebClient();
      Equipment.LocalEquipment = JsonConvert.DeserializeObject<List<Equipment>>(new WebClient().DownloadString("https://raw.githubusercontent.com/recroom2016/vaultServerDependencies/main/Equipment.json"));
      return JsonConvert.SerializeObject((object) Equipment.LocalEquipment);
    }
  }
}

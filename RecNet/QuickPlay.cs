// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Newtonsoft.Json;
using RecNet.Handler;

namespace RecNet
{
  internal class QuickPlay
  {
    public static string GetAndClear()
    {
      Logger.UserPrefs.AddPref("quickplay_getandclear", "1");
      return JsonConvert.SerializeObject((object) new QuickPlay.QuickPlayResponseDTO()
      {
        TargetPlayerId = new long?(),
        RoomName = (string) null,
        ActionCode = (string) null
      });
    }

    public class QuickPlayResponseDTO
    {
      public long? TargetPlayerId { get; set; }

      public string RoomName { get; set; }

      public string ActionCode { get; set; }
    }
  }
}

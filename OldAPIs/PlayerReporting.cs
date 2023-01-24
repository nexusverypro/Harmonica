// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Newtonsoft.Json;

namespace OldAPIs
{
  internal class PlayerReporting
  {
    public static string moderationBlockDetails() => JsonConvert.SerializeObject((object) new PlayerReporting.ModerationBlockDetails()
    {
      ReportCategory = 0,
      Duration = 0,
      GameSessionId = 0L,
      Message = ""
    });

    private class ModerationBlockDetails
    {
      public int ReportCategory { get; set; }

      public int Duration { get; set; }

      public long GameSessionId { get; set; }

      public string Message { get; set; }
    }
  }
}

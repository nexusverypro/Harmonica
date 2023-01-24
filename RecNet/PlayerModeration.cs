// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Newtonsoft.Json;
using RecNet.Handler;
using System.Collections.Generic;

namespace RecNet
{
  internal class PlayerModeration
  {
    public static string GetVoteKickReasons() => JsonConvert.SerializeObject((object) new List<PlayerModeration.VoteKickReason>()
    {
      new PlayerModeration.VoteKickReason()
      {
        Valid = true,
        ReportCategory = 102,
        Reason = "Discriminatory language"
      },
      new PlayerModeration.VoteKickReason()
      {
        Valid = true,
        ReportCategory = 102,
        Reason = "Discriminatory behavior"
      },
      new PlayerModeration.VoteKickReason()
      {
        Valid = true,
        ReportCategory = 102,
        Reason = "Threats or encouraging suicide"
      },
      new PlayerModeration.VoteKickReason()
      {
        Valid = true,
        ReportCategory = 102,
        Reason = "Toxic behavior"
      },
      new PlayerModeration.VoteKickReason()
      {
        Valid = true,
        ReportCategory = 101,
        Reason = "Sexual behavior in public"
      },
      new PlayerModeration.VoteKickReason()
      {
        Valid = true,
        ReportCategory = 101,
        Reason = "Sexual language in public"
      },
      new PlayerModeration.VoteKickReason()
      {
        Valid = true,
        ReportCategory = 101,
        Reason = "Non-consensual sexual behavior"
      },
      new PlayerModeration.VoteKickReason()
      {
        Valid = true,
        ReportCategory = 103,
        Reason = "Player in walls or floor"
      },
      new PlayerModeration.VoteKickReason()
      {
        Valid = true,
        ReportCategory = 103,
        Reason = "Friendly fire"
      },
      new PlayerModeration.VoteKickReason()
      {
        Valid = true,
        ReportCategory = 103,
        Reason = "Microphone spam"
      },
      new PlayerModeration.VoteKickReason()
      {
        Valid = true,
        ReportCategory = 103,
        Reason = "Abusing bugs or exploits"
      },
      new PlayerModeration.VoteKickReason()
      {
        Valid = true,
        ReportCategory = 103,
        Reason = "Spawn camping"
      },
      new PlayerModeration.VoteKickReason()
      {
        Valid = true,
        ReportCategory = 6,
        Reason = "Inactive in games (AFK)"
      },
      new PlayerModeration.VoteKickReason()
      {
        Valid = false,
        ReportCategory = 6,
        Reason = "Teleporting in game"
      },
      new PlayerModeration.VoteKickReason()
      {
        Valid = true,
        ReportCategory = 6,
        Reason = "Not following game rules"
      }
    });

    public static string GetCurrentBan()
    {
      Logger.UserPrefs.AddPref("api_moderation_details_retrevial", "1");
      return JsonConvert.SerializeObject((object) new ModerationBlockDetail()
      {
        ReportCategory = ReportCategory.Unknown,
        Duration = 0,
        GameSessionId = 0L,
        Message = (string) null,
        IsHostKick = false,
        PlayerIdReporter = new long?(),
        IsBan = false
      });
    }

    public class VoteKickReason
    {
      public bool Valid { get; set; }

      public int ReportCategory { get; set; }

      public string Reason { get; set; }
    }
  }
}

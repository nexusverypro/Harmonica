// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

namespace RecNet
{
  public class ModerationBlockDetail
  {
    public ReportCategory ReportCategory { get; set; }

    public int Duration { get; set; }

    public long GameSessionId { get; set; }

    public string Message { get; set; }

    public bool IsHostKick { get; set; }

    public long? PlayerIdReporter { get; set; }

    public bool IsBan { get; set; }

    public int? VoteKickReason { get; set; }
  }
}

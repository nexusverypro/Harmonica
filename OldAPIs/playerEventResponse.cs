// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using System;

namespace OldAPIs
{
  internal class playerEventResponse
  {
    public long PlayerEventResponseId { get; set; }

    public long PlayerEventId { get; set; }

    public int PlayerId { get; set; }

    public DateTime CreatedAt { get; set; }

    public int Type { get; set; }
  }
}

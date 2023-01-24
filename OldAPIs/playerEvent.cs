// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using System;

namespace OldAPIs
{
  internal class playerEvent
  {
    public long PlayerEventId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public DateTime StartTime { get; set; }

    public int CreatorPlayerId { get; set; }

    public int AttendeeCount { get; set; }

    public long RoomId { get; set; }
  }
}

// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace OldAPIs
{
  internal class Events
  {
    public long EventId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public string PosterImageName { get; set; }

    public long CreatorPlayerId { get; set; }

    public static string list() => JsonConvert.SerializeObject((object) new List<Events>());
  }
}

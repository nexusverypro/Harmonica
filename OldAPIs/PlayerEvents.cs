// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Newtonsoft.Json;
using System.Collections.Generic;

namespace OldAPIs
{
  internal class PlayerEvents
  {
    public List<playerEvent> Created { get; set; }

    public List<OtherPlayerEvent> Responses { get; set; }

    public static string Get() => JsonConvert.SerializeObject((object) new PlayerEvents()
    {
      Created = new List<playerEvent>(),
      Responses = new List<OtherPlayerEvent>()
    });
  }
}

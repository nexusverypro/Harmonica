// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Newtonsoft.Json;

namespace OldAPIs
{
  internal class Amplitude
  {
    public string AmplitudeKey { get; set; }

    public static string amplitude() => JsonConvert.SerializeObject((object) new Amplitude()
    {
      AmplitudeKey = "e1693a1003671058b6abc356c8ba8d59"
    });
  }
}

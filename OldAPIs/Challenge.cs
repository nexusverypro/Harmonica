// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Newtonsoft.Json;

namespace OldAPIs
{
  internal class Challenge
  {
    public bool Success { get; set; }

    public string Message { get; set; }

    public static string getCurrent() => JsonConvert.SerializeObject((object) new Challenge()
    {
      Success = false,
      Message = ""
    });
  }
}

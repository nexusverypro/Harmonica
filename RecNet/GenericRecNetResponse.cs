// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Newtonsoft.Json;

namespace RecNet
{
  internal class GenericRecNetResponse
  {
    public static string SetNewResponse(bool success, string message) => JsonConvert.SerializeObject((object) new GenericRecNetResponse()
    {
      Success = success,
      Message = message
    });

    public bool Success { get; set; }

    public string Message { get; set; }
  }
}

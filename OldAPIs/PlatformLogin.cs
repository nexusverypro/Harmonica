// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Configs;
using Newtonsoft.Json;

namespace OldAPIs
{
  internal class PlatformLogin
  {
    public string Token { get; set; }

    public ulong PlayerId { get; set; }

    public string Error { get; set; }

    public static string v4(UserConfig profile) => JsonConvert.SerializeObject((object) new PlatformLogin()
    {
      Token = "j3923mHJG032jew",
      PlayerId = profile.UserID,
      Error = ""
    });

    public class v1
    {
      public static string profiles() => "";
    }
  }
}

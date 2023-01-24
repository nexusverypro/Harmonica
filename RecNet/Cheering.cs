// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

namespace RecNet
{
  public class Cheering
  {
    public static string SetCheerBadge(Cheering.CheerBadges cheer, string isg) => GenericRecNetResponse.SetNewResponse(true, "");

    public enum CheerBadges
    {
      General = 0,
      Helpful = 10, // 0x0000000A
      Sportmanship = 20, // 0x00000014
      GreatHost = 30, // 0x0000001E
      Creative = 40, // 0x00000028
      RecRoomDeveloper = 9000, // 0x00002328
    }
  }
}

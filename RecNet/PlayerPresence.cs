// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

namespace RecNet
{
  public class PlayerPresence
  {
    public int playerId { get; set; }

    public PlayerStatusVisibility statusVisibility { get; set; }

    public DeviceClass deviceClass { get; set; }

    public VRMovementMode vrMovementMode { get; set; }

    public RoomInstance roomInstance { get; set; }

    public bool isOnline { get; set; }

    public string appVersion { get; set; }
  }
}

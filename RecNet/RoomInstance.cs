// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

namespace RecNet
{
  public class RoomInstance
  {
    public int roomInstanceId { get; set; }

    public int roomId { get; set; }

    public int subRoomId { get; set; }

    public string location { get; set; }

    public int roomInstanceType { get; set; }

    public string dataBlob { get; set; }

    public string photonRegionId { get; set; }

    public string photonRoomId { get; set; }

    public string name { get; set; }

    public int maxCapacity { get; set; }

    public bool isFull { get; set; }

    public bool isPrivate { get; set; }

    public bool isInProgress { get; set; }
  }
}

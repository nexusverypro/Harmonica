// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using System;

namespace RecNet
{
  public class AccountCache
  {
    public int availableUsernameChanges { get; set; }

    public string email { get; set; }

    public string phone { get; set; }

    public DateTime birthday { get; set; }

    public int accountId { get; set; }

    public string username { get; set; }

    public string displayName { get; set; }

    public string profileImage { get; set; }

    public string bannerImage { get; set; }

    public bool isJunior { get; set; }

    public int platforms { get; set; }

    public DateTime createdAt { get; set; }
  }
}

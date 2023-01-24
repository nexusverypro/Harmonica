// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

namespace RecNet
{
  public class Account
  {
    public int AccountId { get; set; }

    public string DisplayName { get; set; }

    public bool HasBirthday { get; set; }

    public Account.PlatformMask Platforms { get; set; }

    public string ProfileImage { get; set; }

    public string RawUsername { get; set; }

    public bool TreatAsJunior { get; set; }

    public string Username { get; set; }

    public class MyAccountData
    {
      public int availableUsernameChanges { get; set; }

      public string email { get; set; }

      public string phone { get; set; }

      public string birthday { get; set; }

      public int accountId { get; set; }

      public string username { get; set; }

      public string displayName { get; set; }

      public string profileImage { get; set; }

      public string bannerImage { get; set; }

      public bool isJunior { get; set; }

      public Account.PlatformMask platforms { get; set; }

      public string createdAt { get; set; }
    }

    public enum PlatformMask
    {
      All = -1, // 0xFFFFFFFF
      None = 0,
      Steam = 1,
      Oculus = 2,
      PlayStation = 4,
      Microsoft = 8,
      HeadlessBot = 16, // 0x00000010
      IOS = 32, // 0x00000020
    }
  }
}

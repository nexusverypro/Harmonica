// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace RecNet
{
  internal static class Login
  {
    public static readonly string LoginLockToken = Guid.NewGuid().ToString();

    public static string LoginAccount() => JsonConvert.SerializeObject((object) new Login.LoginResponse()
    {
      Error = "",
      ErrorDescription = "",
      AccessToken = "eyJhbGciOiJSUzI1NiIsImtpZCI6IjRwY2dIaFlHWXk0LTZsUDI5d0RDME1kS09ONCIsInR5cCI6IkpXVCIsIng1dCI6IjRwY2dIaFlHWXk0LTZsUDI5d0RDME1kS09ONCJ9.eyJuYmYiOjE2MzI3NjgwMzUsImV4cCI6MTYzMjc3MTYzNSwiaXNzIjoiaHR0cHM6Ly9hdXRoLnJlYy5uZXQiLCJhdWQiOlsiaHR0cHM6Ly9hdXRoLnJlYy5uZXQvcmVzb3VyY2VzIiwicm4uYXBpIiwicm4ubm90aWZ5Iiwicm4ubWF0Y2giLCJybi5jaGF0Iiwicm4uYWNjb3VudHMiLCJybi5hdXRoIiwicm4ubGluayIsInJuLmNsdWJzIiwicm4ucm9vbXMiXSwiY2xpZW50X2lkIjoicmVjbmV0Iiwicm9sZSI6IndlYkNsaWVudCIsInN1YiI6IjI4NzQ0MTQ3IiwiYXV0aF90aW1lIjoxNjMyNzY4MDMyLCJpZHAiOiJsb2NhbCIsInJuLnBpZCI6IjI4NzQ0MTQ3Iiwic2NvcGUiOlsib3BlbmlkIiwicm4uYXBpIiwicm4ubm90aWZ5Iiwicm4ubWF0Y2gucmVhZCIsInJuLmNoYXQiLCJybi5hY2NvdW50cyIsInJuLmF1dGgiLCJybi5saW5rIiwicm4uY2x1YnMiLCJybi5yb29tcyJdLCJhbXIiOlsicHdkIl19.Evt7pXH3MF7G7__TCZiQKUuOu0b7V9AY7ubWSJcK_s5_Z1VCdOXk2PMO3oB9HyN7meACBmZvU8NFY_PGrLFTunUBhRwLjY1TgC5YYJjY5R0dMsOASvXKAOrsYnwOPjZq75HMzdEV9SsMc8-LKF2qmhHNZv9Jrs6nI-5-BBVQ_k-Mz05XZnod5sebXArQ-1Sm854ehDEykx1svgX4tsdhpfs5HImsnBvojkU98LxQ3D8qZjiT6OExNzpUKiYTRuh8MnYWiICHjXtOLp4Tjnuoo0Ro4wNBuVUE6uqTd-TDAt8suMtT3Kvi5JsITz4Qrs86Vq5hva00p_Ao-8trbzxFeg",
      RefreshToken = Guid.NewGuid().ToString()
    });

    private class PlayerAuthTokenDTO
    {
      public int PlayerId { get; set; }

      public string Token { get; set; }

      public string Error { get; set; }
    }

    public class CachedSelfAccount
    {
      public int accountId;
      public string rawUsername;
      public string username;
      public string displayName;
      public string profileImage;
      public bool treatAsJunior;
      public bool hasBirthday;
      public int platforms = 1;
    }

    public class CachedLogins
    {
      public class ForPlatformId
      {
        public static List<Login.CachedLogins.CachedAccount> CachedPlatformLogins() => new List<Login.CachedLogins.CachedAccount>()
        {
          new Login.CachedLogins.CachedAccount()
          {
            account = new Login.CachedSelfAccount()
            {
              accountId = 1,
              rawUsername = "Coach",
              username = "Coach",
              displayName = "Coach",
              profileImage = "DefaultProfileImage",
              treatAsJunior = false,
              hasBirthday = true,
              platforms = 1
            },
            accountId = 1,
            lastLoginTime = DateTime.UtcNow,
            platform = 0,
            platformId = "76561199212702087"
          }
        };

        public static Login.CachedLogins.CachedAccount GetAdministratorLoginCache() => new Login.CachedLogins.CachedAccount()
        {
          account = new Login.CachedSelfAccount()
          {
            accountId = 1,
            rawUsername = "Coach",
            username = "Coach",
            displayName = "Coach",
            profileImage = "DefaultProfileImage",
            treatAsJunior = false,
            hasBirthday = true,
            platforms = 1
          },
          accountId = 1,
          lastLoginTime = DateTime.UtcNow,
          platform = 0,
          platformId = "76561199212702087"
        };
      }

      public class CachedAccount
      {
        public Login.CachedSelfAccount account { get; set; }

        public int accountId { get; set; }

        public DateTime lastLoginTime { get; set; }

        public int platform { get; set; }

        public string platformId { get; set; }

        public bool requirePassword { get; set; }
      }
    }

    public class LoginResponseDTO
    {
      public string access_token { get; set; }

      public int expires_in { get; set; }

      public string token_type { get; set; }

      public string scope { get; set; }
    }

    private class LoginResponse
    {
      public string Error { get; set; }

      public string ErrorDescription { get; set; }

      public string AccessToken { get; set; }

      public string RefreshToken { get; set; }
    }
  }
}

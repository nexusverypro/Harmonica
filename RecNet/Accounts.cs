// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace RecNet
{
  internal static class Accounts
  {
    public static string LoginAccount() => Login.LoginAccount();

    public static string Me() => JsonConvert.SerializeObject((object) new Account.MyAccountData()
    {
      availableUsernameChanges = 1,
      birthday = "2001-01-17T00:00:00Z",
      accountId = 1,
      username = "Coach",
      displayName = "Coach",
      isJunior = false,
      profileImage = "77bdf3c7cd624b66b5f690fcb02bdf36.jpg",
      platforms = Account.PlatformMask.None,
      bannerImage = "",
      email = "coach@recroom.com",
      phone = "",
      createdAt = "2021-07-07T17:45:37.4975042Z"
    });

    public static Account.MyAccountData MyAccountData() => new Account.MyAccountData()
    {
      availableUsernameChanges = 1,
      birthday = "2001-01-17T00:00:00Z",
      accountId = 1,
      username = "Coach",
      displayName = "Coach",
      isJunior = false,
      profileImage = "77bdf3c7cd624b66b5f690fcb02bdf36.jpg",
      platforms = Account.PlatformMask.None,
      bannerImage = "",
      email = "coach@recroom.com",
      phone = "",
      createdAt = "2021-07-07T17:45:37.4975042Z"
    };

    public static uint GetMID()
    {
      string name1 = "SOFTWARE\\Microsoft\\Cryptography";
      string name2 = "MachineGuid";
      uint num = 0;
      using (RegistryKey registryKey1 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
      {
        using (RegistryKey registryKey2 = registryKey1.OpenSubKey(name1))
          num = uint.Parse(((registryKey2 != null ? registryKey2.GetValue(name2) : throw new KeyNotFoundException(string.Format("Key Not Found: {0}", (object) name1))) ?? throw new IndexOutOfRangeException(string.Format("Index Not Found: {0}", (object) name2))).ToString().Split('-')[0], NumberStyles.HexNumber);
      }
      return num;
    }

    public class CreateAccountResponse
    {
      public bool success { get; set; }

      public Account account { get; set; }
    }

    public class AccountBioResponseDTO
    {
      public int accountId { get; set; }

      public string bio { get; set; }
    }
  }
}

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
  internal class WeeklyChallenge
  {
    public static string GetCurrentWeekly() => JsonConvert.SerializeObject((object) new WeeklyChallenge.Weeklys()
    {
      ChallengeMapId = 245,
      ChallengeThemeString = "Harmonica Special",
      Challenges = new List<WeeklyChallenge.Challenge>()
      {
        new WeeklyChallenge.Challenge()
        {
          ChallengeId = 169,
          Name = "CompleteBloodMoon",
          Config = "{\"ct\":6,\"vs\":[4]},{\"ct\":7,\"vs\":[{\"l\":\"239e676c-f12f-489f-bf3a-d4c383d692c3\"},{\"l\":\"9d6456ce-6264-48b4-808d-2d96b3d91038\"}]}]}],\"t\":3}],\"t\":5,\"i\":\"-1.00\",\"pm\":1,\"pb\":true}",
          Description = "Harmonica",
          Tooltip = "Harmonica",
          Complete = true
        },
        new WeeklyChallenge.Challenge()
        {
          ChallengeId = 134,
          Name = "5HitstreakLaserTag",
          Config = "{\"ct\":16,\"ipc\":false,\"ccc\":[{\"ct\":15,\"ipc\":false,\"rc\":[{\"ct\":6,\"vs\":[3]}],\"ctc\":[{\"ct\":0,\"ipc\":false,\"wc\":[{\"ct\":6,\"vs\":[4]},{\"ct\":7,\"vs\":[{\"l\":\"239e676c-f12f-489f-bf3a-d4c383d692c3\"},{\"l\":\"9d6456ce-6264-48b4-808d-2d96b3d91038\"}]}]}],\"t\":3}],\"t\":5,\"i\":\"-1.00\",\"pm\":1,\"pb\":true}",
          Description = "Harmonica",
          Tooltip = "Harmonica",
          Complete = true
        },
        new WeeklyChallenge.Challenge()
        {
          ChallengeId = 151,
          Name = "CompleteJT",
          Config = "{\"ct\":0,\"ipc\":false,\"wc\":[{\"ct\":7,\"vs\":[{\"l\":\"acc06e66-c2d0-4361-b0cd-46246a4c455c\"}]},{\"ct\":6,\"vs\":[2]},{\"ct\":9,\"vs\":[true],\"v\":\"won\"}]}",
          Description = "Harmonica",
          Tooltip = "Harmonica",
          Complete = true
        },
        new WeeklyChallenge.Challenge()
        {
          ChallengeId = 124,
          Name = "5HitstreakPaintball",
          Config = "{\"ct\":16,\"ipc\":false,\"ccc\":[{\"ct\":15,\"ipc\":false,\"rc\":[{\"ct\":6,\"vs\":[3]}],\"ctc\":[{\"ct\":0,\"ipc\":false,\"wc\":[{\"ct\":6,\"vs\":[4]},{\"ct\":7,\"vs\":[{\"l\":\"e122fe98-e7db-49e8-a1b1-105424b6e1f0\"},{\"l\":\"a785267d-c579-42ea-be43-fec1992d1ca7\"},{\"l\":\"ff4c6427-7079-4f59-b22a-69b089420827\"},{\"l\":\"380d18b5-de9c-49f3-80f7-f4a95c1de161\"},{\"l\":\"58763055-2dfb-4814-80b8-16fac5c85709\"},{\"l\":\"65ddbb48-5a01-4e3e-972d-e5c7419e2bc3\"}]}]}],\"t\":3}],\"t\":5,\"i\":\"-1.00\",\"pm\":1,\"pb\":true}",
          Description = "Harmonica",
          Tooltip = "Harmonica",
          Complete = true
        },
        new WeeklyChallenge.Challenge()
        {
          ChallengeId = 167,
          Name = "Complete10Dodgeball",
          Config = "{\"ct\":1,\"ipc\":false,\"ctc\":[{\"ct\":0,\"ipc\":false,\"wc\":[{\"ct\":6,\"vs\":[2]},{\"ct\":7,\"vs\":[{\"l\":\"3d474b26-26f7-45e9-9a36-9b02847d5e6f\"}]}]}],\"t\":10}",
          Description = "Harmonica",
          Tooltip = "Harmonica",
          Complete = true
        }
      },
      Gift = new WeeklyChallenge.Gift()
      {
        GiftDropId = 3231,
        AvatarItemDesc = "",
        AvatarItemType = (object) null,
        Currency = 1000000000,
        CurrencyType = 3,
        Xp = 0,
        Level = 0,
        EquipmentPrefabName = (string) null,
        EquipmentModificationGuid = (string) null,
        ConsumableItemDesc = (string) null,
        ItemSetId = (object) null,
        ItemSetFriendlyName = "",
        QueryRedirectContext = (object) null,
        QueryRedirectRarity = (object) null,
        GiftContext = 10,
        GiftRarity = 30
      },
      FallbackGiftName = "4-Star Box",
      StartAt = "2021-09-29T21:00:00Z",
      EndAt = "2021-10-06T21:00:00Z",
      ServerTime = DateTime.UtcNow.ToString(),
      CompletedRequired = false
    });

    public class Challenge
    {
      public int ChallengeId { get; set; }

      public string Name { get; set; }

      public string Config { get; set; }

      public string Description { get; set; }

      public string Tooltip { get; set; }

      public bool Complete { get; set; }
    }

    public class Gift
    {
      public int GiftDropId { get; set; }

      public string AvatarItemDesc { get; set; }

      public object AvatarItemType { get; set; }

      public int Currency { get; set; }

      public int CurrencyType { get; set; }

      public int Xp { get; set; }

      public int Level { get; set; }

      public string EquipmentPrefabName { get; set; }

      public string EquipmentModificationGuid { get; set; }

      public string ConsumableItemDesc { get; set; }

      public object ItemSetId { get; set; }

      public string ItemSetFriendlyName { get; set; }

      public object QueryRedirectContext { get; set; }

      public object QueryRedirectRarity { get; set; }

      public int GiftContext { get; set; }

      public int GiftRarity { get; set; }
    }

    public class Weeklys
    {
      public int ChallengeMapId { get; set; }

      public string ChallengeThemeString { get; set; }

      public List<WeeklyChallenge.Challenge> Challenges { get; set; }

      public WeeklyChallenge.Gift Gift { get; set; }

      public string FallbackGiftName { get; set; }

      public string StartAt { get; set; }

      public string EndAt { get; set; }

      public string ServerTime { get; set; }

      public bool CompletedRequired { get; set; }
    }
  }
}

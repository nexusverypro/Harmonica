// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

namespace RecNet
{
  public class Gifts
  {
    public enum BalanceTypes
    {
      NonPurchasedNonP2P = -2, // 0xFFFFFFFE
      NonPurchasedP2P = -1, // 0xFFFFFFFF
      SteamPurchased = 0,
      OculusPurchased = 1,
      PlayStationPurchased = 2,
      MicrosoftPurchased = 3,
      IOSPurchased = 5,
      PlayStationNonPurchasedP2P = 100, // 0x00000064
      NonPlayStationNonPurchasedP2P = 101, // 0x00000065
    }

    public enum GiftBoxContents
    {
      Unspecified = -1, // 0xFFFFFFFF
      XP = 0,
      OutfitItem = 1,
      Equipment = 2,
      Currency = 3,
      Consumable = 4,
      Query = 5,
      HairDye = 6,
    }

    public enum GiftRarity
    {
      None = -1, // 0xFFFFFFFF
      Common = 0,
      Uncommon = 10, // 0x0000000A
      Rare = 20, // 0x00000014
      Epic = 30, // 0x0000001E
      Legendary = 50, // 0x00000032
    }

    public enum GiftContext
    {
      None = -1, // 0xFFFFFFFF
      Default = 0,
      First_Activity = 1,
      Game_Drop = 2,
      All_Daily_Challenges_Complete = 3,
      All_Weekly_Challenge_Complete = 4,
      Daily_Challenge_Complete = 5,
      Weekly_Challenge_Complete = 6,
      Unassigned_Equipment = 10, // 0x0000000A
      Unassigned_Avatar = 11, // 0x0000000B
      Unassigned_Consumable = 12, // 0x0000000C
      Reacquisition = 20, // 0x00000014
      Membership = 21, // 0x00000015
      NUX_TokensAndDressUp = 30, // 0x0000001E
      NUX_Experiment1 = 31, // 0x0000001F
      NUX_Experiment2 = 32, // 0x00000020
      NUX_Experiment3 = 33, // 0x00000021
      NUX_Experiment4 = 34, // 0x00000022
      NUX_Experiment5 = 35, // 0x00000023
      LevelUp = 100, // 0x00000064
      Purchased_Gift_A = 500, // 0x000001F4
      Purchased_Gift_B = 501, // 0x000001F5
      Purchased_Gift_C = 502, // 0x000001F6
      Purchased_Gift_D = 503, // 0x000001F7
      Holiday = 1000, // 0x000003E8
      Contest = 1001, // 0x000003E9
      Promotion = 1002, // 0x000003EA
      SubscribersOnly = 1003, // 0x000003EB
      Deprecated = 1100, // 0x0000044C
      RecRoyale = 1200, // 0x000004B0
      Paintball_ClearCut = 2000, // 0x000007D0
      Paintball_Homestead = 2001, // 0x000007D1
      Paintball_Quarry = 2002, // 0x000007D2
      Paintball_River = 2003, // 0x000007D3
      Paintball_Dam = 2004, // 0x000007D4
      Paintball_DriveIn = 2005, // 0x000007D5
      Discgolf_Propulsion = 3000, // 0x00000BB8
      Discgolf_Lake = 3001, // 0x00000BB9
      Discgolf_Mode_CoopCatch = 3500, // 0x00000DAC
      Quest_Goblin_A = 4000, // 0x00000FA0
      Quest_Goblin_B = 4001, // 0x00000FA1
      Quest_Goblin_C = 4002, // 0x00000FA2
      Quest_Goblin_S = 4003, // 0x00000FA3
      Quest_Goblin_Consumable = 4004, // 0x00000FA4
      Quest_Cauldron_A = 4010, // 0x00000FAA
      Quest_Cauldron_B = 4011, // 0x00000FAB
      Quest_Cauldron_C = 4012, // 0x00000FAC
      Quest_Cauldron_S = 4013, // 0x00000FAD
      Quest_Cauldron_Consumable = 4014, // 0x00000FAE
      Quest_Pirate1_A = 4100, // 0x00001004
      Quest_Pirate1_B = 4101, // 0x00001005
      Quest_Pirate1_C = 4102, // 0x00001006
      Quest_Pirate1_S = 4103, // 0x00001007
      Quest_Pirate1_X = 4104, // 0x00001008
      Quest_Pirate1_Consumable = 4105, // 0x00001009
      Quest_Dracula1_A = 4200, // 0x00001068
      Quest_Dracula1_B = 4201, // 0x00001069
      Quest_Dracula1_C = 4202, // 0x0000106A
      Quest_Dracula1_S = 4203, // 0x0000106B
      Quest_Dracula1_X = 4204, // 0x0000106C
      Quest_Dracula1_Consumable = 4205, // 0x0000106D
      Quest_Dracula1_SS = 4206, // 0x0000106E
      Quest_SciFi_A = 4500, // 0x00001194
      Quest_SciFi_B = 4501, // 0x00001195
      Quest_SciFi_C = 4502, // 0x00001196
      Quest_SciFi_S = 4503, // 0x00001197
      Quest_Scifi_Consumable = 4504, // 0x00001198
      Charades = 5000, // 0x00001388
      Soccer = 6000, // 0x00001770
      Paddleball = 7000, // 0x00001B58
      Dodgeball = 8000, // 0x00001F40
      Lasertag = 9000, // 0x00002328
      Bowling = 10000, // 0x00002710
      StuntRunner_TheMainEvent_A = 11000, // 0x00002AF8
      StuntRunner_TheMainEvent_B = 11001, // 0x00002AF9
      StuntRunner_TheMainEvent_C = 11002, // 0x00002AFA
      StuntRunner_TheMainEvent_D = 11003, // 0x00002AFB
      StuntRunner_TheMainEvent_S = 11004, // 0x00002AFC
      StuntRunner_TheMainEvent_X = 11005, // 0x00002AFD
      StuntRunner_TheMainEvent_Consumable = 11006, // 0x00002AFE
      StuntRunner_TheMainEvent_SS = 11007, // 0x00002AFF
      Store_LaserTag = 100000, // 0x000186A0
      Store_RecCenter = 100010, // 0x000186AA
      Consumable = 110000, // 0x0001ADB0
      Token = 110100, // 0x0001AE14
      Punchcard_Challenge_Complete = 110200, // 0x0001AE78
      All_Punchcard_Challenges_Complete = 110201, // 0x0001AE79
      Commerce_Purchase = 200000, // 0x00030D40
    }
  }
}

// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Newtonsoft.Json;
using System.Collections.Generic;

namespace RecNet
{
  internal class IncentivizedReferrals
  {
    public static string Progress() => JsonConvert.SerializeObject((object) new IncentivizedReferrals.IncentivizedReferralsResponseDTO()
    {
      success = true,
      value = new IncentivizedReferrals.Value()
      {
        ReferralsVerifiedCount = 0,
        PlayerReferralRewards = new List<IncentivizedReferrals.PlayerReferralReward>()
        {
          new IncentivizedReferrals.PlayerReferralReward()
          {
            UnlockedAt = (object) null,
            ClaimedAt = (object) null,
            Status = 0,
            ReferralRewardTier = new IncentivizedReferrals.ReferralRewardTier()
            {
              ReferralRewardTierId = 1,
              RequiredReferralCount = 1,
              RewardSelectionCount = 1
            }
          },
          new IncentivizedReferrals.PlayerReferralReward()
          {
            UnlockedAt = (object) null,
            ClaimedAt = (object) null,
            Status = 0,
            ReferralRewardTier = new IncentivizedReferrals.ReferralRewardTier()
            {
              ReferralRewardTierId = 2,
              RequiredReferralCount = 2,
              RewardSelectionCount = 1
            }
          },
          new IncentivizedReferrals.PlayerReferralReward()
          {
            UnlockedAt = (object) null,
            ClaimedAt = (object) null,
            Status = 0,
            ReferralRewardTier = new IncentivizedReferrals.ReferralRewardTier()
            {
              ReferralRewardTierId = 3,
              RequiredReferralCount = 3,
              RewardSelectionCount = 1
            }
          },
          new IncentivizedReferrals.PlayerReferralReward()
          {
            UnlockedAt = (object) null,
            ClaimedAt = (object) null,
            Status = 0,
            ReferralRewardTier = new IncentivizedReferrals.ReferralRewardTier()
            {
              ReferralRewardTierId = 4,
              RequiredReferralCount = 5,
              RewardSelectionCount = 2
            }
          },
          new IncentivizedReferrals.PlayerReferralReward()
          {
            UnlockedAt = (object) null,
            ClaimedAt = (object) null,
            Status = 0,
            ReferralRewardTier = new IncentivizedReferrals.ReferralRewardTier()
            {
              ReferralRewardTierId = 5,
              RequiredReferralCount = 7,
              RewardSelectionCount = 2
            }
          },
          new IncentivizedReferrals.PlayerReferralReward()
          {
            UnlockedAt = (object) null,
            ClaimedAt = (object) null,
            Status = 0,
            ReferralRewardTier = new IncentivizedReferrals.ReferralRewardTier()
            {
              ReferralRewardTierId = 7,
              RequiredReferralCount = 15,
              RewardSelectionCount = 3
            }
          },
          new IncentivizedReferrals.PlayerReferralReward()
          {
            UnlockedAt = (object) null,
            ClaimedAt = (object) null,
            Status = 0,
            ReferralRewardTier = new IncentivizedReferrals.ReferralRewardTier()
            {
              ReferralRewardTierId = 8,
              RequiredReferralCount = 20,
              RewardSelectionCount = 4
            }
          }
        }
      }
    });

    public class ReferralRewardTier
    {
      public int ReferralRewardTierId { get; set; }

      public int RequiredReferralCount { get; set; }

      public int RewardSelectionCount { get; set; }
    }

    public class PlayerReferralReward
    {
      public object UnlockedAt { get; set; }

      public object ClaimedAt { get; set; }

      public int Status { get; set; }

      public IncentivizedReferrals.ReferralRewardTier ReferralRewardTier { get; set; }
    }

    public class Value
    {
      public int ReferralsVerifiedCount { get; set; }

      public List<IncentivizedReferrals.PlayerReferralReward> PlayerReferralRewards { get; set; }
    }

    public class IncentivizedReferralsResponseDTO
    {
      public bool success { get; set; }

      public IncentivizedReferrals.Value value { get; set; }
    }
  }
}

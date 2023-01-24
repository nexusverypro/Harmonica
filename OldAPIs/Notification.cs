// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace OldAPIs
{
  public class Notification
  {
    public static string ProcessRequest(string jsonData)
    {
      Dictionary<string, object> dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonData);
      string str1;
      if (dictionary.ContainsKey("api"))
      {
        string str2 = (string) dictionary["api"];
        switch (str2)
        {
          case "playerSubscriptions/v1/update":
            Console.WriteLine("[WSS] Game client sent presence update.");
            str1 = JsonConvert.SerializeObject((object) Notification.Reponse.createResponse(12, (object) GameSessions.StatusSessionInstance()));
            break;
          case "heartbeat2":
            Console.WriteLine("[WSS] Heartbeat 2 sent by game client.");
            str1 = JsonConvert.SerializeObject((object) Notification.Reponse.createResponse(4, (object) GameSessions.StatusSessionInstance()));
            break;
          default:
            Console.WriteLine("[WSS] Unknown API call: " + str2);
            str1 = "";
            break;
        }
      }
      else
        str1 = jsonData;
      return str1;
    }

    public enum ResponseResult
    {
      RelationshipChanged = 1,
      MessageReceived = 2,
      MessageDeleted = 3,
      PresenceHeartbeatResponse = 4,
      SubscriptionListUpdated = 9,
      SubscriptionUpdateProfile = 11, // 0x0000000B
      SubscriptionUpdatePresence = 12, // 0x0000000C
      SubscriptionUpdateGameSession = 13, // 0x0000000D
      SubscriptionUpdateRoom = 14, // 0x0000000E
      ModerationQuitGame = 20, // 0x00000014
      ModerationUpdateRequired = 21, // 0x00000015
      ModerationKick = 22, // 0x00000016
      ModerationKickAttemptFailed = 23, // 0x00000017
      GiftPackageReceived = 30, // 0x0000001E
      ProfileJuniorStatusUpdate = 40, // 0x00000028
      RelationshipsInvalid = 50, // 0x00000032
      StorefrontBalanceAdd = 60, // 0x0000003C
    }

    public class Reponse
    {
      public int Id { get; set; }

      public object Msg { get; set; }

      public static Notification.Reponse createResponse(int id, object msg) => new Notification.Reponse()
      {
        Id = id,
        Msg = msg
      };
    }
  }
}

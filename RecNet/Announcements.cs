// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Newtonsoft.Json;
using RecNet.Handler;
using System;
using System.Collections.Generic;

namespace RecNet
{
  internal class Announcements
  {
    public static string LocalAnnouncements = "[{\"AnnouncementId\":103,\"AnnouncementType\":1,\"Title\":\"Creator Contest - Stranded!\",\"Body\":\"Help, we've been stranded! Our next creator contest is starting, and it is focused on survival, teamwork and finding a way out together. The theme is #Stranded, we can’t wait to see what you create!\",\"ImageName\":\"fa86107167bb4509bbc3976c89f6521b\",\"LinkType\":0,\"LinkName\":\"Details\",\"LinkUri\":\"https://recroom.com//stranded\",\"Platform\":-1,\"CreatedAt\":\"2021-10-01T16:03:09.4390094Z\"},{\"AnnouncementId\":101,\"AnnouncementType\":3,\"Title\":\"New RRO Trailer!\",\"Body\":\"The new RRO is being revealed... introducing Rec Rally! Check out the trailer now on YouTube.\",\"ImageName\":\"fe3e8aab59944a148a8dc31b7c84c578\",\"LinkType\":0,\"LinkName\":\"Watch Now!\",\"LinkUri\":\"https://youtu.be//Nh4dc60PRBA\",\"Platform\":-1,\"CreatedAt\":\"2021-09-25T17:50:44.5445658Z\"},{\"AnnouncementId\":100,\"AnnouncementType\":3,\"Title\":\"Rec Con 2021\",\"Body\":\"Rec Con 2021 is LIVE! From now until Sunday at Midnight, check out the events, panels, talks, booths and art from Rec Room and beyond!\\r\\n\",\"ImageName\":\"6259dd7daf754bd38fbe5b4a36c027a9\",\"LinkType\":3,\"LinkName\":\"Go!\",\"LinkUri\":\"reccon\",\"Platform\":-1,\"CreatedAt\":\"2021-09-24T19:01:51.9852669Z\"}]";

    public static string GetCurrent()
    {
      Logger.UserPrefs.AddPref("api_got_current_announcement_data", "1");
      return JsonConvert.SerializeObject((object) new List<Announcements.Announcement>()
      {
        new Announcements.Announcement()
        {
          AnnouncementId = 101,
          AnnouncementType = 3,
          Title = "Harmonica!",
          Body = "imagine modding",
          ImageName = "e958b1a7748744c7b1a7b74255c03aa6.jpg?cropSquare=true&width=1000&height=1000",
          LinkType = 0,
          LinkName = "Go!",
          LinkUri = "^reccenter",
          Platform = -1,
          CreatedAt = DateTime.Parse("2021-09-24T19:01:51.9852669Z")
        }
      });
    }

    public class Announcement
    {
      public int AnnouncementId { get; set; }

      public int AnnouncementType { get; set; }

      public string Title { get; set; }

      public string Body { get; set; }

      public string ImageName { get; set; }

      public int LinkType { get; set; }

      public string LinkName { get; set; }

      public string LinkUri { get; set; }

      public int Platform { get; set; }

      public DateTime CreatedAt { get; set; }
    }
  }
}

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
  internal class CommunityBoard
  {
    public static string LocalCommunityBoard = "{\"FeaturedPlayer\":{\"Id\":410754,\"TitleOverride\":null,\"UrlOverride\":null},\"FeaturedRoomGroup\":{\"FeaturedRoomGroupId\":158,\"Name\":\"Featured Rooms\",\"StartAt\":\"2021-09-28T07:00:00Z\",\"EndAt\":\"2021-10-05T07:00:00Z\",\"Rooms\":[{\"RoomId\":30855426,\"RoomName\":\"RecRally\",\"ImageName\":\"930e5fa3ade14779a47ee4066c07b2ff.jpg\"},{\"RoomId\":29692121,\"RoomName\":\"MascotWinners\",\"ImageName\":\"89f2940fa56543eda355e7a34f1290ad.jpg\"},{\"RoomId\":25982421,\"RoomName\":\"TripleThreat\",\"ImageName\":\"f2c59d3267754aff9fb38bbbf5ee08f3.jpg\"},{\"RoomId\":26054046,\"RoomName\":\"Dumbo\",\"ImageName\":\"fb6bb8c936bc4502915a338afde978e9.jpg\"},{\"RoomId\":28555532,\"RoomName\":\"FrontierWarground\",\"ImageName\":\"02f70f3e6e9b40f4b0bd072902ba71ac.jpg\"},{\"RoomId\":25967723,\"RoomName\":\"NewOrleans\",\"ImageName\":\"2fa63786deb24d1c808d9a773fc84553.jpg\"},{\"RoomId\":27672730,\"RoomName\":\"JokersMayhem\",\"ImageName\":\"e54007aa1a0c4e0cb451d94e7a1e66c5.jpg\"},{\"RoomId\":29447338,\"RoomName\":\"SweetAmber\",\"ImageName\":\"38a6dc016aed4a479f1a1d589973d958.jpg\"},{\"RoomId\":29529931,\"RoomName\":\"parkour_kitsune\",\"ImageName\":\"042af444dca84a0fb00084d0b366052c.jpg\"},{\"RoomId\":25534686,\"RoomName\":\"CarriageHouse\",\"ImageName\":\"c4514900741a414c8c89df03d333eecc.jpg\"},{\"RoomId\":26057211,\"RoomName\":\"Rooftop_Carnival\",\"ImageName\":\"e4f9f20dc9b44abab7fec4a11cef736c.jpg\"},{\"RoomId\":25270185,\"RoomName\":\"AirHaus\",\"ImageName\":\"5a260ca2766b4b0db57b3d4794c38856.jpg\"}]},\"CurrentAnnouncement\":{\"Message\":\"The #Stranded contest is starting!\",\"MoreInfoUrl\":\"https://recroom.com/stranded\"},\"InstagramImages\":[{\"ImageName\":\"n/04f65772c8a445fa95848f0c4310c15d\",\"ImageUrl\":null},{\"ImageName\":\"n/fcbd9523b75e4b73a16fc9145a2da3b3\",\"ImageUrl\":null},{\"ImageName\":\"n/f28018c498be4c8899e596e348d47869\",\"ImageUrl\":null},{\"ImageName\":\"n/cb192e7a38d34519bb313f563fa5759f\",\"ImageUrl\":null},{\"ImageName\":\"n/d4d272bde90043fcbff051d22a9fec67\",\"ImageUrl\":null},{\"ImageName\":\"n/50031137650145d9befbc737f4e52c8a\",\"ImageUrl\":null},{\"ImageName\":\"n/2eb08d74af994475a630e6210627c948\",\"ImageUrl\":null},{\"ImageName\":\"n/fc0d3247779a4a1992b2eda8969220f5\",\"ImageUrl\":null},{\"ImageName\":\"n/a3d5ded839b24a31ac1c416b748f11aa\",\"ImageUrl\":null},{\"ImageName\":\"n/cf935b2bab0f4f3791457f857d0a37a3\",\"ImageUrl\":null},{\"ImageName\":\"n/9d66675280bb4846844a1e68ff0cfa46\",\"ImageUrl\":null},{\"ImageName\":\"n/8388740edfdc409aaaee2204c8217cc0\",\"ImageUrl\":null}],\"Videos\":[{\"BlobName\":\"98455ec8f2804af5ab68a58ecb3e683f\",\"Title\":\"REC RALLY - YOUTUBER MATCH\",\"Description\":null,\"ThumbnailBlobName\":\"eea3a3a3ef67404b87cb3e21c0c739c6\",\"SourceUrl\":\"https://www.youtube.com/watch?v=kN95ZnHzKFc&ab_channel=BVR\"},{\"BlobName\":\"61f8111dff0e4cbdb2b1473b50bd9a5d\",\"Title\":\"Rec Room Rec Rally Trailer\",\"Description\":null,\"ThumbnailBlobName\":\"9930960dc4b942dea82e46774f38bace\",\"SourceUrl\":\"https://www.youtube.com/watch?v=Nh4dc60PRBA&ab_channel=RecRoom\"},{\"BlobName\":\"7397e3af638740dd891a7d1f8d89ebe2\",\"Title\":\"We Made Rec Rally Even More Fun\",\"Description\":null,\"ThumbnailBlobName\":\"53879d107b3445728a928c1ac680e723\",\"SourceUrl\":\"https://www.youtube.com/watch?v=LWXoBiodpeo&t=219s&ab_channel=Wrighteous\"},{\"BlobName\":\"746ecc2a121343bfa35005a50de1e44a\",\"Title\":null,\"Description\":null,\"ThumbnailBlobName\":null,\"SourceUrl\":null}]}";

    public static string GetCurrent()
    {
      Logger.UserPrefs.AddPref("api_community_board_data_retreival", "1");
      return JsonConvert.SerializeObject((object) new CommunityBoard.CommunityBoardResponse()
      {
        FeaturedPlayer = new CommunityBoard.FeaturedPlayer()
        {
          Id = 1,
          TitleOverride = (object) null,
          UrlOverride = (object) null
        },
        FeaturedRoomGroup = new CommunityBoard.FeaturedRoomGroup()
        {
          FeaturedRoomGroupId = 158,
          Name = "Rec Room Featured",
          StartAt = DateTime.Parse("2021-09-30T07:00:00Z"),
          EndAt = DateTime.Parse("2021-10-27T07:00:00Z"),
          Rooms = new List<CommunityBoard.Room>()
          {
            new CommunityBoard.Room()
            {
              RoomId = 1,
              RoomName = "Room",
              ImageName = "DefaultProfileImage"
            }
          }
        },
        CurrentAnnouncement = new CommunityBoard.CurrentAnnouncement()
        {
          Message = "Welcome to Harmonica!",
          MoreInfoUrl = "https://rightroom.world"
        },
        InstagramImages = (List<CommunityBoard.InstagramImage>) null,
        Videos = new List<CommunityBoard.Video>()
        {
          new CommunityBoard.Video()
          {
            BlobName = (object) null,
            Title = "Featured Video",
            Description = (object) null,
            ThumbnailBlobName = "DefaultProfileImage",
            SourceUrl = (string) null
          }
        }
      });
    }

    public class CommunityBoardResponse
    {
      public CommunityBoard.FeaturedPlayer FeaturedPlayer { get; set; }

      public CommunityBoard.FeaturedRoomGroup FeaturedRoomGroup { get; set; }

      public CommunityBoard.CurrentAnnouncement CurrentAnnouncement { get; set; }

      public List<CommunityBoard.InstagramImage> InstagramImages { get; set; }

      public List<CommunityBoard.Video> Videos { get; set; }
    }

    public class FeaturedPlayer
    {
      public int Id { get; set; }

      public object TitleOverride { get; set; }

      public object UrlOverride { get; set; }
    }

    public class Room
    {
      public int RoomId { get; set; }

      public string RoomName { get; set; }

      public string ImageName { get; set; }
    }

    public class FeaturedRoomGroup
    {
      public int FeaturedRoomGroupId { get; set; }

      public string Name { get; set; }

      public DateTime StartAt { get; set; }

      public DateTime EndAt { get; set; }

      public List<CommunityBoard.Room> Rooms { get; set; }
    }

    public class CurrentAnnouncement
    {
      public string Message { get; set; }

      public string MoreInfoUrl { get; set; }
    }

    public class InstagramImage
    {
      public object ImageName { get; set; }

      public object ImageUrl { get; set; }
    }

    public class Video
    {
      public object BlobName { get; set; }

      public string Title { get; set; }

      public object Description { get; set; }

      public string ThumbnailBlobName { get; set; }

      public string SourceUrl { get; set; }
    }
  }
}

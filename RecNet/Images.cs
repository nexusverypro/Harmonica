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
  internal class Images
  {
    public static int imagenum;

    public static string CurrentNamed() => JsonConvert.SerializeObject((object) new List<Images.Image>()
    {
      new Images.Image()
      {
        FriendlyImageName = "DormRoomBucket",
        ImageName = "n/67gesMhbOkCd3-qO1cKkIg",
        StartTime = DateTime.Parse("2018-09-27T18:00:00Z"),
        EndTime = DateTime.Parse("2222-02-22T22:22:00Z")
      }
    });

    public static string GetCheeredBulk() => "[]";

    public static List<Images.RoomImage> GetRoomImage(int room)
    {
      ++Images.imagenum;
      return new List<Images.RoomImage>()
      {
        new Images.RoomImage()
        {
          Id = Images.imagenum,
          Type = 1,
          Accessibility = 1,
          AccessibilityLocked = false,
          ImageName = "DefaultProfileImage",
          Description = "Harmonica room image test",
          PlayerId = Accounts.MyAccountData().accountId,
          TaggedPlayerIds = new List<int>()
          {
            Accounts.MyAccountData().accountId
          },
          RoomId = room,
          PlayerEventId = Accounts.MyAccountData().accountId + 273,
          CreatedAt = DateTime.Now,
          CheerCount = 999,
          CommentCount = 0
        }
      };
    }

    public class ImageUploadResponse
    {
      public string ImageName { get; set; }

      public ImageUploadResponse(string name) => this.ImageName = name;
    }

    public class SavedImageMetaDTO
    {
      public List<int> playerIds;
      public Images.SavedImageType savedImageType;
      public long roomId;
      public long playerEventId;
      public Images.SavedImageAccessibility accessibility;
    }

    public enum SavedImageAccessibility
    {
      Private,
      Public,
      FriendsOnly,
    }

    public enum SavedImageType
    {
      None,
      ShareCamera,
      OutfitThumbnail,
      RoomThumbnail,
      ProfileThumbnail,
      InventionThumbnail,
    }

    public class RoomImage
    {
      public int Id { get; set; }

      public int Type { get; set; }

      public int Accessibility { get; set; }

      public bool AccessibilityLocked { get; set; }

      public string ImageName { get; set; }

      public string Description { get; set; }

      public int PlayerId { get; set; }

      public List<int> TaggedPlayerIds { get; set; }

      public int RoomId { get; set; }

      public int PlayerEventId { get; set; }

      public DateTime CreatedAt { get; set; }

      public int CheerCount { get; set; }

      public int CommentCount { get; set; }
    }

    public class Image
    {
      public string FriendlyImageName { get; set; }

      public string ImageName { get; set; }

      public DateTime StartTime { get; set; }

      public DateTime EndTime { get; set; }
    }
  }
}

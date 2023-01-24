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
  internal class Inventions
  {
    public static string Mine() => JsonConvert.SerializeObject((object) new List<Inventions.Invention>());

    public static string GetInvention(int inventionId, int version) => JsonConvert.SerializeObject((object) new Inventions.InventionDetail()
    {
      InventionId = inventionId,
      ReplicationId = (string) null,
      VersionNumber = version,
      BlobName = (object) null,
      BlobHash = (string) null,
      InstantiationCost = 0,
      LightsCost = 0,
      ChipsCost = 0,
      CloudVariablesCost = 0
    });

    public static string Featured() => JsonConvert.SerializeObject((object) new List<Inventions.Invention>()
    {
      new Inventions.Invention()
      {
        InventionId = 1,
        ReplicationId = Guid.NewGuid().ToString(),
        CreatorPlayerId = 1,
        Name = "Rec Room Invention",
        Description = "Harmonica",
        ImageName = "DefaultProfileImage",
        CurrentVersionNumber = 1,
        IsPublished = true,
        IsFeatured = true,
        ModifiedAt = DateTime.UtcNow,
        CreatedAt = DateTime.UtcNow,
        FirstPublishedAt = (object) null,
        CreationRoomId = 0,
        NumPlayersHaveUsedInRoom = 999999999,
        NumDownloads = 999999999,
        CheerCount = 999999999,
        CreatorPermission = 0,
        GeneralPermission = 0,
        IsAGInvention = true,
        IsCertifiedInvention = true,
        Price = (object) 999,
        AllowTrial = true,
        HideFromPlayer = false
      },
      new Inventions.Invention()
      {
        InventionId = 1,
        ReplicationId = Guid.NewGuid().ToString(),
        CreatorPlayerId = 1,
        Name = "Rec Room Invention",
        Description = "Harmonica",
        ImageName = "DefaultProfileImage",
        CurrentVersionNumber = 1,
        IsPublished = true,
        IsFeatured = true,
        ModifiedAt = DateTime.UtcNow,
        CreatedAt = DateTime.UtcNow,
        FirstPublishedAt = (object) null,
        CreationRoomId = 0,
        NumPlayersHaveUsedInRoom = 999999999,
        NumDownloads = 999999999,
        CheerCount = 999999999,
        CreatorPermission = 0,
        GeneralPermission = 0,
        IsAGInvention = true,
        IsCertifiedInvention = true,
        Price = (object) 999,
        AllowTrial = true,
        HideFromPlayer = false
      },
      new Inventions.Invention()
      {
        InventionId = 1,
        ReplicationId = Guid.NewGuid().ToString(),
        CreatorPlayerId = 1,
        Name = "Rec Room Invention",
        Description = "Harmonica",
        ImageName = "DefaultProfileImage",
        CurrentVersionNumber = 1,
        IsPublished = true,
        IsFeatured = true,
        ModifiedAt = DateTime.UtcNow,
        CreatedAt = DateTime.UtcNow,
        FirstPublishedAt = (object) null,
        CreationRoomId = 0,
        NumPlayersHaveUsedInRoom = 999999999,
        NumDownloads = 999999999,
        CheerCount = 999999999,
        CreatorPermission = 0,
        GeneralPermission = 0,
        IsAGInvention = true,
        IsCertifiedInvention = true,
        Price = (object) 999,
        AllowTrial = true,
        HideFromPlayer = false
      },
      new Inventions.Invention()
      {
        InventionId = 1,
        ReplicationId = Guid.NewGuid().ToString(),
        CreatorPlayerId = 1,
        Name = "Rec Room Invention",
        Description = "Harmonica",
        ImageName = "DefaultProfileImage",
        CurrentVersionNumber = 1,
        IsPublished = true,
        IsFeatured = true,
        ModifiedAt = DateTime.UtcNow,
        CreatedAt = DateTime.UtcNow,
        FirstPublishedAt = (object) null,
        CreationRoomId = 0,
        NumPlayersHaveUsedInRoom = 999999999,
        NumDownloads = 999999999,
        CheerCount = 999999999,
        CreatorPermission = 0,
        GeneralPermission = 0,
        IsAGInvention = true,
        IsCertifiedInvention = true,
        Price = (object) 999,
        AllowTrial = true,
        HideFromPlayer = false
      },
      new Inventions.Invention()
      {
        InventionId = 1,
        ReplicationId = Guid.NewGuid().ToString(),
        CreatorPlayerId = 1,
        Name = "Rec Room Invention",
        Description = "Harmonica",
        ImageName = "DefaultProfileImage",
        CurrentVersionNumber = 1,
        IsPublished = true,
        IsFeatured = true,
        ModifiedAt = DateTime.UtcNow,
        CreatedAt = DateTime.UtcNow,
        FirstPublishedAt = (object) null,
        CreationRoomId = 0,
        NumPlayersHaveUsedInRoom = 999999999,
        NumDownloads = 999999999,
        CheerCount = 999999999,
        CreatorPermission = 0,
        GeneralPermission = 0,
        IsAGInvention = true,
        IsCertifiedInvention = true,
        Price = (object) 999,
        AllowTrial = true,
        HideFromPlayer = false
      },
      new Inventions.Invention()
      {
        InventionId = 1,
        ReplicationId = Guid.NewGuid().ToString(),
        CreatorPlayerId = 1,
        Name = "Rec Room Invention",
        Description = "Harmonica",
        ImageName = "DefaultProfileImage",
        CurrentVersionNumber = 1,
        IsPublished = true,
        IsFeatured = true,
        ModifiedAt = DateTime.UtcNow,
        CreatedAt = DateTime.UtcNow,
        FirstPublishedAt = (object) null,
        CreationRoomId = 0,
        NumPlayersHaveUsedInRoom = 999999999,
        NumDownloads = 999999999,
        CheerCount = 999999999,
        CreatorPermission = 0,
        GeneralPermission = 0,
        IsAGInvention = true,
        IsCertifiedInvention = true,
        Price = (object) 999,
        AllowTrial = true,
        HideFromPlayer = false
      }
    });

    public class Invention
    {
      public int InventionId { get; set; }

      public string ReplicationId { get; set; }

      public int CreatorPlayerId { get; set; }

      public string Name { get; set; }

      public string Description { get; set; }

      public string ImageName { get; set; }

      public int CurrentVersionNumber { get; set; }

      public bool IsPublished { get; set; }

      public bool IsFeatured { get; set; }

      public DateTime ModifiedAt { get; set; }

      public DateTime CreatedAt { get; set; }

      public object FirstPublishedAt { get; set; }

      public int CreationRoomId { get; set; }

      public int NumPlayersHaveUsedInRoom { get; set; }

      public int NumDownloads { get; set; }

      public int CheerCount { get; set; }

      public int CreatorPermission { get; set; }

      public int GeneralPermission { get; set; }

      public bool IsAGInvention { get; set; }

      public bool IsCertifiedInvention { get; set; }

      public object Price { get; set; }

      public bool AllowTrial { get; set; }

      public bool HideFromPlayer { get; set; }
    }

    public class InventionDetail
    {
      public int InventionId { get; set; }

      public string ReplicationId { get; set; }

      public int VersionNumber { get; set; }

      public object BlobName { get; set; }

      public string BlobHash { get; set; }

      public int InstantiationCost { get; set; }

      public int LightsCost { get; set; }

      public int ChipsCost { get; set; }

      public int CloudVariablesCost { get; set; }
    }
  }
}

// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Newtonsoft.Json;
using System.Collections.Generic;

namespace RecNet
{
  internal class Equipment
  {
    public static List<Equipment> LocalEquipment;

    public static string GetUnlocked()
    {
      Equipment.LocalEquipment = new List<Equipment>()
      {
        new Equipment()
        {
          PrefabName = "[MakerPen]",
          ModificationGuid = "204f84a2-6ee2-45e1-9168-87f43e893e32",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Maker Pen (Wood)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[MakerPen]",
          ModificationGuid = "BGhlN3FKGEy6w-vwc28V4A",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Maker Pen (Beach)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[MakerPen]",
          ModificationGuid = "h4xKGsHcTUy3iH7PVFjb2w",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Maker Pen (Host1)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Basketball]",
          ModificationGuid = "bNEcMJOzokeEVKDeXk_cDQ",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Basketball (Gold)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[BowlingBall]",
          ModificationGuid = "BvUZUamUh0uDbjDOrQrX1A",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Bowling Ball (Gold)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[DiscGolfDisc]",
          ModificationGuid = "5d3c3b16-713e-43d8-88e0-7633063091da",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Disc (Gold)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Dodgeball]",
          ModificationGuid = "Jkg-OGXdIUyfEwaQIh6EGA",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Dodgeball (Gold)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballGun] Confetti",
          ModificationGuid = "bfrFOdnHzEaIwHqem2dXkg",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Confetti Gun (Gold)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballGun]",
          ModificationGuid = "bc4254be-60e0-4cc5-a233-6a0bd4137118",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Paintball Gun (Gold)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballShotgun]",
          ModificationGuid = "053c24a0-82a2-43f5-b0e7-e56db05a10ba",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Paintball Shotgun (Gold)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballShotgun]",
          ModificationGuid = "CwIBKjm3G0-xUGt_9Gf7UQ",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Paintball Shotgun (Caution)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballShotgun]",
          ModificationGuid = "f27af5d7-c741-4457-8c98-8e8791f1a41c",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Paintball Shotgun (Plaid)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballShotgun]",
          ModificationGuid = "61e49c13-b414-425f-8e8b-bdcf3d12a5bf",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Paintball Shotgun (Wood)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballShotgun]",
          ModificationGuid = "ZMAx_-B_7kWy6-TLXx8g6Q",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Paintball Shotgun (Watermelon)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballAssaultRifle]",
          ModificationGuid = "2vhCtZjRd0i_nYo04ij__w",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Paintball AssaultRifle (Ghost)",
          Tooltip = "Unreleased...",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballAssaultRifle]",
          ModificationGuid = "m_qzPvDPF0KPhLd59wzr5A",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Paintball AssaultRifle (Fall)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballAssaultRifle]",
          ModificationGuid = "996662ad-631d-4a81-8a8b-74ace4833279",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Paintball AssaultRifle (Pirate)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballAssaultRifle]",
          ModificationGuid = "3aaef60d-142f-4a0a-bea3-f5d99ab62dd5",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Paintball AssaultRifle (Plaid)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballAssaultRifle]",
          ModificationGuid = "357fe573-fee7-467f-93a7-5e61afb024b8",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Paintball AssaultRifle (Wood)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballAssaultRifle]",
          ModificationGuid = "VOOdhP5qg0WWv2m0qLRVCw",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Paintball AssaultRifle (Gold)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballAssaultRifle]",
          ModificationGuid = "c458a6ae-a1ea-468a-89b8-4c9a85cd3cde",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Paintball AssaultRifle (Caution)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballGun]",
          ModificationGuid = "7ef5d1d9-24db-428c-85e0-107c1bfcc026",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Paintball Gun (Orange)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballGun]",
          ModificationGuid = "b8d5612b-2c6f-46d6-9412-decddac7d4c1",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Paintball Gun (Pirate)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballGun]",
          ModificationGuid = "ec5ef0f3-c072-45ec-bb8f-3781fb16e067",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Paintball Gun (Plaid)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballGun]",
          ModificationGuid = "4aff20ee-0b20-434b-a030-d3e1764fe4e7",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Paintball Gun (Purple)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballGun]",
          ModificationGuid = "z0Xw8_BUZUODrGHSZcLHHQ",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Paintball Gun (Valentines)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballGun]",
          ModificationGuid = "36751c4a-86a9-40e1-bef2-84f962ab678d",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Paintball Gun (Vitton)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballGun]",
          ModificationGuid = "33c84c50-7c2e-4a80-ad06-79c4f20f829e",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Paintball Gun (Wood)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[MakerPen]",
          ModificationGuid = "4HJ3wRmSZUuhMRUTA67dpA",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Maker Pen (Professor)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[MakerPen]",
          ModificationGuid = "RPWXRfZwfUeC9PFlvcbmxw",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Maker Pen (Carnival)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[MakerPen]",
          ModificationGuid = "wultE5yRpkuJREeJw4prKg",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Maker Pen (Dragon)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[MakerPen]",
          ModificationGuid = "j83FD3aSQ0OUcrp4QIIZsA",
          Favorited = true,
          PlatformMask = -1,
          FriendlyName = "Maker Pen (Developer)",
          Tooltip = "Only Developer's have this item.",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[MakerPen]",
          ModificationGuid = "4HJ3wRmSZUuhMRUTA67dpA",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Maker Pen (Green)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[MakerPen]",
          ModificationGuid = "tvjYGeRdwEqnr9mf84WgcQ",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Maker Pen (Red)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[MakerPen]",
          ModificationGuid = "Q7Tr_0DXAkOdr61UXiocow",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Maker Pen (Yellow)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[MakerPen]",
          ModificationGuid = "iRtlLKI-X0S9oYUWLenAKQ",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Maker Pen (Purple)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[MakerPen]",
          ModificationGuid = "WwtFcRluQkmnCI_qH75L_Q",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Maker Pen (Orange)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[MakerPen]",
          ModificationGuid = "c1VRbmDGHUS7KiSgwj5prQ",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Maker Pen (Pink)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[MakerPen]",
          ModificationGuid = "MODdVYrjaEy-iy6quALNuA",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Maker Pen (White)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[MakerPen]",
          ModificationGuid = "HyL83wPtf06DG6nsHofoeA",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Maker Pen (Steampunk)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[MakerPen]",
          ModificationGuid = "Pw1XcUfAck2tNh0fIAu8LA",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Maker Pen (Waves)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[MakerPen]",
          ModificationGuid = "i3NgZvTwkUSMsXRpqCgSZA",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Maker Pen (Wonderland)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[MakerPen]",
          ModificationGuid = "juFHwn9UjEiGaWyNnoxbtA",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Maker Pen (Pumpkin)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[MakerPen]",
          ModificationGuid = "79090a4b-e191-4788-9210-88a7bdf6d828",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Maker Pen (Luxury)",
          Tooltip = "",
          Rarity = 5
        },
        new Equipment()
        {
          PrefabName = "[ShareCamera]",
          ModificationGuid = "e2844f84-ab44-4141-9a0a-bd5da7caa4f6",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Share Camera (Disposable)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[ShareCamera]",
          ModificationGuid = "1838fa61-de10-4e09-b24a-f5a1bc942600",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Share Camera (Green)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[ShareCamera]",
          ModificationGuid = "d218ae45-8534-4f96-b2ed-1cf281bc3578",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Share Camera (Wood)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[ShareCamera]",
          ModificationGuid = "znrJSCX_SkS-kIPqMERoDg",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Share Camera (Camping)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[ShareCamera]",
          ModificationGuid = "fSbzGxsjKE-cwtFFX6dJQw",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Share Camera (Carpet)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[ShareCamera]",
          ModificationGuid = "SkTa53OzM0u82YPuZAl9aw",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Share Camera (Caution)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[ShareCamera]",
          ModificationGuid = "g5u0weNLmkCLeUXFUVn74Q",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Share Camera (Comic)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[ShareCamera]",
          ModificationGuid = "QQALCzCF-0ClDWqmmciHAQ",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Share Camera (Heart)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[ShareCamera]",
          ModificationGuid = "sE4_-ZVa2EC4MZfGGsExzQ",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Share Camera (Plaid)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[ShareCamera]",
          ModificationGuid = "ATGtNjai20miFwBUOVIMuw",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Share Camera (TwoTone)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Quest_SciFi_Pistol]",
          ModificationGuid = "8a2a3219-fed0-4403-9061-451d162307c2",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Laser Pistol (CandyCane)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Quest_SciFi_Pistol]",
          ModificationGuid = "5nQ2kF6h6kunbk5z18Lozg",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Laser Pistol (Frakenblaster)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Quest_SciFi_Pistol]",
          ModificationGuid = "dRvcMuM__02iMsRwKEPtXQ",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Laser Pistol (Gold)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Quest_SciFi_Pistol]",
          ModificationGuid = "aByJShU520OzdOXBV8o0Dg",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Laser Pistol (Plaid)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Quest_SciFi_Pistol]",
          ModificationGuid = "0cFcVYCLTU6CKhr9uADrbw",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Laser Pistol (Recasso)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Quest_SciFi_Pistol]",
          ModificationGuid = "33a7a3dc-5266-4075-b56f-5eaa2c400e9f",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Laser Pistol (Caution)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Quest_SciFi_Pistol]",
          ModificationGuid = "89b1fbbc-e7be-440b-8b22-8fd379c1a568",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Laser Pistol (PINK)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Quest_SciFi_Pistol]",
          ModificationGuid = "db91b61b-ab32-4895-8f5a-0212c1283cbb",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Laser Pistol (Vitton)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[DiscGolfDisc]",
          ModificationGuid = "7877964e-3a2b-4818-8513-0e26a707bd7c",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Disc (Clear)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[DiscGolfDisc]",
          ModificationGuid = "19ef59c7-f74b-4c63-935a-1d4b1abd8518",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Disc (Coop)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[DiscGolfDisc]",
          ModificationGuid = "2b70a76e-6f48-402e-90ff-40b06aa23eb8",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Disc (Coach Select)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[DiscGolfDisc]",
          ModificationGuid = "9d2a3618-12b3-4ca0-be59-ed15d7926d77",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Disc (Laser)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[DiscGolfDisc]",
          ModificationGuid = "bd3f6aa5-c6e0-4e06-901d-1176accf1003",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Disc (Wood)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[DodgeballBall]",
          ModificationGuid = "6261a846-e4f8-4e6e-8aa0-68f38cd788d4",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Dodgeball (Comic)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[DodgeballBall]",
          ModificationGuid = "f55dda45-c17e-4237-a638-9f326d306e7d",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Dodgeball (Goblin)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[DodgeballBall]",
          ModificationGuid = "lIpyvEMWqUyv41gTp3YZ1A",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Dodgeball (Pumpkin)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[DodgeballBall]",
          ModificationGuid = "6ff63f8f-4bcc-4b69-8d89-8b886d19e239",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Dodgeball (Recasso)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Grenade]",
          ModificationGuid = "993f8b81-cb2e-44e4-88a1-b841af1f0e69",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Grenade (Pirate)",
          Tooltip = "Never coming out...",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[SciFi_Grenade]",
          ModificationGuid = "993f8b81-cb2e-44e4-88a1-b841af1f0e69",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Grenade (Pirate)",
          Tooltip = "Never coming out...",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[RecRoyale_Grenade]",
          ModificationGuid = "993f8b81-cb2e-44e4-88a1-b841af1f0e69",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Grenade (Pirate)",
          Tooltip = "Never coming out...",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Arena_Grenade]",
          ModificationGuid = "993f8b81-cb2e-44e4-88a1-b841af1f0e69",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Grenade (Pirate)",
          Tooltip = "Never coming out...",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Longbow]",
          ModificationGuid = "JBp7CxPhrUC5hnn2EISUFA",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Bow (Dryad)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Longbow]",
          ModificationGuid = "XKFuhM3zikyxTYtTzuPb_A",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Bow (Dryad Fall)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Longbow]",
          ModificationGuid = "52c6a138-10c5-4aab-9c3b-04b50c9a2dc5",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Bow (Ghost)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Longbow]",
          ModificationGuid = "f5901f11-b315-4261-9474-2da207e4a229",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Bow (Vitton)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Longbow]",
          ModificationGuid = "T8666vuehkObksBdVbla9g",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Bow (Plaid)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Longbow]",
          ModificationGuid = "YajcGvBcTEaf_MjCbxOciw",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Bow (Caution)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Longbow]",
          ModificationGuid = "XpxqrY6RYkafs-sd3Z0ZLw",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Bow (Rainbow)",
          Tooltip = "gay.",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Longbow]",
          ModificationGuid = "e738d936-0f75-423b-88bb-f626ffba573a",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Bow (Rock)",
          Tooltip = "rockpikmin skin!11",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Longbow]",
          ModificationGuid = "gl_tlo_t7U-H308Omy13lw",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Bow (Spring)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Longbow]",
          ModificationGuid = "uPwTBnfWwkWXuyAaAMqeQA",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Bow (Winter)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballRifleScoped]",
          ModificationGuid = "d906709c-e08e-4273-8ba1-e072e0d25957",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Paintball Sniper (Candy Cane)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballRifleScoped]",
          ModificationGuid = "OSrMlhVVSEqb-0AzVzOH9w",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Paintball Sniper (Gold)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballRifleScoped]",
          ModificationGuid = "0dM2SfqGR0SmtO5ufTWfUQ",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Paintball Sniper (Comic)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballRifleScoped]",
          ModificationGuid = "b_iiMMYayU-an7hOlCzPIA",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Paintball Sniper (Caution)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballRifleScoped]",
          ModificationGuid = "3rBevbIk1EusFnFaXAh3qA",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Paintball Sniper (GingerBread)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballRifleScoped]",
          ModificationGuid = "6a6b0ecf-286d-4361-92ff-7027c440dc3c",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Paintball Sniper (Plaid)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballRifleScoped]",
          ModificationGuid = "btB2z7ybskSYrn9Nzhfhxg",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Paintball Sniper (Wood)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballGrenadeLauncher]",
          ModificationGuid = "f34e6270-bcfa-42f2-80d5-69c1bbd34983",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Grenade Launcher (Comic)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballGrenadeLauncher]",
          ModificationGuid = "8ZAwSDtXlkqlnBLOpfVTVg",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Grenade Launcher (Gingerbread)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballGrenadeLauncher]",
          ModificationGuid = "3UmIhvqmkU-aWxFDFd4QDg",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Grenade Launcher (Honey)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballGrenadeLauncher]",
          ModificationGuid = "tcMMGKcmhkuM82ISCZ-3AQ",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Grenade Launcher (Caution)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballGrenadeLauncher]",
          ModificationGuid = "pPpYY9j0Dku2gtbKoUOCCg",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Grenade Launcher (Easter)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballGrenadeLauncher]",
          ModificationGuid = "502f40c3-1c00-4c3f-bfc7-c897df8af37e",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Grenade Launcher (Plaid)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballGrenadeLauncher]",
          ModificationGuid = "9gBl778RvUeSC8837Gurog",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Grenade Launcher (Wood)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballShield]",
          ModificationGuid = "jZ7wlwRxgUuWYuLasbnG8w",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Shield (Sunset)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballShield]",
          ModificationGuid = "gfGhbEMx_kCRdO-6vPOh3g",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Shield (Plaid)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballShield]",
          ModificationGuid = "ClJApV0LC0mxh0UiYhaXGQ",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Shield (Caution)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballShield]",
          ModificationGuid = "QTyRLpDB3UuReHQqrKxb5A",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Shield (Gingerbread)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballShield]",
          ModificationGuid = "a6c869d9-8f30-4ce6-a7ea-cb7ea9f9d492",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Shield (Pirate)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballShield]",
          ModificationGuid = "174adb53-bc6e-4fcf-b03d-a00fc3deeb49",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Shield (Wood)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballShield]",
          ModificationGuid = "174adb53-bc6e-4fcf-b03d-a00fc3deeb49",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Shield (Wood)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[PaintballShield]",
          ModificationGuid = "174adb53-bc6e-4fcf-b03d-a00fc3deeb49",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Shield (Wood)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Paintball_PaintThrower]",
          ModificationGuid = "y_FesIT5jkmb61JIu7tfsw",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Shield (Wood)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Paintball_PaintThrower]",
          ModificationGuid = "GbHNkVbVgUCoirMhOGkSTA",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Paint Thrower (Plaid)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Paintball_PaintThrower]",
          ModificationGuid = "qhhhJeHVx0KLnGJrAGIn9g",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Paint Thrower (Caution)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Paintball_PaintThrower]",
          ModificationGuid = "VTVy8cweC0K2ca1nTXMu0g",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Paint Thrower (Double Drencher)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Paintball_PaintThrower]",
          ModificationGuid = "OFEdf4dRC0a3nHugXVOXnA",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Paint Thrower (Fireworks)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Paintball_PaintThrower]",
          ModificationGuid = "y_FesIT5jkmb61JIu7tfsw",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Paint Thrower (Wood)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[QuestShield]",
          ModificationGuid = "a9a3292c-8ccf-4564-aeb1-124c52057ef2",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Quest Shield (Black & Gold)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[QuestShield]",
          ModificationGuid = "RQCgWA3Pf0KTqznUR58-lw",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Quest Shield (Caution)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[QuestShield]",
          ModificationGuid = "2389fce4-3ab2-4e05-918c-845eb8538bed",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Quest Shield (Goblin)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[QuestShield]",
          ModificationGuid = "L9usPszLFkiA6xs32es2Lw",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Quest Shield (Neon) (RR+)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[QuestShield]",
          ModificationGuid = "439be0eb-4d1e-4c80-97f8-b4636d0ce94b",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Quest Shield (Pride)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[QuestShield]",
          ModificationGuid = "-rbKD_ztMUq69Nv4tLrrVA",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Quest Shield (Snowflake)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[QuestShield]",
          ModificationGuid = "eb90210a-6d2d-4429-b1e0-3285333685fc",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Quest Shield (Valentines)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[QuestShield]",
          ModificationGuid = "735b06c6-1b78-4f60-9291-a414a96cd228",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Quest Shield (Wood)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[QuestSword]",
          ModificationGuid = "eecdf81c-7ba2-40ba-9d6c-f461708cce16",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Quest Sword (Comic)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[QuestSword]",
          ModificationGuid = "K9TzHZPDwU-ewzLYkr_1cg",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Quest Sword (Gingerbread)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[QuestSword]",
          ModificationGuid = "m1JMjJYpSUiXj5897orm2Q",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Quest Sword (Plaid)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[QuestSword]",
          ModificationGuid = "Kitcy2AVB0-OdljiEAI2Pw",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Quest Sword (Recasso)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[QuestSword]",
          ModificationGuid = "d97pbQMk9UWpEN0yoOE9Rg",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Quest Sword (Caution)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[QuestSword]",
          ModificationGuid = "wioj1rR1lkCx7f-oiCHcOw",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Quest Sword (Sword on the Cob)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[QuestSword]",
          ModificationGuid = "0ee04d78-5a17-4a38-ae67-b576a41fc200",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Quest Sword (Extra)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[QuestSword]",
          ModificationGuid = "431567d2-4df2-43eb-b632-3d79aa7c013c",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Quest Sword (Gold)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[QuestSword]",
          ModificationGuid = "DRXoMS9phEG2fkasja7sEw",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Quest Sword (Lava)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[QuestSword]",
          ModificationGuid = "f03dee6a-79b8-4906-9abb-a821748d97a9",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Quest Sword (Red)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[QuestSword]",
          ModificationGuid = "3e46fb2d-bb3f-42ed-83ef-f5716860725c",
          PlatformMask = -1,
          FriendlyName = "Quest Sword (Rock)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Quest_Goblin_Wand]",
          ModificationGuid = "e8e42ef6-9ab6-44f4-84d5-117154a4d13e",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Wand (Ghost)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Quest_Goblin_Wand]",
          ModificationGuid = "3pE7zA-DjkqP1Ch7__-31w",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Wand (Ice)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Quest_Goblin_Wand]",
          ModificationGuid = "vfzrRHn24E67BK8Bgy60xA",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Wand (Caution)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Quest_Goblin_Wand]",
          ModificationGuid = "CyrdBvIbXUq_TsXFliWk1A",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Wand (Plaid)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Quest_Goblin_Wand]",
          ModificationGuid = "yG6xFxkoS0iIDt7wEj5Hqw",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Wand (Witch)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Quest_Goblin_Wand]",
          ModificationGuid = "QnLM4Qw-L0ml_mgReFweIw",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Wand (Trident)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Quest_SciFi_AutomaticGun]",
          ModificationGuid = "u60IW1Gt10eC-8SlZmQUNQ",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Laser Rifle (Recasso)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Quest_SciFi_AutomaticGun]",
          ModificationGuid = "bafacc36-02c6-408c-a3f5-8c2aa07a68db",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Laser Rifle (Arbor)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Quest_SciFi_AutomaticGun]",
          ModificationGuid = "546b3a57-13d4-4c35-ab3a-bbb7d466f0b8",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Laser Rifle (Caution)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Quest_SciFi_AutomaticGun]",
          ModificationGuid = "dEmh0tniCkeYBY1EdD09jA",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Laser Rifle (Zombie)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Quest_SciFi_AutomaticGun]",
          ModificationGuid = "dEmh0tniCkeYBY1EdD09jA",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Laser Rifle (Zombie)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Quest_SciFi_Shotgun]",
          ModificationGuid = "pIRihZheSEW2Ld3VTLkB-g",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Shotgun (Plaid)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Quest_SciFi_Shotgun]",
          ModificationGuid = "55a9c1e8-07e2-4457-86f2-75fd5e67b1f3",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Shotgun (Caution)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Quest_SciFi_Shotgun]",
          ModificationGuid = "bb36b722-16dc-4172-b61f-237dc1240040",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Shotgun (Jackolantern)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Quest_SciFi_Shotgun]",
          ModificationGuid = "83d7cca0-2c5d-41b2-a5b2-f79fd89f3037",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Shotgun (PINK)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Quest_SciFi_Shotgun]",
          ModificationGuid = "gjuFgDp-LUWPi1mPCKyqbA",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Shotgun (Shamrock)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Quest_SciFi_Shotgun]",
          ModificationGuid = "cd497ae2-6382-42f2-9f92-93d5141588c3",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Shotgun (Shamrock)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[RecRoyale_Backpack]",
          ModificationGuid = "ujZ4Hl0HO06OysqZcqHhmg",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Backpack (Gold)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[RecRoyale_Backpack]",
          ModificationGuid = "523e3615-4633-41a3-9b2d-17d3207a684b",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Backpack (Camo)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[RecRoyale_Backpack]",
          ModificationGuid = "6c3b26cd-b38e-492b-a124-759cbcec1396",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Backpack (Camping)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[RecRoyale_Backpack]",
          ModificationGuid = "5c848a04-f528-423b-8be1-4b5cd43a75c2",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Backpack (Denim)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[RecRoyale_Backpack]",
          ModificationGuid = "70uy5UJhhEy1aynKM4MAsQ",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Backpack (Fall)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[RecRoyale_Backpack]",
          ModificationGuid = "e93f5ab7-e9bf-4652-8a7c-2ae120f25f87",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Backpack (Recasso)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[RecRoyale_Backpack]",
          ModificationGuid = "12b54ad2-3847-41db-9ed4-88e8dad63024",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Backpack (Tiger)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[RecRoyale_Backpack]",
          ModificationGuid = "w2NNBTTCVEah2WlP0JHezQ",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Backpack (Valentine)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Quest_SciFi_RailGun]",
          ModificationGuid = "X9gTAbp0Sk6nadpTBseRrg",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Rail Gun (Lifeguard)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Quest_SciFi_RailGun]",
          ModificationGuid = "_flhynGnykyZL7F83B7rJQ",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Rail Gun (Plaid)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Quest_SciFi_RailGun]",
          ModificationGuid = "63a867d7-ccea-4905-b6e0-e6dcfba06f9e",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Rail Gun (Caution)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Quest_SciFi_RailGun]",
          ModificationGuid = "uvbozCned0igzscgeBlRpQ",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Rail Gun (Galaxy)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Quest_SciFi_RailGun]",
          ModificationGuid = "46977ca7-ee75-4e2a-b8aa-0763879f8a96",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Rail Gun (PINK)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Bucket]",
          ModificationGuid = "VW3WV6oQOkqYshf1xc9n3A",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Bucket (Swirl)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Bucket]",
          ModificationGuid = "ou23DX__T0qFPjAXC5WrOQ",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Bucket (Fashion)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Crossbow]",
          ModificationGuid = "T6PzFfg41UaQ7EAqts6gsw",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Crossbow (Bones)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Crossbow]",
          ModificationGuid = "6bba14be-f207-4933-b09f-f0fd3e28c10c",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Crossbow (CandyCane)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Crossbow]",
          ModificationGuid = "VHFKZVhiRkylcxnxzCKUuw",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Crossbow (Caution)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Crossbow]",
          ModificationGuid = "jHaoDSAtikyAI82lO53o9g",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Crossbow (Dyrad)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Crossbow]",
          ModificationGuid = "ESQ0qOlgrkCc8MbUXGnF8Ag",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Crossbow (Plaid)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Crossbow]",
          ModificationGuid = "1d09c8e4-78c2-49f9-acb7-8f0b3ff6a5ed",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Crossbow (Recasso)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Crossbow]",
          ModificationGuid = "QEwDZYj_OEi5l86LBnuYGw",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Crossbow (Rock)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Crossbow]",
          ModificationGuid = "ych0ntYcK0eiq67bCLlbew",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Crossbow (Spring)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Crossbow]",
          ModificationGuid = "4d70545-cdf1-4fb1-924b-613de0327faf",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Crossbow (Vitton)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Crossbow]",
          ModificationGuid = "CZAIad-ME0O0iIy77MRxBw",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Crossbow (Winter)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Crossbow]",
          ModificationGuid = "MsFoMeUZ8Eq2qX9SrOtRPA",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Crossbow (Waves)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[CrossbowBolt]",
          ModificationGuid = "17fe7b44-3169-4bbc-b176-c104b8c2c167",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Crossbow (Vitton)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Crossbow_Hunter]",
          ModificationGuid = "RRCvths6eUmAAr9hzGFT0g",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Crossbow Hunter (Caution)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Crossbow_Hunter]",
          ModificationGuid = "cFMh54GoHEeHZEERSRR8kQ",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Crossbow Hunter (Plaid)",
          Tooltip = "",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Crossbow_Hunter]",
          ModificationGuid = "d217ee4c-22f3-4f33-bf7c-9d4ee9c30e29",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Crossbow Hunter (Rock)",
          Tooltip = "rockpikmin skin part 2!11",
          Rarity = 0
        },
        new Equipment()
        {
          PrefabName = "[Crossbow_Hunter]",
          ModificationGuid = "-X_Hm6dIekqoHTY2VMMLeA",
          Favorited = false,
          PlatformMask = -1,
          FriendlyName = "Crossbow Hunter (Shark)",
          Tooltip = "daddy shark doo doo doo..",
          Rarity = 0
        }
      };
      return JsonConvert.SerializeObject((object) Equipment.LocalEquipment);
    }

    public string PrefabName { get; set; }

    public string ModificationGuid { get; set; }

    public bool Favorited { get; set; }

    public int PlatformMask { get; set; }

    public string FriendlyName { get; set; }

    public string Tooltip { get; set; }

    public int Rarity { get; set; }
  }
}

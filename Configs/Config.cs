// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using OldAPIs;
using System;
using System.Collections.Generic;
using System.IO;

namespace Configs
{
  public class Config
  {
    public static bool LogMessages = true;
    public static string AuthToken = "";
    public static int APIServerPort = 56700;
    public static int webSocketPort = 56701;
    public static int nameServerPort = 56;
    public static Objective[][] dailyObjectives;
    public static Avatar localAvatar;
    public static GameSessions.SessionInstance localGameSession;
    public static UserConfig localPlayer;
    public static ulong playerID;
    public static List<AvatarGift> localGifts;
    public static List<AvatarItem> localItems;
    public static string AppDataPath;
    public static string ServerPlayersDir;
    public static string ServerRootDirectory;
    public static string LocalItemDirectory;
    public static int accountServerPort = 56702;
    public static string localdefaultitems;
    public static int authServerPort = 56703;
    public static int matchServerPort = 56704;
    public static int roomServerPort = 56705;
    public static int clubsServerPort = 56706;
    public static int storageServerPort = 56707;
    public static int cdnServerPort = 56708;
    public static int imageServerPort = 56709;
    public static int commerceServerPort = 56710;
    public static int roomCommentsServerPort = 56711;
    public static int linkServerPort = 56712;
    public static int chatServerPort = 56713;
    public static int leaderboardServerPort = 56714;
    public static bool UseCoachAccount = false;

    public static void SetupDirectorys(ulong serverID)
    {
      Config.ServerPlayersDir = string.Format("{0}Servers\\{1}\\Players\\", (object) Config.AppDataPath, (object) serverID);
      Config.ServerRootDirectory = string.Format("{0}Servers\\{1}\\", (object) Config.AppDataPath, (object) serverID);
      Directory.CreateDirectory(Config.ServerPlayersDir);
      Directory.CreateDirectory(Config.ServerRootDirectory);
    }

    static Config()
    {
      Config.dailyObjectives = new Objective[7][]
      {
        new Objective[3]
        {
          new Objective() { type = 20, score = 1 },
          new Objective() { type = 21, score = 1 },
          new Objective() { type = 22, score = 1 }
        },
        new Objective[3]
        {
          new Objective() { type = 20, score = 1 },
          new Objective() { type = 21, score = 1 },
          new Objective() { type = 22, score = 1 }
        },
        new Objective[3]
        {
          new Objective() { type = 20, score = 1 },
          new Objective() { type = 21, score = 1 },
          new Objective() { type = 22, score = 1 }
        },
        new Objective[3]
        {
          new Objective() { type = 20, score = 1 },
          new Objective() { type = 21, score = 1 },
          new Objective() { type = 22, score = 1 }
        },
        new Objective[3]
        {
          new Objective() { type = 20, score = 1 },
          new Objective() { type = 21, score = 1 },
          new Objective() { type = 22, score = 1 }
        },
        new Objective[3]
        {
          new Objective() { type = 20, score = 1 },
          new Objective() { type = 21, score = 1 },
          new Objective() { type = 22, score = 1 }
        },
        new Objective[3]
        {
          new Objective() { type = 20, score = 1 },
          new Objective() { type = 21, score = 1 },
          new Objective() { type = 22, score = 1 }
        }
      };
      Config.AppDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "2020PartyRoom\\");
      Config.LocalItemDirectory = Environment.CurrentDirectory + "\\Resources\\LocalAvatar";
    }
  }
}

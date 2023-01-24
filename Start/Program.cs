// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Client;
using Configs;
using RecNet;
using RecNet.DataStructures;
using RecNet.Handler;
using Security;
using Servers;
using System;
using System.Collections.Generic;

namespace Start
{
  internal class Program
  {
    public static ulong ServerId;
    public static Dictionary<string, Logger.UserPrefs.Pref> Preferences = new Dictionary<string, Logger.UserPrefs.Pref>();

    private static void Main(string[] args)
    {
      Settings.SetDefaultSettings();
      ClientHandle clientHandle = new ClientHandle();
      Logger.UserPrefs.Initialize();
      Console.Title = "Harmonica";
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine(" /$$      /$$ /$$                                /$$$$$$            /$$                                  \r\n| $$$    /$$$|__/                               /$$__  $$          |__/                                  \r\n| $$$$  /$$$$ /$$ /$$$$$$$   /$$$$$$   /$$$$$$ | $$  \\__/  /$$$$$$  /$$ /$$$$$$/$$$$   /$$$$$$   /$$$$$$$\r\n| $$ $$/$$ $$| $$| $$__  $$ /$$__  $$ /$$__  $$| $$       /$$__  $$| $$| $$_  $$_  $$ /$$__  $$ /$$_____/\r\n| $$  $$$| $$| $$| $$  \\ $$| $$  \\ $$| $$  \\__/| $$      | $$  \\__/| $$| $$ \\ $$ \\ $$| $$$$$$$$|  $$$$$$ \r\n| $$\\  $ | $$| $$| $$  | $$| $$  | $$| $$      | $$    $$| $$      | $$| $$ | $$ | $$| $$_____/ \\____  $$\r\n| $$ \\/  | $$| $$| $$  | $$|  $$$$$$/| $$      |  $$$$$$/| $$      | $$| $$ | $$ | $$|  $$$$$$$ /$$$$$$$/\r\n|__/     |__/|__/|__/  |__/ \\______/ |__/       \\______/ |__/      |__/|__/ |__/ |__/ \\_______/|_______/ \r\n                                                                                                         \r\n                                                                                                        ");
      Console.ResetColor();
      Config.SetupDirectorys(Program.ServerId);
      Console.ForegroundColor = ConsoleColor.Green;
      APIServer2 apiServer2 = new APIServer2();
      CdnServer cdnServer = new CdnServer();
      CommerceServer commerceServer = new CommerceServer();
      ChatServer chatServer = new ChatServer();
      RoomServer roomServer = new RoomServer();
      ClubsServer clubsServer = new ClubsServer();
      ImageServer imageServer = new ImageServer();
      StorageServer storageServer = new StorageServer();
      NameServer nameServer = new NameServer();
      Console.ResetColor();
      Console.Clear();
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.DarkGreen;
      Console.WriteLine("██╗  ██╗ █████╗ ██████╗ ███╗   ███╗ ██████╗ ███╗   ██╗██╗ ██████╗ █████╗     \r\n██║  ██║██╔══██╗██╔══██╗████╗ ████║██╔═══██╗████╗  ██║██║██╔════╝██╔══██╗    \r\n███████║███████║██████╔╝██╔████╔██║██║   ██║██╔██╗ ██║██║██║     ███████║    \r\n██╔══██║██╔══██║██╔══██╗██║╚██╔╝██║██║   ██║██║╚██╗██║██║██║     ██╔══██║    \r\n██║  ██║██║  ██║██║  ██║██║ ╚═╝ ██║╚██████╔╝██║ ╚████║██║╚██████╗██║  ██║    \r\n╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═╝╚═╝     ╚═╝ ╚═════╝ ╚═╝  ╚═══╝╚═╝ ╚═════╝╚═╝  ╚═╝    \r\n                                                                              ");
      Console.ResetColor();
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("Checksum of running application: " + ClientChecker.GetMD5HashFromFile(Environment.CurrentDirectory + "\\Harmonica.exe"));
      Program.Preferences = Logger.UserPrefs.AllPrefs;
      Logger.UserPrefs.AddPref("user_id", Accounts.GetMID().ToString());
      Logger.UserPrefs.AddPref("oobe_has_opened_server", "1");
      Logger.UserPrefs.AddPref("last_version", "20210823");
      MultiplayerPlayer player = new MultiplayerPlayer(new AccountCache(), new Avatar(), new List<MultiplayerPlayer.AvatarItem>());
      clientHandle.AddPlayer(player);
      Logger.UserPrefs.SavePrefCoroutine();
    }
  }
}

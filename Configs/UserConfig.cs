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
  public class UserConfig
  {
    public ulong UserID;
    public string UserName = Players.playerName();
    public string DisplayName = Players.playerName();
    public int XP;
    public int Level;
    public bool Developer;

    public UserConfig(ulong serverID, string userID)
    {
      string str = Config.ServerPlayersDir + userID;
      this.LoadFile(userID);
      if (!(this.UserName == ""))
        return;
      this.UserID = 99999UL;
      this.UserName = Players.playerName();
      this.DisplayName = Players.playerName();
      this.Level = 1;
      this.XP = 1;
      this.Developer = false;
    }

    public UserConfig(ulong serverID)
    {
      string path = Config.ServerPlayersDir + "Local";
      if (File.Exists(path))
      {
        this.LoadFile("Local");
      }
      else
      {
        this.UserID = (ulong) new Random().Next(2, 999999999);
        this.UserName = Players.playerName();
        this.DisplayName = Players.playerName();
        this.Level = 1;
        this.XP = 0;
        this.Developer = false;
        using (BinaryWriter binaryWriter = new BinaryWriter((Stream) File.Create(path)))
        {
          binaryWriter.Write(this.UserID);
          binaryWriter.Write(this.UserName);
          binaryWriter.Write(this.DisplayName);
          binaryWriter.Write(this.Level);
          binaryWriter.Write(this.XP);
          binaryWriter.Write(this.Developer);
        }
        using (BinaryWriter binaryWriter = new BinaryWriter((Stream) File.Create(string.Format("{0}{1}", (object) Config.ServerPlayersDir, (object) this.UserID))))
        {
          binaryWriter.Write(this.UserID);
          binaryWriter.Write(this.UserName);
          binaryWriter.Write(this.DisplayName);
          binaryWriter.Write(this.Level);
          binaryWriter.Write(this.XP);
          binaryWriter.Write(this.Developer);
        }
      }
    }

    public UserConfig(ulong serverID, Dictionary<string, string> postData)
    {
      string path = Config.ServerPlayersDir + "Local";
      if (File.Exists(path))
      {
        this.LoadFile("Local");
      }
      else
      {
        this.UserID = (ulong) new Random().Next(2, 999999999);
        this.UserName = Players.playerName();
        this.DisplayName = Players.playerName();
        this.Level = 1;
        this.XP = 0;
        this.Developer = false;
        using (BinaryWriter binaryWriter = new BinaryWriter((Stream) File.Create(path)))
        {
          binaryWriter.Write(this.UserID);
          binaryWriter.Write(this.UserName);
          binaryWriter.Write(this.DisplayName);
          binaryWriter.Write(this.Level);
          binaryWriter.Write(this.XP);
          binaryWriter.Write(this.Developer);
        }
        using (BinaryWriter binaryWriter = new BinaryWriter((Stream) File.Create(string.Format("{0}{1}", (object) Config.ServerPlayersDir, (object) this.UserID))))
        {
          binaryWriter.Write(this.UserID);
          binaryWriter.Write(this.UserName);
          binaryWriter.Write(this.DisplayName);
          binaryWriter.Write(this.Level);
          binaryWriter.Write(this.XP);
          binaryWriter.Write(this.Developer);
        }
      }
    }

    public void LoadFile(string userID)
    {
      string path = Config.ServerPlayersDir + userID;
      if (!File.Exists(path))
        return;
      using (BinaryReader binaryReader = new BinaryReader((Stream) File.Open(path, FileMode.Open)))
      {
        this.UserID = binaryReader.ReadUInt64();
        Config.playerID = this.UserID;
        this.UserName = Players.playerName();
        this.DisplayName = Players.playerName();
        this.Level = 1;
        this.XP = 0;
        this.Developer = false;
      }
    }
  }
}

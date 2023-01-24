// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Client;
using System.IO;

namespace RecNet.Handler.SaveData
{
  public class SaveData
  {
    public static string GetSaveData(string path)
    {
      if (File.Exists(path))
        return ClientSecurity.DecodeFrom64(File.ReadAllText(path));
      if (!File.Exists(path))
      {
        int num = 0;
        File.CreateText(path);
        while (!File.Exists(path))
          ++num;
        if (File.Exists(path))
          return ClientSecurity.DecodeFrom64(File.ReadAllText(path));
      }
      return "{}";
    }

    public static void SetSaveData(string data, string path)
    {
      if (File.Exists(path))
      {
        File.WriteAllText(path, ClientSecurity.EncodeTo64(data));
      }
      else
      {
        if (File.Exists(path))
          return;
        int num = 0;
        File.CreateText(path);
        while (!File.Exists(path))
          ++num;
        if (File.Exists(path))
          File.WriteAllText(path, ClientSecurity.EncodeTo64(data));
      }
    }
  }
}

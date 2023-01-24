// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace RecNet.Handler
{
  internal class Logger
  {
    public static void Log(string type, string message, [Optional] string data)
    {
      if (!File.Exists("server-log.txt"))
      {
        File.CreateText("server-log.txt");
        File.AppendAllText("server-log.txt", "[" + type + "] " + message + "\n\t" + data + "\n");
      }
      else
        File.AppendAllText("server-log.txt", "[" + type + "] " + message + "\n\t" + data + "\n");
    }

    public class UserPrefs
    {
      public static Dictionary<string, Logger.UserPrefs.Pref> AllPrefs = new Dictionary<string, Logger.UserPrefs.Pref>();

      public static IEnumerator Initialize()
      {
        Logger.UserPrefs.AllPrefs = Logger.UserPrefs.LoadPrefs();
        yield break;
      }

      public static IEnumerator SavePrefCoroutine()
      {
        while (true)
        {
          Thread.Sleep(5000);
          Logger.UserPrefs.SaveToFile();
        }
      }

      public static string GetPrefValue(string key)
      {
        string str;
        if (Logger.UserPrefs.TryGetValue(key, out Logger.UserPrefs.Pref _))
        {
          if (!File.Exists("prefs.txt"))
          {
            Logger.UserPrefs.AddPref("started_server", "1");
            Logger.UserPrefs.Pref pref;
            if (JsonConvert.DeserializeObject<Dictionary<string, Logger.UserPrefs.Pref>>(File.ReadAllText("prefs.txt")).TryGetValue(key, out pref))
              return pref.Value;
          }
          else
          {
            Logger.UserPrefs.Pref pref;
            if (JsonConvert.DeserializeObject<Dictionary<string, Logger.UserPrefs.Pref>>(File.ReadAllText("prefs.txt")).TryGetValue(key, out pref))
              return pref.Value;
          }
          str = (string) null;
        }
        else
          str = (string) null;
        return str;
      }

      public static void SetPref(string key, string value)
      {
        if (!Logger.UserPrefs.TryGetValue(key, out Logger.UserPrefs.Pref _))
          return;
        if (!File.Exists("prefs.txt"))
        {
          Logger.UserPrefs.AddPref("started_server", "1");
          Dictionary<string, Logger.UserPrefs.Pref> dictionary = JsonConvert.DeserializeObject<Dictionary<string, Logger.UserPrefs.Pref>>(File.ReadAllText("prefs.txt"));
          Logger.UserPrefs.Pref pref;
          if (dictionary.TryGetValue(key, out pref))
          {
            pref.Value = value;
            pref.TimeSet = new DateTime?(DateTime.UtcNow);
            dictionary.Remove(key);
            dictionary.Add(key, pref);
          }
        }
        else
        {
          Dictionary<string, Logger.UserPrefs.Pref> dictionary = JsonConvert.DeserializeObject<Dictionary<string, Logger.UserPrefs.Pref>>(File.ReadAllText("prefs.txt"));
          Logger.UserPrefs.Pref pref;
          if (dictionary.TryGetValue(key, out pref))
          {
            pref.Value = value;
            pref.TimeSet = new DateTime?(DateTime.UtcNow);
            dictionary.Remove(key);
            dictionary.Add(key, pref);
          }
        }
      }

      public static void AddPref(string key, string value)
      {
        if (Logger.UserPrefs.TryGetValue(key, out Logger.UserPrefs.Pref _))
          return;
        if (!File.Exists("prefs.txt"))
        {
          File.CreateText("prefs.txt");
          Logger.UserPrefs.AllPrefs.Add(key, new Logger.UserPrefs.Pref()
          {
            Key = key,
            Value = value,
            TimeSet = new DateTime?(DateTime.UtcNow)
          });
        }
        else
          Logger.UserPrefs.AllPrefs.Add(key, new Logger.UserPrefs.Pref()
          {
            Key = key,
            Value = value,
            TimeSet = new DateTime?(DateTime.UtcNow)
          });
      }

      public static bool TryGetValue(string key, out Logger.UserPrefs.Pref pref) => Logger.UserPrefs.AllPrefs.TryGetValue(key, out pref);

      public static void SaveToFile() => File.WriteAllText("prefs.txt", JsonConvert.SerializeObject((object) Logger.UserPrefs.AllPrefs));

      public static Dictionary<string, Logger.UserPrefs.Pref> LoadPrefs() => JsonConvert.DeserializeObject<Dictionary<string, Logger.UserPrefs.Pref>>(File.ReadAllText("prefs.txt"));

      public class Pref
      {
        public string Key { get; set; }

        public string Value { get; set; }

        public DateTime? TimeSet { get; set; }
      }
    }
  }
}

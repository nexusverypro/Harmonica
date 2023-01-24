// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Newtonsoft.Json;
using System.Collections.Generic;

namespace OldAPIs
{
  public class Checklist
  {
    public static string Get() => JsonConvert.SerializeObject((object) new List<ChecklistEntry>()
    {
      new ChecklistEntry()
      {
        Order = 0,
        Objective = 3000,
        Count = 3,
        CreditAmount = 100
      },
      new ChecklistEntry()
      {
        Order = 1,
        Objective = 3001,
        Count = 3,
        CreditAmount = 100
      },
      new ChecklistEntry()
      {
        Order = 2,
        Objective = 3002,
        Count = 3,
        CreditAmount = 100
      }
    });
  }
}

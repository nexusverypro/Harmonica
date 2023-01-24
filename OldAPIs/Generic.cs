// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

namespace OldAPIs
{
  internal class Generic
  {
    public class APISuccessResposne
    {
      public bool Success { get; set; }

      public string Message { get; set; }

      public APISuccessResposne()
      {
        this.Success = true;
        this.Message = "Success!";
      }
    }
  }
}

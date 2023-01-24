// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class PrivateImplementationDetails
{
  internal static uint ComputeStringHash(string s)
  {
    uint num = 0;
    if (s != null)
    {
      num = 2166136261U;
      for (int index = 0; index < s.Length; ++index)
        num = (uint) (((int) s[index] ^ (int) num) * 16777619);
    }
    return num;
  }
}

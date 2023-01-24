// ============================================================ //
// Made by Minorities (Nexus, Rohan, Gribben, Icy, RecRoom2016) //
//                  Decompiled with Jetbrains                   //
//                     Published by Nexus                       //
// ============================================================ //

using Newtonsoft.Json;
using RecNet;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace Client
{
  public class ClientSecurity
  {
    public static string GenerateToken()
    {
      ClientSecurity.Auth auth = new ClientSecurity.Auth();
      auth.nbf = DateTime.UtcNow.Ticks;
      DateTime dateTime = DateTime.UtcNow;
      dateTime = dateTime.AddDays(1.0);
      dateTime = dateTime.Date;
      auth.exp = dateTime.Ticks;
      auth.iss = "https://auth.rightroom.world";
      auth.aud = new List<string>()
      {
        "https://auth.rightroom.world/resources",
        "rr.api",
        "rr.commerce",
        "rr.rooms",
        "rr.storage",
        "rr.match",
        "rr.leaderboard",
        "rr.auth",
        "rr.chat",
        "rr.accounts"
      };
      auth.client_id = "rightroom";
      auth.role = "gameClient";
      auth.RnPlat = "1";
      auth.RnPlatid = "1";
      auth.RnDeviceclass = "5";
      auth.RnVer = "20210820";
      auth.RnAsid = DateTime.UtcNow.Ticks.ToString();
      auth.RnSk = "4289734123";
      auth.sub = Accounts.GetMID().ToString();
      auth.auth_time = DateTime.UtcNow.Ticks;
      auth.idp = "local";
      auth.RnPid = "3781123978";
      auth.scope = new List<string>()
      {
        "rn.accounts",
        "rn.accounts.gc",
        "rn.api",
        "rn.auth",
        "rn.auth.gc",
        "rn.chat",
        "rn.clubs",
        "rn.commerce",
        "rn.leaderboard",
        "rn.link",
        "rn.match.read",
        "rn.match.write",
        "rn.notify",
        "rn.roomcomments",
        "rn.rooms",
        "rn.storage",
        "offline_access"
      };
      auth.amr = new List<string>() { "cached_login" };
      return ClientSecurity.EncodeTo64(JsonConvert.SerializeObject((object) auth));
    }

    public static string EncodeTo64(string toEncode) => Convert.ToBase64String(Encoding.ASCII.GetBytes(toEncode));

    public static string DecodeFrom64(string encodedData) => Encoding.ASCII.GetString(Convert.FromBase64String(encodedData));

    
    public static ulong GetTokenSubject(string token) => ulong.Parse(new JwtSecurityTokenHandler().ReadJwtToken(token).Subject);

    public class Auth
    {
      public long nbf { get; set; }

      public long exp { get; set; }

      public string iss { get; set; }

      public List<string> aud { get; set; }

      public string client_id { get; set; }

      public string role { get; set; }

      public string RnPlat { get; set; }

      public string RnPlatid { get; set; }

      public string RnDeviceclass { get; set; }

      public string RnVer { get; set; }

      public string RnAsid { get; set; }

      public string RnSk { get; set; }

      public string sub { get; set; }

      public long auth_time { get; set; }

      public string idp { get; set; }

      public string RnPid { get; set; }

      public List<string> scope { get; set; }

      public List<string> amr { get; set; }
    }
  }
}

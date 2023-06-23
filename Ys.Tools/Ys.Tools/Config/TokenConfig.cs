using System;

namespace Ys.Tools.Config
{
    public class TokenConfig
    {
        public static TokenConfig Instance { get;  set; } = new TokenConfig();

        public string Key { get; set; } = string.Empty;
        public string IsUser { get; set; } = string.Empty;
        public string Audience { get; set; } = string.Empty;
        public   DateTime NoBefore { get; set; } = DateTime.Now;
        public   DateTime AccessExpires { get; set; } = DateTime.Now.AddMinutes(20);
        public   DateTime RefreshToken { get; set; } = DateTime.Now.AddHours(1);
    }
}
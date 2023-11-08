using System;

namespace Ys.Tools.Config;
public partial record TokenConfig
{
    public static TokenConfig Instance { get; set; } = new TokenConfig();

    public string Key { get; set; } = string.Empty;

    /// <summary>
    /// Token颁发机构
    /// </summary>
    public string IsUser { get; set; } = string.Empty;

    /// <summary>
    /// 颁发给谁
    /// </summary>
    public string Audience { get; set; } = string.Empty;

    /// <summary>
    ///  token 生成时间
    /// </summary>
    public int NoBefore { get; set; } = 0;

    /// <summary>
    /// 过期时间
    /// </summary>
    public int AccessExpires { get; set; } = 0;

    /// <summary>
    /// 刷新时间
    /// </summary>
    public int RefreshToken { get; set; } = 0;
}

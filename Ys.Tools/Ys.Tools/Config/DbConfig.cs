namespace Ys.Tools.Config;

public partial record   DbConfig
{
    public static DbConfig Instance { get; set; } = new DbConfig();

    /// <summary>
    /// SQLServer链接字符串
    /// </summary>
    public string SqlServer { get; set; } = string.Empty;
    /// <summary>
    /// MySql链接字符串
    /// </summary>
    public string MySql { get; set; } = string.Empty;
    /// <summary>
    /// PgSql链接字符串
    /// </summary>
    public string PgSql { get; set; } = string.Empty;
    /// <summary>
    /// 当前SQL类型
    /// </summary>
    public string SqlType { get; set; } = string.Empty;

}
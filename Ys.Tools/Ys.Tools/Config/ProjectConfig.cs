using System;

namespace Ys.Tools.Config;

public partial record ProjectConfig
{
    public static ProjectConfig Instance { get; set; } = new ProjectConfig();

    /// <summary>
    /// 项目名称
    /// </summary>
    public string ProjectName { get; set; } = String.Empty;

}
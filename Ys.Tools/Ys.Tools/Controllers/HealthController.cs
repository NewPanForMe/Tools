using Microsoft.AspNetCore.Mvc;
using System;
using Ys.Tools.Config;

namespace Ys.Tools.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class HealthController : ControllerBase
{
    [HttpGet]
    public string Check()
    {
        return $"【{ProjectConfig.Instance.ProjectName}】后台部署完成-Ok-【{DateTime.Now:yyyy/MM/dd HH:mm:ss}】";
    }
}
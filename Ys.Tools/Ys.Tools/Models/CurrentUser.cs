using System.Collections.Generic;
using System.Security.Claims;
using System;

namespace Ys.Tools.Models;
public class  CurrentUser
{
    /// <summary>
    /// 用户ID
    /// </summary>
    public string Id { get; set; } = string.Empty;

    /// <summary>
    /// 用户姓名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 用户编号
    /// </summary>
    public string Code { get; set; } = string.Empty;
    /// <summary>
    /// token版本
    /// </summary>
    public string JwtVersion { get; set; } = string.Empty;
    /// <summary>
    /// 过期时间
    /// </summary>
    public string ExpireTime { get; set; } = string.Empty;
    /// <summary>
    /// 角色信息
    /// </summary>
    public string Roles { get; set; } = string.Empty;

    /// <summary>
    /// 用户类型
    /// </summary>
    public string UserType { get; set; } = string.Empty;

    /// <summary>
    /// 用户信息
    /// </summary>
    public object Data { get; set; } = string.Empty;

    public List<Claim> Claims { get; set; } = new List<Claim>();

    public string[] ListRole { get; set; } = new string[10];

    public override string ToString()
    {
        var res = $"Id={Id},";
        res += $"Name={Name},";
        res += $"Code={Code},";
        res += $"JwtVersion={JwtVersion},";
        res += $"ExpireTime={ExpireTime},";
        res += "【";
        if (Claims.Count > 0)
        {
            Claims.ForEach(x =>
            {
                res += $"{x.ValueType}={x.Value},";
            });
        }

        res += "】";
        return res;
    }
}

using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;
using System.Security.Claims;
using Ys.Tools.Models;

namespace Ys.Tools.Controllers;

public class BaseAuthController : ControllerBase
{
    public virtual CurrentUser CurrentUser
    {
        get
        {
            try
            {
                var claims = HttpContext.User.Claims.ToList();
                var user = new CurrentUser()
                {
                    Id = claims.FirstOrDefault(p => p.Type == ClaimTypes.NameIdentifier)?.Value??"",
                    Name = claims.FirstOrDefault(p => p.Type == ClaimTypes.Name)?.Value ?? "",
                    Code = claims.FirstOrDefault(p => p.Type == "UserCode")?.Value ?? "",
                    JwtVersion = claims.FirstOrDefault(p => p.Type == ClaimTypes.Version)?.Value ?? "",
                    ExpireTime = claims.FirstOrDefault(p => p.Type == "ExpireTime")?.Value ?? "",
                    Roles = claims.FirstOrDefault(p => p.Type == ClaimTypes.Role)?.Value ?? "",
                    Claims = claims,
                };
                if (!string.IsNullOrEmpty(user.Roles) )
                {
                    Console.WriteLine($"Roles：{user.Roles}");
                    if (!user.Roles.Contains(","))
                    {
                        user.ListRole[0] = user.Roles;
                    }
                    else if (user.Roles.Contains(","))
                    {
                        user.ListRole = user.Roles.Split(',');
                    }
                    else
                    {
                        
                    }
                }
                return user;
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.ToString());
                return new CurrentUser();
            }
        }
    }

}
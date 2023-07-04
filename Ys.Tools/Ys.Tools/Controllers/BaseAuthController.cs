using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;
using System.Security.Claims;
using Ys.Tools.Models;

namespace Ys.Tools.Controllers;

public class BaseAuthController : ControllerBase
{
    public virtual CurrentUser? CurrentUser
    {
        get
        {
            try
            {
                var claims = HttpContext.User.Claims.ToList();
              var user = new CurrentUser()
                {
                    Id = claims.First(p => p.Type == ClaimTypes.NameIdentifier).Value,
                    Name = claims.First(p => p.Type == ClaimTypes.Name).Value,
                    Code = claims.First(p => p.Type == "UserCode").Value,
                    JwtVersion = claims.First(p => p.Type == ClaimTypes.Version).Value,
                    ExpireTime = claims.First(p => p.Type == "ExpireTime").Value,
                    Claims = claims,
                };
                return user;
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
    }

}
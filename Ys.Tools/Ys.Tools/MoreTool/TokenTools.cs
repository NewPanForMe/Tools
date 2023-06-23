using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Ys.Tools.Config;

namespace Ys.Tools.MoreTool
{
    public static class TokenTools
    {
        private static readonly string Key =TokenConfig.Instance.Key;
        private static readonly SecurityKey SecurityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Key));
        private static readonly string IsUser = TokenConfig.Instance.IsUser;
        private static readonly string Audience = TokenConfig.Instance.Audience;
        private static readonly DateTime? NoBefore = TokenConfig.Instance.NoBefore;
        private static readonly DateTime? AccessExpires = TokenConfig.Instance.AccessExpires;
        private static readonly DateTime? RefreshToken = TokenConfig.Instance.RefreshToken;
        /// <summary>
        ///  创建、校验token，返回ClaimsPrincipal
        ///  CanReadToken()：确定字符串是否是格式良好的Json Web令牌(JWT)
        ///  ReadJwtToken(string token)：token字符串转为JwtSecurityToken对象
        ///  ValidateToken(string token、TokenValidationParameters parameter，out SecurityToken validatedToken)：校验token，返回ClaimsIdentity，
        /// </summary>
        /// <param name="listClaims"></param>
        /// <returns></returns>
        public static string Create(List<Claim> listClaims)
        {
            JwtSecurityToken tokenConfig = new JwtSecurityToken(
                issuer: IsUser,
                audience: Audience,
                claims: listClaims,
                notBefore: NoBefore,
                expires: RefreshToken,
                signingCredentials: new SigningCredentials(SecurityKey, SecurityAlgorithms.HmacSha256)
                );
            return new JwtSecurityTokenHandler().WriteToken(tokenConfig); ;
        }

        /// <summary>
        /// 通过用户名密码生成
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string Create(string username, string password)
        {
            List<Claim> listClaims = new List<Claim>();
            if (listClaims == null) throw new ArgumentNullException(nameof(listClaims));
            listClaims.Add(new Claim("username", username));
            listClaims.Add(new Claim("password", password));
            JwtSecurityToken tokenConfig = new JwtSecurityToken(
               issuer: IsUser,
               audience: Audience,
               claims: listClaims,
               notBefore: NoBefore,
               expires: AccessExpires,
               signingCredentials: new SigningCredentials(SecurityKey, SecurityAlgorithms.HmacSha256)
               );
            return new JwtSecurityTokenHandler().WriteToken(tokenConfig); ;
        }

        /// <summary>
        /// 通过token生成
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public static string Create(string token)
        {
            List<Claim> listClaims = new List<Claim>();
            listClaims.Add(new Claim("token", token));
            JwtSecurityToken tokenConfig = new JwtSecurityToken(
               issuer: IsUser,
               audience: Audience,
               claims: listClaims,
               notBefore: NoBefore,
               expires: RefreshToken,
               signingCredentials: new SigningCredentials(SecurityKey, SecurityAlgorithms.HmacSha256)
               );
            return new JwtSecurityTokenHandler().WriteToken(tokenConfig); ;
        }


    }
}

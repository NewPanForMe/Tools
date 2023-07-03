using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Ys.Tools.Exception;
using Ys.Tools.MoreTool;
using Ys.Tools.Response;

namespace Ys.Tools.MiddleWare
{
    public class ExceptionMiddleWare
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleWare> _logger;
        public ExceptionMiddleWare(RequestDelegate next, ILogger<ExceptionMiddleWare> logger)
        {
            this._next = next;
            _logger = logger;
        }


        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (System.Exception e)
            {
                ApiResult requestResultStd = DealException(e);
                await Response(context, requestResultStd);
            }
        }
        /// <summary>
        /// 处理Exception
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        private ApiResult DealException(System.Exception e)
        {
            var type = e.GetType();
            ApiResult apiResult;
            if (type == typeof(MessageException))
            {
                apiResult = ApiResult.False(e.Message,null);
            }
            else if (type == typeof(NoUserException))
            {
                apiResult = ApiResult.False(e.Message,null);
            }
            else if (type == typeof(PasswordErrorException))
            {
                apiResult = ApiResult.False(e.Message, null);
            }
            else if (type == typeof(NoUsernameOrPasswordException))
            {
                apiResult = ApiResult.False(e.Message, null);
            }
            else
            {
                apiResult = ApiResult.False(e.Message, null);
            }
            _logger.LogWarning(e.Message);
            return apiResult;
        }

        /// <summary>
        /// 返回内容
        /// </summary>
        /// <param name="context"></param>
        /// <param name="rsp"></param>
        /// <returns></returns>
        private async Task Response(HttpContext context, ApiResult rsp)
        {
            context.Response.ContentType = "application/json;charset=UTF-8";
            await context.Response.WriteAsync(JsonTools.Serialize(rsp));
        }
    }
}


namespace Ys.Tools.Response
{
    public class ApiResult
    {
        public bool? Success { get; set; }
        public string Message { get; set; }
        public object Result { get; set; }

        public ApiResult()
        {
        }

        public ApiResult(bool success,string message, object result)
        {
            Success = success;
            Message = message;
            Result = result;
        }

        public static ApiResult True()
        {
            return new ApiResult
            {
                Success= true,
                Message="",
                Result= null
            };
        }
        public static ApiResult True(string message,object result)
        {
            return new ApiResult
            {
                Success = true,
                Message = message,
                Result = result
            };
        }
        public static ApiResult True(string message)
        {
            return new ApiResult
            {
                Success = true,
                Message = message,
                Result = null
            };
        }

        public static ApiResult True(object result)
        {
            return new ApiResult
            {
                Success = true,
                Message = "",
                Result = result
            };
        }
        public static ApiResult False()
        {
            return new ApiResult
            {
                Success = false,
                Message = "",
                Result = null
            };
        }
        public static ApiResult False(string message, object result)
        {
            return new ApiResult
            {
                Success = false,
                Message = message,
                Result = result
            };
        }
        public static ApiResult False(string message)
        {
            return new ApiResult
            {
                Success = false,
                Message = message,
                Result = null
            };
        }

        public static ApiResult False(object result)
        {
            return new ApiResult
            {
                Success = false,
                Message = "",
                Result = result
            };
        }
    }
}

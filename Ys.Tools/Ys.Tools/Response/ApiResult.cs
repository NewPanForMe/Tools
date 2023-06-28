
namespace Ys.Tools.Response
{
    public  class  ApiResult
    {
        public bool Success { get; set; } = false;
        public string? Message { get; set; }
        public object? Result { get; set; }

        private ApiResult()
        {
        }

        public static ApiResult True()
        {
            return new ApiResult()
            {
                Success= true,
                Message="",
                Result= null
            };
        }
        public static ApiResult True(string message,object result)
        {
            return new ApiResult()
            {
                Success = true,
                Message = message,
                Result = result
            };
        }
        //public static ApiResult True(string message)
        //{
        //    return new ApiResult
        //    {
        //        Success = true,
        //        Message = message,
        //        Result = null
        //    };
        //}

        public static ApiResult True(object result)
        {
            return new ApiResult()
            {
                Success = true,
                Message = "成功",
                Result = result
            };
        }
        public static ApiResult False()
        {
            return new ApiResult()
            {
                Success = false,
                Message = null,
                Result = null
            };
        }
        public static ApiResult False(string message, object result)
        {
            return new ApiResult()
            {
                Success = false,
                Message = message,
                Result = result
            };
        }
        //public static ApiResult False(string message)
        //{
        //    return new ApiResult
        //    {
        //        Success = false,
        //        Message = message,
        //        Result = null
        //    };
        //}

        public static ApiResult False(object result)
        {
            return new ApiResult()
            {
                Success = false,
                Message = "失败",
                Result = result
            };
        }
    }
}

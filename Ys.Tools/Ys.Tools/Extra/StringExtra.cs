
using Ys.Tools.Exception;

namespace Ys.Tools.Extra
{
    public static class StringExtra
    {
        /// <summary>
        /// 判断是否有值
        /// </summary>
        /// <param name="value"></param>
        /// <param name="eMsg"></param>
        /// <returns></returns>
        /// <exception cref="MessageException"></exception>
        public static string HasValue(this string? value, string eMsg)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new MessageException(eMsg);
            }
            if(value == null) { throw new MessageException(eMsg); }
            return value;
        }
        /// <summary>
        /// 只用来判断账户密码 是否有值
        /// </summary>
        /// <param name="value"></param>
        /// <param name="eMsg"></param>
        /// <returns></returns>
        public static string HasValueNoNameOrPwd(this string? value, string eMsg)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new NoUsernameOrPasswordException(eMsg);
            }
            if (value == null) { throw new MessageException(eMsg); }
            return value;
        }


    }
}

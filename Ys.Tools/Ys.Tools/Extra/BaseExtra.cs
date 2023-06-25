using Ys.Tools.Exception;

namespace Ys.Tools.Extra
{
    public static  class BaseExtra
    {
        public static T NotNull<T>(this T? value, string eMsg)
        {
            if (value == null)
            {
                throw new MessageException(eMsg);
            }

            return value;
        }
    }
}
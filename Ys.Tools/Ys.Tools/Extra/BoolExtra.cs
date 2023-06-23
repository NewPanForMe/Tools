using Ys.Tools.Exception;

namespace Ys.Tools.Extra
{
    public static class BoolExtra
    {
        public static void IsBool(this bool value, string eMsg)
        {
            if (value)
            {
                throw new MessageException(eMsg);
            }
        }
       
    }
}
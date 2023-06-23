using System;
using System.Collections.Generic;
using Ys.Tools.Exception;

namespace Ys.Tools.Extra
{
    public static class IntExtra
    {
        public static int IsZero(this int value, string eMsg)
        {
            if (value == 0)
            {
                throw new MessageException(eMsg);
            }
            return value;
        }
    }
}

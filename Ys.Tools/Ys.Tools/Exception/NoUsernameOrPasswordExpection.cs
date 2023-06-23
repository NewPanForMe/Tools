using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ys.Tools.Exception
{
    public class NoUsernameOrPasswordException : System.Exception
    {
        public NoUsernameOrPasswordException(string message) : base(message) { }

        public static NoUsernameOrPasswordException Throw(string message)
        {
            throw new NoUsernameOrPasswordException(message);
        }
    }

}


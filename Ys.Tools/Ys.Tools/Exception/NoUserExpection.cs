using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ys.Tools.Exception
{
    public class NoUserException : System.Exception
    {
        public NoUserException(string message) : base(message) { }

        public static NoUserException Throw(string message)
        {
            throw new NoUserException(message);
        }
    }

}



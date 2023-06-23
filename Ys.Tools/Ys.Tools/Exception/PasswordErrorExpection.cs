using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ys.Tools.Exception
{
    public class PasswordErrorException : System.Exception
    {
        public PasswordErrorException(string message) : base(message) { }

        public static PasswordErrorException Throw(string message)
        {
            throw new PasswordErrorException(message);
        }
    }

}


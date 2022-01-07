using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    public class NegativeOrZeroNumberException : Exception
    {
        public NegativeOrZeroNumberException(String message) : base(message)
        {

        }
    }
}

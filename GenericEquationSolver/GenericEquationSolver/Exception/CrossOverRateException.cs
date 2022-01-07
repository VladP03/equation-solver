using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    public class CrossOverRateException : Exception
    {
        public CrossOverRateException(String message) : base(message)
        {

        }
    }
}

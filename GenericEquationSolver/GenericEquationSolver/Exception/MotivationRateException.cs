using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    public class MotivationRateException : Exception
    {
        public MotivationRateException(String message) : base(message)
        {

        }
    }
}

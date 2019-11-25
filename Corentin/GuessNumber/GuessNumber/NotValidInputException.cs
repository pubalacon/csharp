using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class NotValidInputException : Exception
    {
        public NotValidInputException(string s) : base(s)
        {
            
        }
    }
}

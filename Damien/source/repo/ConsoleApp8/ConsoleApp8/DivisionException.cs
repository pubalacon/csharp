using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class DivisionException : Exception
    {
        public DivisionException(int num)
            :base("Division par zéro impossible (saisie: "+num+")")
        {
        }
    }
}

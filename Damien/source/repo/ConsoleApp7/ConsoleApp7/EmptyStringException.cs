using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class EmptyStringException : Exception
    {
        public EmptyStringException(string input)
            : base($"La chaine ne peut être ni nulle ni vide (saisie: \"{input}\")")
        {

        }
    }
}

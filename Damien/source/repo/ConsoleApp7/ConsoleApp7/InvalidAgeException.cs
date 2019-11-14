using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class InvalidAgeException : Exception
    {
        public InvalidAgeException(int age)
            : base($"L'âge doit être entre 18 et 26 (saisie: \"{age}\")")
        {
            
        }
    }
}

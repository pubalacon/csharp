using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class InvalidNoteException : Exception
    {
        public InvalidNoteException(int note)
            : base($"La note doit être comprise entre 0 et 20 (saisie: \"{note}\")")
        {
        }
    }
}

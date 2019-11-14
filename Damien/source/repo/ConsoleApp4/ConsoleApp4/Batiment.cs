using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Batiment
    {
        public string Adresse { get; set; }

        public Batiment()
        {

        }

        public Batiment(string adresse)
        {
            Adresse = adresse;
        }

        public virtual string ToString()
        {
            return "L'adresse du batiment est \"" + Adresse + "\"";
        }
    }
}

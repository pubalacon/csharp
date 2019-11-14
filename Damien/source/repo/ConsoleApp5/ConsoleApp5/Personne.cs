using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }

        public Personne(string nom, string prenom, string datenaissance)
        {
            Nom = nom;
            Prenom = prenom.ToUpper();
            DateNaissance = Convert.ToDateTime(datenaissance);
        }

        public virtual string ToString()
        {
            string sep = "\n";
            string str = "Nom complet: " + Nom + " " + Prenom;
            return str;
        }
    }
}

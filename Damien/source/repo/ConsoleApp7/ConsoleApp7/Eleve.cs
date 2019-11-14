using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Eleve : Personne
    {
        public int Note { get; set; }

        public Eleve(string nom, string prenom, int age, int note)
            : base(nom, prenom, age)
        {
            Note = note;
        }
        public override string afficher()
        {
            return "Elève: " + LastName.ToUpper() + " " + FirstName + " (" + Age + " ans) a pour note " + Note;
        }
    }
}

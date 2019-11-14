using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Personne
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }

        public Personne(string nom, string prenom, int age)
        {
            LastName = nom;
            FirstName = prenom;
            Age = age;
        }

        public virtual string afficher()
        {
            return "Personne: " + LastName.ToUpper() + " " + FirstName + " (" + Age + " ans)";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    abstract class Vehicule
    {
        private int Matricule { get; set; }
        private string DateModele { get; set; }
        private double Price { get; set; }

        public Vehicule(int matricule, string datemodele, double price)
        {
            Matricule = matricule;
            DateModele = datemodele;
            Price = price;
        }
        public abstract string demarrer();

        public abstract string accelerer();

        public virtual string ToString()
        {
            string sep = "|";
            return Matricule + sep + DateModele + sep + Price;
        }
    }
}

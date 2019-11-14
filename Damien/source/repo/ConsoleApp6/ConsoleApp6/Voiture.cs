using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Voiture : Vehicule
    {
        public Voiture(int matricule, string datemodele, double price)
            : base(matricule, datemodele, price)
        {

        }
        public override string demarrer()
        {
            return "Tchakatchak Tchakatchak";
        }

        public override string accelerer()
        {
            return "Vroum Vroum Vroum";
        }

        public override string ToString()
        {
            string sep = "|";
            return "Voiture: "+base.ToString()+sep+"Demarrage->"+this.demarrer()+sep + "Acceleration->" + this.accelerer();
        }
    }
}

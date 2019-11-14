using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Camion : Vehicule
    {
        public Camion(int matricule, string datemodele, double price)
            : base(matricule, datemodele, price)
        {
        }

        public override string demarrer()
        {
            return "Peute Peute Peute";
        }

        public override string accelerer()
        {
            return "Braoum Braoum Braoum";
        }

        public override string ToString()
        {
            string sep = "|";
            return "Camion: " + base.ToString() + sep + "Demarrage->" + this.demarrer() + sep + "Acceleration->" + this.accelerer();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parc_Animalier
{
    class Lion : Predator
    {
        public static double ReproChance { get; set; }

        public Lion(string sex, double reproChance) : base("lion", sex, reproChance)
        {
            ReproChance = reproChance;
        }

        public void hunt()
        {

        }

        public override void manageEnergy(int gain)
        {
            base.manageEnergy(gain); ;

            ReproChance = this.Energy < 20 ? 2 * BaseReproChance : BaseReproChance;
        }


    }
}

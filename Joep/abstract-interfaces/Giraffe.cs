using System;
using System.Collections.Generic;
using System.Text;

namespace Override_VS_New
{
    class Giraffe : Animal
    {
        public Giraffe(string sexe) : base("Giraffe", sexe)
        { }

        public override void Feed()
        {
            this.Energy = 50;
        }
    }
}

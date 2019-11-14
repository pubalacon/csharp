using System;
using System.Collections.Generic;
using System.Text;

namespace Override_VS_New
{
    class Lion : Animal     //il faut override Feed() car methode abstraite
    {
        public Lion(string sexe) : base("Lion", sexe)
        { }

        
        public override void Feed()                 //declaration avec Override obligatoire de Feed() car c'est une methode abstraite que l'on herite
        {
            if (new Random().Next(0, 100) > 50)
                this.Energy = 100;
        }
        
        public void Rugir()
        {
            Console.WriteLine("ROOOOOOAAAAAAAAAAAAAAAAAAAR!!");
        }
    }
}

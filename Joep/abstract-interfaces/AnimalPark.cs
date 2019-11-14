using System;
using System.Collections.Generic;
using System.Text;

namespace Override_VS_New
{
    class AnimalPark
    {
        List<Animal> Animals { get; set; }  //Liste impossible sans notre classe abstraite.

        public void OneDay(Animal beast)    // Comment declarer une telle fonction sans la methode abstraite Feed() ??
                                            // Impossible (les classes abstraites ca sert)
        {
            beast.HungerForTheDay();
            beast.Feed();
        }

        public void AnotherDay()
        {
            int i = 0;
            foreach (Animal bestiole in Animals)
            {
                OneDay(bestiole);
                bestiole.IsItDead();
                if (!bestiole.Alive)
                    Animals.RemoveAt(i);
                i++;
            }
        }
    }
}

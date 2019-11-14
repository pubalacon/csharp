using System;
using System.Collections.Generic;
using System.Text;

namespace Override_VS_New
{
    // une interface est une classe abstraite ou toutes les fonctions sont abstraites (le mot clef abstract est omis)
    // elle sert a definir un plan pour les classes l'implementant
    interface IAnimalInterface
    {
        string Espece { get; set; }
        public string Sexe { get; set; }
        int Energy { get; set; }
        bool Alive { get; set; }

        public void Feed();

        public void DisplayInfo();

        public void HungerForTheDay();

        public void IsItDead();
    }
}

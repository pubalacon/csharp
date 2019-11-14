using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            ICommuniquer[] tab = new ICommuniquer[6];

            tab[0] = new Cat();
            tab[1] = new Dog();
            tab[2] = new Cat();
            tab[3] = new Dog();
            tab[4] = new Cat();
            tab[5] = new Dog();

            for(int i=0; i<tab.Length; i++)
            {
                tab[i].parler();
                tab[i].crier();
                tab[i].hurler();

            }

            Console.ReadKey();
        }
    }
}

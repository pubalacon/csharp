using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Maison MyHome1 = new Maison("Sur la plage d'Ilbarritz, 64210 Bidart", 1);
            Maison MyHome2 = new Maison("Chateau d'Ilbarritz, 64210 Bidart", 25, 625, 20000);

            Console.WriteLine(MyHome1.ToString());

            Console.WriteLine();

            Console.WriteLine(MyHome2.ToString());

            Console.ReadKey();
        }

    }
}

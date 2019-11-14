using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Dog : ICommuniquer
    {
        public void parler()
        {
            Console.WriteLine("Wouf");
        }
        public void crier()
        {
            Console.WriteLine("Woohoohoo");
        }
        public void hurler()
        {
            Console.WriteLine("WOOHOOHOO");
        }
    }
}

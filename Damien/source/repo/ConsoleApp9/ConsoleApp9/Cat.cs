using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Cat : ICommuniquer
    {
        public void parler()
        {
            Console.WriteLine("Miaou");
        }
        public void crier()
        {
            Console.WriteLine("Miaouuuuu");
        }
        public void hurler()
        {
            Console.WriteLine("MIAOUUUUU");
        }
    }
}

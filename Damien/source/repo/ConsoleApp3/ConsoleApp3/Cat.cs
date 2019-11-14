using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Cat: Animal
    {
        private int Age { get; set; }
        private int Weight { get; set; }

        public Cat(string name, int age, int weight)
            : base(name)
        {
            Age = age;
            Weight = weight;
        }

        public override void Move()
        {
            Console.WriteLine("Cat moves...");
        }

        public override void Say()
        {
            Console.WriteLine("{0} says : Meo !", this.GetType());
        }

    }

}

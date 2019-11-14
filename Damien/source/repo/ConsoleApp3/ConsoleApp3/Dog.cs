using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Dog: Animal
    {
        private int Age { get; set; }
        private int Weight { get; set; }
        private int Size { get; set; }
        public Dog(string name, int age, int weight, int size)
            : base(name)
        {
            Age = age;
            Weight = weight;
            Size = size;
        }

        public override void Move()
        {
            Console.WriteLine("Dog moves...");
        }

        public override void Say()
        {
            Console.WriteLine("{0} says : Woof!", this.GetType()) ;
        }

    }

}

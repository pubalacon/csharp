using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            this.Name = name;
        }

        public virtual void Move()
        {
            Console.WriteLine("{0} moves", this.GetType());
        }

        public virtual void Say()
        {
            Console.WriteLine("");
        }

        public void Sleep()
        {
            Console.WriteLine("{0} is sleeping...", this.GetType());
        }

    }
}

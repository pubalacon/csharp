using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var ya = new ObjectWithNameAndAge(20, "john");
            ya.PrintName();

            Console.WriteLine(ya.age);
            ya.GetOlder();
            Console.WriteLine(ya.age);

            
            var jeanno = new person(15, "jeanno", 10);
            jeanno.PrintName();
            jeanno.GetOlder();
            Console.WriteLine(jeanno.age);
            Console.WriteLine(jeanno.wisdom);
            /*
            var makina = new Machine(2, "Mtech 300", "0112351425");
            makina.PrintName();
            */


        }
    }
}

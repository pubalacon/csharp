using System;

namespace Yield
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var list = class1.makeIEnum(5, 10);
            foreach (int x in list)
            {
                Console.WriteLine(x);
            }
        }
    }
}

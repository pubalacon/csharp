
using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Notions
{
    class Base
    {
        public void New()
        {
            Console.WriteLine("Base - New");
        }
        public virtual void Virtual_Override()
        {
            Console.WriteLine("Base - virtual Override");
        }
    }
    class Child : Base
    {
        public int Count { get; set; }
        public Child(int a)
        {
            Count = a;
        }
        public Child() { }
        public new void New()
        {
            Console.WriteLine("Child - New");
        }
        public override void Virtual_Override()
        {
            Console.WriteLine("Child - virtual Override");
        }

        public static void Override_vs_new()
        {
            Base b = new Base();
            Child c = new Child();
            Base bc = new Child();
            //Child cb = new Base();

            Console.WriteLine("Base as Base");
            b.New();
            b.Virtual_Override();
            
            Console.WriteLine("");
            Console.WriteLine("Child as Child");
            c.New();
            c.Virtual_Override();

            Console.WriteLine("");
            Console.WriteLine("Child as Base");
            bc.New();                           //THE DIFFERENCE IS HERE
            bc.Virtual_Override();              // HERE 
        }
        public static void Casting()
        {
            Base bc = new Child(7);
            //Console.WriteLine(bc.Count); //ne march pas car bc est declare comme Base.
            Console.WriteLine(((Child)bc).Count);
        }
    }
}

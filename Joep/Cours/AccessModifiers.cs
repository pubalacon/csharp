using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Notions
{
    class z : AccessTester
    {
        /*
        public override void Sayhello() // erreur car on ne peut plus override un fois que c'est sealed
        {
            new stuff
        }
        */
} 

    class AccessTester : Class
    {
        public static void TestAccess()
        {
            Class obj = new Class();
            AccessTester derivedObj = new AccessTester();
            Console.WriteLine(obj.Public);
            //Console.WriteLine(obj.Private);       // ne marche pas car Private
            Console.WriteLine(derivedObj.Public);
            //Console.WriteLine(derivedObj.Private);  // ne marche pas car un attribut private n'est pas accessible meme par une classe derivee;
            Console.WriteLine(obj.GetPrivate());    // fonctionne car GetPrivate est public. GetPrivate est dans Class et a donc acces a Private
            //Console.WriteLine(obj.Protected);       //erreur car la methode testAccess n'est pas dans Class et obj est de type class donc protected fonctionne comme private ici
            Console.WriteLine(derivedObj.Protected);    
        }
        public sealed override void SayHello()
        {
            base.SayHello();
            Console.WriteLine("and we added some stuff");    
        }

    }
    class Class
    {
        public int Public { get; set; }
        protected int Protected { get; set; }
        private int Private { get; set; }

        public int GetPrivate()
        {
            return Private;
        }
        public virtual void SayHello()
        {
            Console.WriteLine("Hi im the parent class");
        }
    }
}

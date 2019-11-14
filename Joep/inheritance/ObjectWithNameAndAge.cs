using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class ObjectWithNameAndAge
    {

        public int age { get; set; }
        public string name { get; set; }

        public ObjectWithNameAndAge(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
        public void PrintName()
        {
            Console.WriteLine("my name is " + this.name);
        }

        public virtual void GetOlder() //virtual ne change rien ici mais nous permet d'utiliser override dans person.cs
        {
            this.age = this.age + 1;
        }
    }


}

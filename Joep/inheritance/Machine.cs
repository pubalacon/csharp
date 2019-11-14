using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Machine : ObjectWithNameAndAge
    {
        public string serialNumber { get; set; }

        public Machine(int age, string name, string Snum) : base(age, name)  // on apelle le constructeur de ObjectWithNameAneAge avec base
        {
            this.serialNumber = Snum;
        }
        public new void PrintName() //avec le mot clef new on redefinit la fonction printName pour cette classe la
        {
            Console.WriteLine("Machine name: " + name + " ,serial Number: " + serialNumber);
        }
    }
}

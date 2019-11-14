using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Personne : ISalutation, IGreeting
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }

        public Personne(int id, string lastname, string firstname)
        {
            this.ID = id;
            this.FirstName = firstname;
            this.LastName = lastname;
        }
        public Personne(int id, string lastname, string firstname, string address)
        {
            this.ID = id;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Address = address;
        }

        public void Talk()
        {
            this.SayHello();
        }
        public void DireBonjour()
        {
            Console.WriteLine("Salut {0} {1} !", this.FirstName, this.LastName);
        }
        public void SayHello()
        {
            Console.WriteLine("Hi {0} {1} !", this.FirstName, this.LastName);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Notions
{
    
    class Person
    {
        public string Prenom { get; set; }
        public int Age { get; set; }
        public Grades Grades {get; set;}

        public Person(string prenom, int age)
        {
            Prenom = prenom;
            Age = age;
            Grades = new Grades(10, 10);
        }
        public Person()
        {

        }
        public Person Clone()
        {
            Person NewGuy = new Person();
            NewGuy.Age = this.Age;
            NewGuy.Prenom = this.Prenom;
            NewGuy.Grades = new Grades(10, 10);
            NewGuy.Grades.Math = this.Grades.Math;
            NewGuy.Grades.Physics = this.Grades.Physics;
            return (NewGuy);
        }
        public void DisplayInfo()
        {
            Console.WriteLine(Prenom + ", Age: " + Age + " Maths: " + Grades.Math);
        }

        public int DisplayInfo(string str)
        {
            return (1);
        }

        public static void AddOne(int a)
        {
            a = a + 1;
        }
        public static void AddOneRef(ref int a)
        {
            a = a + 1;
        }
        public static void AddOneOut(int a, out int b)
        {
            b = a + 1;  //si on enleve cette ligne erreur car IL FAUT ASSIGNER UNE VALEUR A b car elle est en out; 
        }
        public static void Ref_Out()
        {
            int a = 0;
            int b;
            AddOne(a);
            Console.WriteLine(a); // a n'as pas change car une copie est passee a AddOne;
            AddOneRef(ref a);
            Console.WriteLine(a); // a Change cette fois grace a ref;
            AddOneOut(a, out b); // b n'est pas initialise (n'as pas de valeur), pas de souci
            Console.WriteLine(b);
        }
        public static void Ref_vs_Value()
        {
            Person jean = new Person("jean", 25);
            Person georges = jean;              //un objet est un reference type;
                                                //Person georges = jean.Clone();    // remplacer pour voir
            jean.DisplayInfo();
            georges.DisplayInfo();

            georges.Age = 50;                   // georges.Age refere a la meme variable que jean.Age
            georges.Grades.Math = 20;
            jean.DisplayInfo();
            georges.DisplayInfo();              //on le voit ici;
        }
    }
}

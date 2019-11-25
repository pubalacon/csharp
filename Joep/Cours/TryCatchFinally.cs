using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Notions
{
    class CustomException : Exception
    {
        public CustomException(string msg) : base(msg)
        {

        }
    }
    class TryCatchFinally
    {
        public static void Main1() 
        {
            try
            {
                int x = 5;
                int y = 0;
                Console.WriteLine(x / y);
            }
            catch
            {
                Console.WriteLine("on a pas ecrit de throw dans try mais il y en a un tout seul");
            }
        }
        public static void Main2()
        {
            string str = "";
            try
            {
                throw new CustomException("Yihaa");
            }
            catch (CustomException e) when (str != "")      // on peut mettre du conditionnel
            {
                Console.WriteLine("On ne rentre pas la car str est vide"); 
            }
            catch (CustomException e) when (str == "")      
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);        //des methodes sont incluses ds le type exception
                return;
            }
            catch (CustomException e)
            {
                Console.WriteLine("On ne rentre pas la car un seul catch est execute");
            }
            finally
            {
                Console.WriteLine("TOUJOURS TOUJOURS LE BLOCK FINALLY EST EXECUTE");
                Console.WriteLine("Meme si il y a un return dans le block catch execute en haut");
            }
            Console.WriteLine("La on voit qu'on est sorti avec le return et ceci ne s'affiche pas");

        }
    }
}

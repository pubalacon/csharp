using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int myGuess = -1;
            int nbTries = 0;
            int maxTries = 10;

            Console.WriteLine("You have to guess a number between 0 and 100 with a tries limit of 10");

            Random random = new Random();
            int toGuess = random.Next(0, 100);

            do
            {
                Console.Write("Your number: ");
                input = Console.ReadLine();

                nbTries++;

                if (input == null || input.ToLower() == "q")
                {
                    Console.WriteLine("End");
                    break;
                }

                try
                {
                    if (!Int32.TryParse(input, out myGuess))
                    {
                        throw new NotValidInputException("Enter a number between 0 and 100 or \"q\" to quit");
                    }

                    if (myGuess < 0 || myGuess > 100)
                    {
                        throw new NotValidInputException("Enter a number between 0 and 100");
                    }

                    if (myGuess < toGuess)
                    {
                        Console.WriteLine("Cold");
                    }
                    else if (myGuess > toGuess)
                    {
                        Console.WriteLine("Hot");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            } while ((myGuess == -1 || myGuess!=toGuess) && nbTries < maxTries);

            if (nbTries >= maxTries)
            {
                Console.WriteLine($"Not Found within the {maxTries} tries limit!");
            } 
            else
            {
                if (myGuess == toGuess)
                {
                    Console.WriteLine($"Found in {nbTries} tries!");
                }
            }

            Console.ReadKey();
        }
    }
}

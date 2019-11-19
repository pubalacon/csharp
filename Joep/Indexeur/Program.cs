using System;
using System.Collections.Generic;

namespace indexeur
{
    class Program
    {
        static void Main(string[] args)
        {
            string sku = "sku001";
            string description = "produit p1";
            double price = 10;

            Console.Write("Sku: "); sku = Console.ReadLine();
            Console.Write("Description: "); description = Console.ReadLine();
            //Console.Write("Prix: "); price = Convert.ToInt32(Console.ReadLine());

            try
            {

                if (sku == null)
                {
                    throw new InvalidSkuException();
                }
                if (description == null)
                {
                    throw new InvalidDescriptionException();
                }
                if (price < 0)
                {
                    throw new InvalidPriceException();
                }

                Product p1 = new Product(sku, description, price);
            }
            catch (InvalidSkuException)
            {
                sku = "sku000";
            }
            catch (InvalidDescriptionException)
            {
                description = "Description produit";
            }
            catch (InvalidPriceException)
            {
                price = 0;
            }



            Console.WriteLine("Fin");
            Console.ReadKey();
        }
    }
}

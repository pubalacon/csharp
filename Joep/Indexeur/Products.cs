using System;
using System.Collections.Generic;
using System.Text;

namespace indexeur

{
    public class Product
    {
        string Sku { get; set; }
        string Description { get; set; }
        double Price { get; set; }

        public Product(string sku, string description, double price)
        {
            Sku = sku;
            Description = description;
            Price = price;
        }
    }
    class Products
    {
        Product[] Produit = new Product[10];

        public Product this[int i] 
        {
            set { Produit[i] = value; }
            get { return Produit[i];  }
        }
    }
}

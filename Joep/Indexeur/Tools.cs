using System;
using System.Collections.Generic;
using System.Text;

namespace indexeur
{
    public class InvalidSkuException : Exception
    {
        public InvalidSkuException() : base("Le sku ne peut pas etre vide") { }
    }
    public class InvalidDescriptionException : Exception
    {
        public InvalidDescriptionException() : base("La description ne peut pas etre vide") { }
    }
    public class InvalidPriceException : Exception
    {
        public InvalidPriceException() : base("Le prix doit etre superieur a zero") { }
    }
}

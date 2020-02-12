using System;
using System.Collections.Generic;
using System.Text;

namespace CMWholesalers.DataAccessLayer
{
    public enum TypeOfDrink
    {
        Alcholic,
        NonAlcoholic
    }

    public class Drink : Product
    {
        public TypeOfDrink TypeOfDrinks { get; set; }

        public Drink()
        {

        }

        public Drink(string productid, string productname, double productselllingprice, double producttax, int productquantity, DateTime productpurchasedate, TypeOfDrink typeofdrink) : base(productid, productname, productselllingprice, producttax, productquantity, productpurchasedate)
        {
            TypeOfDrinks = typeofdrink;
        }
    }
}

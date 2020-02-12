using System;
using System.Collections.Generic;
using System.Text;

namespace CMWholesalers.DataAccessLayer
{
    public enum TypeOfFood
    {
        Perishable,
        NonPerishable
    }

    public class Food : Product
    {
        public TypeOfFood TypeOfFoods { get; set; }

        public Food()
        {

        }

        public Food(string productid, string productname, double productselllingprice, double producttax, int productquantity, DateTime productpurchasedate, TypeOfFood typeoffood) : base(productid, productname, productselllingprice, producttax, productquantity, productpurchasedate)
        {
            TypeOfFoods = typeoffood;
        }

        public bool Sellable()
        {
            if (TypeOfFoods == TypeOfFood.Perishable && (DateTime.Now - ProductPurchaseDate).TotalDays > 7)
            {
                return false;
            }
            return true;
        }
    }
}

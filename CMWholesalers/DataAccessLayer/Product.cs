using System;
using System.Collections.Generic;
using System.Text;

namespace CMWholesalers.DataAccessLayer
{
    public class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductSellingPrice { get; set; }
        public double ProductTax { get; set; }
        public int ProductQuantity { get; set; }
        public DateTime ProductPurchaseDate { get; set; }

        public Product()
        {

        }

        public Product(string productid, string productname, double productselllingprice, double producttax, int productquantity, DateTime productpurchasedate)
        {
            ProductId = productid;
            ProductName = productname;
            ProductSellingPrice = productselllingprice;
            ProductTax = producttax;
            ProductQuantity = productquantity;
            ProductPurchaseDate = productpurchasedate;
        }
    }
}

using CMWholesalers.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMWholesalers.BusinessLogicLayer
{
    public enum Tax
    {
       CasualCustomers = 15,
       BulkCustomers = 0
    }
    public class ProductLogic
    {
        public List<Product> ProductsForSale { get; set; }
        public ProductLogic()
        {
            ProductsForSale = new List<Product>()
            {
                new Drink("P001","Red Wine",150.00,0.15,5,new DateTime(2020, 02, 07),TypeOfDrink.Alcholic),
                new Drink("P002","Coke",15.00,0.00,10,new DateTime(2020, 02, 03),TypeOfDrink.NonAlcoholic),
                new Food("P003","Cake",80.00,0.00,1,new DateTime(2020,02,04),TypeOfFood.Perishable),
                new Food("P004","Baked Beans",20.00,0.00,20,new DateTime(2020,01,27),TypeOfFood.NonPerishable)
            };
        }

        public void PurchaseStockFromSupplier(string productid, string productname, double productselllingprice, double producttax, int productquantity, DateTime productpurchasedate, Product products, Supplier supplier)
        {
            foreach (var product in ProductsForSale)
            {
                if (supplier.SupplierProductName.Equals(products.ProductName))
                {
                    products.ProductId = productid + 1;
                    products.ProductName = productname;
                    products.ProductSellingPrice = productselllingprice;
                    products.ProductTax = producttax;
                    products.ProductQuantity = productquantity;
                    products.ProductPurchaseDate = DateTime.Now.Date;
                }
            }
            ProductsForSale.Add(products);
        }

        public void RemoveProductQuanity(int productquantity, Product products)
        {
            foreach (var product in ProductsForSale)
            {
                if (product.ProductName.Equals(products.ProductName))
                {
                    products.ProductQuantity -= productquantity;
                }
            }
        }

        public int GetQuantityOfStock(Product products)
        {
            foreach (var product in ProductsForSale)
            {
                if (products.ProductName == product.ProductName)
                {
                    return product.ProductQuantity;
                }
            }
            return -1;
        }

        public void DisplayCart(Customer customer, Product product, int quantity)
        {
            var customerLogic = new CustomerLogic();
            var drink = new Drink();
            foreach (var products in ProductsForSale)
            {
                if (products.ProductName.Equals(product.ProductName) && quantity <=products.ProductQuantity)
                {
                    RemoveProductQuanity(quantity, products);
                    
                    Console.WriteLine($"Product Name: {product.ProductName}");
                    Console.WriteLine($"Selling Price: {product.ProductSellingPrice}");
                    Console.WriteLine($"Tax Amount: {customerLogic.CalculateTax(customer, drink)}");
                    Console.WriteLine($"Markup: {customerLogic.CalculateMarkup(product, customer)}");
                    Console.WriteLine($"Total: {customerLogic.CalculateTotal(product, customer, drink)}");
                } 
            }
           
        }

    }
}

using CMWholesalers.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMWholesalers.BusinessLogicLayer
{
    public class SupplierLogic
    {
        public List<SupplierProduct> SuppliersProductsForSale { get; set; }
        public SupplierLogic()
        {
            SuppliersProductsForSale = new List<SupplierProduct>()
            {
                new SupplierProduct(TypesOfSuppliers.S001, "White Wine", 180.00, 100, new DateTime(2020, 02, 07), TypesofSupplierProduct.Drinks),
                new SupplierProduct(TypesOfSuppliers.S001, "Coke", 15.00, 50, new DateTime(2020, 01, 02), TypesofSupplierProduct.Drinks),
                new SupplierProduct(TypesOfSuppliers.S001, "Chocolate Cake", 80.00, 5, new DateTime(2020, 02, 05), TypesofSupplierProduct.Food),
                new SupplierProduct(TypesOfSuppliers.S001, "Baked Beans", 20.00, 30, new DateTime(2019, 12, 05), TypesofSupplierProduct.Food),
                new SupplierProduct(TypesOfSuppliers.S001, "Spideman Action Figure", 200.00, 10, new DateTime(2019, 12, 05), TypesofSupplierProduct.Toys),
                new SupplierProduct(TypesOfSuppliers.S002, "White Wine", 170.00, 100, new DateTime(2020, 02, 07), TypesofSupplierProduct.Drinks),
                new SupplierProduct(TypesOfSuppliers.S002, "Coke", 13.00, 50, new DateTime(2020, 01, 02), TypesofSupplierProduct.Drinks),
                new SupplierProduct(TypesOfSuppliers.S002, "Chocolate Cake", 70.00, 5, new DateTime(2020, 02, 05), TypesofSupplierProduct.Food),
                new SupplierProduct(TypesOfSuppliers.S002, "Baked Beans", 180.00, 30, new DateTime(2019, 12, 05), TypesofSupplierProduct.Food),
                new SupplierProduct(TypesOfSuppliers.S002, "Spideman Action Figure", 180.00, 10, new DateTime(2019, 12, 05), TypesofSupplierProduct.Toys),
            };
        }

        public int GetQuantityOfStock(Product products)
        {
            foreach (var product in SuppliersProductsForSale)
            {
                if (products.ProductName == product.SupplierProductName)
                {
                    return (int)product.SupplierQuantity;
                }
            }
            return -1;
        }
    }
}


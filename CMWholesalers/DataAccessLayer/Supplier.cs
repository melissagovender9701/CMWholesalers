using System;
using System.Collections.Generic;
using System.Text;

namespace CMWholesalers.DataAccessLayer
{

    public class Supplier
    {
        public string SupplierProductName { get; set; }
        public double SupplierSellingPrice { get; set; }
        public double SupplierQuantity { get; set; }
        public DateTime SupplierPurchaseDate { get; set; }

        public Supplier()
        {

        }

        public Supplier(string suppliername, double supplierselllingprice, int supplierquantity, DateTime supplierpurchasedate)
        {
            SupplierProductName = suppliername;
            SupplierSellingPrice = supplierselllingprice;
            SupplierQuantity = supplierquantity;
            SupplierPurchaseDate = supplierpurchasedate;
        }
    }
}

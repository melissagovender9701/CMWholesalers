using System;
using System.Collections.Generic;
using System.Text;

namespace CMWholesalers.DataAccessLayer
{
    public enum TypesofSupplierProduct
    {
        Food,
        Drinks,
        Toys,
    }

    public enum TypesOfSuppliers
    {
        S001,
        S002
    }

    public class SupplierProduct : Supplier
    {
        public TypesofSupplierProduct TypeOfSupplierProducts { get; set; }
        public TypesOfSuppliers TypeofSupplier { get; set; }

        public SupplierProduct()
        {

        }

        public SupplierProduct(TypesOfSuppliers typesOfSuppliers, string suppliername, double supplierselllingprice, int supplierquantity, DateTime supplierpurchasedate, TypesofSupplierProduct typesofsupplierproducts) : base(suppliername, supplierselllingprice, supplierquantity, supplierpurchasedate)
        {
            TypeofSupplier = typesOfSuppliers;
            TypeOfSupplierProducts = typesofsupplierproducts;
        }
    }
}

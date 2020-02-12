using System;
using System.Collections.Generic;
using System.Text;

namespace CMWholesalers.DataAccessLayer
{
    public enum TypesOfCustomers
    {
        BulkCustomer = 20,
        CasualCustomer = 100
    }
    public class Customer
    {
        public TypesOfCustomers TypeOfCustomer { get; set; }
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmailAddress { get; set; }

        public Customer()
        {

        }

        public Customer(string customerid, string customername, string customeremailaddress, TypesOfCustomers typesOfCustomers)
        {
            CustomerID = customerid;
            CustomerName = customername;
            CustomerEmailAddress = customeremailaddress;
            TypeOfCustomer = typesOfCustomers;
        }
    }
}

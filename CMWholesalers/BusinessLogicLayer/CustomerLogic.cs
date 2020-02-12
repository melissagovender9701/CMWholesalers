using CMWholesalers.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMWholesalers.BusinessLogicLayer
{
    public class CustomerLogic
    {
        public List<Customer> CustomerDetails { get; set; }
        public CustomerLogic()
        {
            CustomerDetails = new List<Customer>()
            {
                new Customer("C001","Chris","chrisminoko@gmail.com",TypesOfCustomers.BulkCustomer),
                new Customer("C002","Melissa","melissagovender@gmail.com",TypesOfCustomers.CasualCustomer),
                new Customer("C003","Ryan","ryangovender@gmail.com",TypesOfCustomers.CasualCustomer),
                new Customer("C004","Varun","uncleenum@gmail.com",TypesOfCustomers.BulkCustomer)
            };
        }

        public double GetMarkupPercentage(Customer customer)
        {
            if (customer.TypeOfCustomer.Equals(TypesOfCustomers.CasualCustomer))
            {
                return Convert.ToDouble((int)TypesOfCustomers.CasualCustomer)/100;
            }
            else if (customer.TypeOfCustomer.Equals(TypesOfCustomers.BulkCustomer))
            {
                return Convert.ToDouble((int)TypesOfCustomers.BulkCustomer)/100;
            }
            return 0;
        }

        public double CalculateTax(Customer customer, Drink drink)
        {
            if (customer.TypeOfCustomer.Equals(TypesOfCustomers.CasualCustomer) && drink.TypeOfDrinks.Equals(TypeOfDrink.Alcholic))
            {
                return Convert.ToDouble(Tax.CasualCustomers) / 100;
            }
            return 0;
        }

        public double CalculateMarkup(Product product, Customer customer)
        {
            return GetMarkupPercentage(customer) * product.ProductSellingPrice;
        }

        public double CalculateTotal(Product product, Customer customer, Drink drink)
        {
            return product.ProductSellingPrice + CalculateMarkup(product, customer) + CalculateTax(customer, drink);
        }

    }
}

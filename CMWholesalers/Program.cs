using CMWholesalers.BusinessLogicLayer;
using CMWholesalers.DataAccessLayer;
using System;

namespace CMWholesalers
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer("C005", "Lungelo","lungelonkosi@gmail.com",TypesOfCustomers.CasualCustomer);
            var product = new Product("P001", "Red Wine", 150.00, 0.15, 1, new DateTime(2020, 02, 07));
            var productLogic = new ProductLogic();
            Console.WriteLine("************************************************** Reciept **************************************************");
            productLogic.DisplayCart(customer, product, 3);
            Console.ReadKey();
        }
    }
}

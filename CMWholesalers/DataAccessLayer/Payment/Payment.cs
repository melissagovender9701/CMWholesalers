using System;
using System.Collections.Generic;
using System.Text;

namespace CMWholesalers.DataAccessLayer
{
    public enum PaymentOption
    {
        Card,
        Cash,
        PayPal
    }

    public class Payment
    {
        public Customer Customers { get; set; }
        public PaymentOption PaymentOptions { get; set; }
        public double AmountPaid { get; set; }
        public double Change { get; set; }

        public Payment()
        {

        }

        public Payment(Customer customer, PaymentOption paymentOption, double amountpaid, double change)
        {
            Customers = customer;
            PaymentOptions = paymentOption;
            AmountPaid = amountpaid;
            Change = change;
        }
    }
}

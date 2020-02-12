using CMWholesalers.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMWholesalers.BusinessLogicLayer
{
    public class PaymentLogic
    {
        public List<Payment> Payment { get; set; }
        public PaymentLogic()
        {
            Payment = new List<Payment>()
            {
                new Payment(),
               
            };
        }
    }
}

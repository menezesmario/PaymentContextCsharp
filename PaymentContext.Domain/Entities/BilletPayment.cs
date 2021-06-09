using System;

namespace PaymentContext.Domain.Entities
{
    
    public class BilletPayment : Payment
    {
        public BilletPayment(string barCode, string billetNumber,  DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, string document, string address, string email) : base(paidDate, expireDate, total, totalPaid, payer, document, address, email)
        {
            BarCode = barCode;
            BilletNumber = billetNumber;
        }

        public string BarCode { get; private set; }
        public string BilletNumber { get; private set; }        
    }

}
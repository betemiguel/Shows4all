using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shows4all.App.Data.Entities
{
    public class CreditCardPayment
    {
        public int Id { get; set; }

        public string CardName { get; set; }

        public int Number { get; set; }

        public int CVV { get; set; }

        public DateTime ExpDate { get; set; }

        public  Customer Customer { get; set; }

        [ForeignKey("Customer")]
        public int IdCustomer { get; set; }

    }
}

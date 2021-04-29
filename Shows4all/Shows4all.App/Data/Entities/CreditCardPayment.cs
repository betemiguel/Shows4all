using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

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

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shows4all.App.Data.Entities
{
    public class Payment
    {
        public int Id { get; set; }

        public Rental Rental { get; set; }
        [ForeignKey("Rental")]
        public int IdRental { get; set; }


        public CreditCardPayment CrediCardPayment{ get; set; }
        [ForeignKey("CrediCardPayment")]
        public int IdCrediCardPayment { get; set; }

        
    }
}

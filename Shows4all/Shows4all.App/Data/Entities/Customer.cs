using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shows4all.App.Data.Entities
{
    public class Customer 
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime Birthdate { get; set; }

        public string Email { get; set; }


        public Rental Rental { get; set; }
        [ForeignKey("Rental")]
        public int IdRental { get; set; }
        






    }
}

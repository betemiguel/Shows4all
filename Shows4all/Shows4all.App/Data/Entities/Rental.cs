using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shows4all.App.Data.Entities
{
    public class Rental
    {
        public int Id { get; set; }

        public DateTime DateRented { get; set; }


        public Serie Serie { get; set; }
        [ForeignKey("Serie")]
        public int IdSerie { get; set; }

        public double Total()
        {
            return Serie.Price;

        }


    }
}

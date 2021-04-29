using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shows4all.App.Data.Entities
{
    public class PriceSeries
    {

        public int Id { get; set; }
       

        public double Price { get; set; }

        public int NumEpisodes { get; set; }

        public Genre Genre { get; set; }

        public Serie Serie { get; set; }
        [ForeignKey("Serie")]
        public int IdSerie { get; set; }

    }
}

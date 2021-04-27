using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shows4all.App.Data.Entities
{
    public class Serie
    {
        public int Id { get; set; }

        
        public string Name { get; set; }


        public int Episode { get; set; }

        public Genre Genre { get; set; }

        public int GenreId { get; set; }

        public DateTime ReleaseDate { get; set; }

        public decimal Price { get; set; }

        public string Rating { get; set; }

        public Customer Customer { get; set; }

        [ForeignKey ("Customer")]
        public int IdCustomer { get; set; }

        public Actor  Actor { get; set; }
        [ForeignKey("Actor")]
        public int IdActor { get; set; }

        public Season Season { get; set; }
        [ForeignKey("Season")]
        public int IdSeason { get; set; }
    }
}

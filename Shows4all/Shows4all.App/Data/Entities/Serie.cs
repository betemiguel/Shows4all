using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shows4all.App.Data.Entities
{
    public class Serie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

  
        public DateTime? ReleaseDate { get; set; }

        public Genre Genre { get; set; }
        [ForeignKey("Genre")]
        public int IdGenre { get; set; }

        public Country Country { get; set; }
        [ForeignKey("Country")]
        public int IdCountry { get; set; }
        public ICollection<Comment> Comments { get; set; }
        
     

       

    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shows4all.App.Data.Entities
{
    public class Serie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Rating { get; set; }

  
        public DateTime ReleaseDate { get; set; }
        public Genre Genre { get; set; }

        
        public Season Season { get; set; }
        [ForeignKey("Season")]
        public int IdSeason { get; set; }

       

    }
}

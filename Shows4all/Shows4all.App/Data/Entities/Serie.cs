using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shows4all.App.Data.Entities
{
    public class Serie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

  
        public DateTime? ReleaseDate { get; set; }
        public Genre Genre { get; set; }

        public ICollection<Comment> Comments { get; set; }
        
     

       

    }
}

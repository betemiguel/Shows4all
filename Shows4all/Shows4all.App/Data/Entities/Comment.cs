using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shows4all.App.Data.Entities
{
    public class Comment
    {
        public int Id { get; set; }

        public string Comments { get; set; }

        public DateTime PublishedDAte { get; set; }

        public int Rating { get; set; }

        public Serie Serie { get; set; }
        [ForeignKey("Serie")]
        public int IdSerie { get; set; }


    }
}

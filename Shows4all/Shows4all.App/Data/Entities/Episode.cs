using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shows4all.App.Data.Entities
{
    public class Episode
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int EpisodeNumber { get; set; }

       


    }
}

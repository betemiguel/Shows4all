using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shows4all.App.Data.Entities
{
    public class Season
    {
        public int Id { get; set; }

        public int SeasonNumber { get; set; }

        public Episode Episode { get; set; }
        [ForeignKey("Episode")]
        public int IdEpisode { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace Shows4all.App.Data.Entities
{
    public class Season
    {
        public int Id { get; set; }

        public int SeasonNumber { get; set; }



        public Serie Serie { get; set; }
        [ForeignKey("Serie")]
        public int IdSerie { get; set; }
    }
}

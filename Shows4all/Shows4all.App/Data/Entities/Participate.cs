using System.ComponentModel.DataAnnotations.Schema;

namespace Shows4all.App.Data.Entities
{
    public class Participate
    {
        public int  Id { get; set; }

        public Actor Actor { get; set; }
        [ForeignKey("Actor")]
        public int IdActor { get; set; }
        
        public Episode Episode { get; set; }
        [ForeignKey("Episode")]
        public int IdEpisode { get; set; }


    }
}

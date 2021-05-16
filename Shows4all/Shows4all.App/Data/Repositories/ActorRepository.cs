using Shows4all.App.Data.Context;
using Shows4all.App.Data.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace Shows4all.App.Data.Repositories
{
    public class ActorRepository
    {
        private readonly Shows4AllDbContext _ctx;

        public ActorRepository (Shows4AllDbContext ctx)
        {

            _ctx = ctx;

        }

        public async Task<Actor> GetAsync(int id)
        {
            return await _ctx.Actors.FindAsync(id);
        }

        public Actor Add(int id, string name)
        {
            var actor = new Actor() { Id = id, Name = name };

            _ctx.Actors.Add(actor);
             _ctx.SaveChanges();

            return actor;
        }

        public async Task<Actor> AddActorAsync(Actor actor)
        {
    
            _ctx.Actors.Add(actor);
            await _ctx.SaveChangesAsync();

            return actor;
        }

        public async Task<bool> DeleteActorAsync (int Id)
        {
            var actor = _ctx.Actors.FirstOrDefault(u => u.Id == Id);
            if (actor == null)
                return false;

            _ctx.Remove(actor);
           await _ctx.SaveChangesAsync();
            return true;
        }
    }
}

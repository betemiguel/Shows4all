using Shows4all.App.Data.Context;
using Shows4all.App.Data.Entities;
using System.Linq;
using System.Threading.Tasks;


namespace Shows4all.App.Data.Repositories
{
    public class AdminRepository
    {

        private readonly Shows4AllDbContext _ctx;

        public AdminRepository(Shows4AllDbContext ctx)
        {

            _ctx = ctx;

        }

        public async Task<Admin> GetAsync(int id)
        {
            return await _ctx.Admins.FindAsync(id);

        }

      

        public async Task<Admin> AddAdminAsync(Admin admin)
        {

            _ctx.Admins.Add(admin);
            await _ctx.SaveChangesAsync();

            return admin;
        }

        public async Task<bool> DeleteAdminAsync(int Id)
        {
            var admin = _ctx.Admins.FirstOrDefault(u => u.Id == Id);
            if (admin == null)
                return false;

            _ctx.Remove(admin);
            await _ctx.SaveChangesAsync();
            return true;
        }
    }

}

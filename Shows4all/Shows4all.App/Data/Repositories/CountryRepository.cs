using Shows4all.App.Data.Context;
using Shows4all.App.Data.Entities;
using System.Linq;
using System.Threading.Tasks;


namespace Shows4all.App.Data.Repositories
{
    public class CountryRepository
    {

        private readonly Shows4AllDbContext _ctx;

        public CountryRepository(Shows4AllDbContext ctx)
        {

            _ctx = ctx;

        }

        public async Task<Country> GetAsync(int id)
        {
            return await _ctx.Country.FindAsync(id);

        }

        public Country AddCountry(int id, string name)
        {
            var country = new Country() { Id = id, Name = name };

            _ctx.Country.Add(country);
            _ctx.SaveChanges();

            return country;
        }

        public async Task<Country> AddCountryAsync(Country country)
        {

            _ctx.Country.Add(country);
            await _ctx.SaveChangesAsync();

            return country;
        }

        public async Task<bool> DeleteCountryAsync(int Id)
        {
            var country = _ctx.Country.FirstOrDefault(u => u.Id == Id);
            if (country == null)
                return false;

            _ctx.Remove(country);
            await _ctx.SaveChangesAsync();
            return true;
        }
    }

}

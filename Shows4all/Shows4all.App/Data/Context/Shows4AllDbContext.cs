
using Microsoft.EntityFrameworkCore;
using Shows4all.App.Data.Entities;


namespace Shows4all.App.Data.Context
{
    public class Shows4AllDbContext :DbContext
    {
        public Shows4AllDbContext(DbContextOptions<Shows4AllDbContext> options) : base (options)
        {

        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<CreditCardPayment> CreditCardsPayment { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<PriceSeries> PricesSeries { get; set; }
        public DbSet<Serie> Series { get; set; }
        public DbSet<Participate> Participates { get; set; }


    }
}


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
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Participate> Participates { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Season> Season { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Serie> Serie { get; set; }
        public DbSet<Shows4all.App.Data.Entities.Payment> Payment { get; set; }
        public DbSet<Shows4all.App.Data.Entities.Country> Country { get; set; }
        public object Countries { get; internal set; }
    }
}

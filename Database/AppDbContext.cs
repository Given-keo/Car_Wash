using Microsoft.EntityFrameworkCore;
using Car_Wash.Model;
using System.Collections.Generic;

namespace Car_Wash.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=db_car_wash;Username=postgres;Password=");
            }
        }
    }
}

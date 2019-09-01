using Microsoft.EntityFrameworkCore;
using StockExchangePricesService.Entities;

namespace StockExchangePricesService
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }

        public DbSet<Price> Prices { get; set; }

        protected ApplicationContext()
        {
            Database.EnsureCreated();
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=NeuralNetTest;Integrated Security=True");
        }
    }
}

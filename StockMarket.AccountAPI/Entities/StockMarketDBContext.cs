using Microsoft.EntityFrameworkCore;

namespace StockMarket.AccountAPI.Entities
{
    public class StockMarketDBContext : DbContext
    {
        public DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=HP-PAVILION\SQLEXPRESS;Initial Catalog=StockMarketDB;Integrated Security=True");
        }
    }
}

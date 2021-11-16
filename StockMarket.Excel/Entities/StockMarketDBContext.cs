using Microsoft.EntityFrameworkCore;

namespace StockMarket.Admin.Entities
{
    public class StockMarketDBContext : DbContext
    {
        public DbSet<Sector> Sectors { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Ipo> Ipos { get; set; }

        public DbSet<StockExchange> StockExchanges { get; set; }

        public DbSet<StockPrice> StockPrices { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=HP-PAVILION\SQLEXPRESS;Initial Catalog=StockMarketDB;Integrated Security=True");
        }
    }
}

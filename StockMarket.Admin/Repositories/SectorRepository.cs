using StockMarket.Admin.Entities;
namespace StockMarket.Admin.Repositories
{
    public class SectorRepository : ISectorRepository
    {
        private readonly StockMarketDBContext db = new StockMarketDBContext();
        public void AddSector(Sector sector)
        {
            db.Sectors.Add(sector); 
            db.SaveChanges();
        }
    }
}

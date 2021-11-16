using StockMarket.Admin.Entities;
using System.Collections.Generic;
using System.Linq;

namespace StockMarket.Admin.Repositories
{
    public class StockExchangeRepository : IStockExchangeRepository
    {
        private readonly StockMarketDBContext db = new StockMarketDBContext();
        public void AddSE(StockExchange value)
        {
            db.StockExchanges.Add(value);
            db.SaveChanges();
        }

        public void DeleteSE(int id)
        {
            StockExchange se = db.StockExchanges.Find(id);
            db.StockExchanges.Remove(se);
            db.SaveChanges();
        }

        public void DeleteSEByName(string name)
        {
            StockExchange se = db.StockExchanges.SingleOrDefault(user => user.StockExchangeName == name);
            db.StockExchanges.Remove(se);
            db.SaveChanges();
        }

        public List<StockExchange> GetAllSE()
        {
            return db.StockExchanges.ToList();
        }

        public StockExchange GetSE(int id)
        {
            StockExchange se = db.StockExchanges.Find(id);
            return se;
        }

        public StockExchange GetSEByName(string name)
        {
            StockExchange se = db.StockExchanges.SingleOrDefault(user => user.StockExchangeName == name);
            return se;
        }

        public void UpdateSE(StockExchange value)
        {
            db.StockExchanges.Update(value);
            db.SaveChanges();
        }
    }
}

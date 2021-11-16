using StockMarket.Admin.Entities;
using System.Collections.Generic;

namespace StockMarket.Admin.Repositories
{
    public interface IStockExchangeRepository
    {
        public void AddSE(StockExchange value);
        public void DeleteSE(int id);
        public void DeleteSEByName(string name);
        public void UpdateSE(StockExchange value);
        public List<StockExchange> GetAllSE();
        public StockExchange GetSE(int id);
        public StockExchange GetSEByName(string name);
    }
}

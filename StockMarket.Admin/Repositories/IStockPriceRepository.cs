using StockMarket.Admin.Entities;
using System.Collections.Generic;

namespace StockMarket.Admin.Repositories
{
    public interface IStockPriceRepository
    {
        public void AddStockPrice(StockPrice value);
        public void DeleteStockPrice(string name);
        public void UpdateStockPrice(StockPrice value);
        public StockPrice GetStockPriceByName(string name);
        public List<StockPrice> GetAllStockPrice();
    }
}

using StockMarket.Admin.Entities;
using System.Collections.Generic;

namespace StockMarket.Admin.Repositories
{
    public interface IIpoRepository
    {
        public void AddIpo(Ipo value);
        public void DeleteIpo(int id);
        public void DeleteByName(string name);
        public void UpdateIpo(Ipo value);
        public List<Ipo> GetAllIpo();
        public Ipo GetIpoByName(string name);
        public Ipo GetIpoById(int id);
    }
}

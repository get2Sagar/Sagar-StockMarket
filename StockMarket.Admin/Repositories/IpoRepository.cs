using StockMarket.Admin.Entities;
using System.Collections.Generic;
using System.Linq;

namespace StockMarket.Admin.Repositories
{
    public class IpoRepository : IIpoRepository
    {
        private readonly StockMarketDBContext db = new StockMarketDBContext();
        public void AddIpo(Ipo value)
        {
            db.Ipos.Add(value);
            db.SaveChanges();
        }

        public void DeleteByName(string name)
        {
            Ipo myIpo = db.Ipos.SingleOrDefault(user => user.CompanyName == name);
            db.Ipos.Remove(myIpo);
            db.SaveChanges();
        }

        public void DeleteIpo(int id)
        {
            Ipo ipo = db.Ipos.Find(id);
            db.Ipos.Remove(ipo);
            db.SaveChanges();
        }

        public List<Ipo> GetAllIpo()
        {
            return db.Ipos.ToList();
        }

        public Ipo GetIpoById(int id)
        {
            Ipo ipo = db.Ipos.Find(id);
            return ipo;
        }

        public Ipo GetIpoByName(string name)
        {
            Ipo myIpo = db.Ipos.SingleOrDefault(user => user.CompanyName == name);
            return myIpo;
        }

        public void UpdateIpo(Ipo value)
        {
            db.Ipos.Update(value);
            db.SaveChanges();
        }
    }
}

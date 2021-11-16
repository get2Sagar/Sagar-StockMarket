
using System.Collections.Generic;
using System.Linq;
using StockMarket.Admin.Entities;

namespace StockMarket.Admin.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly StockMarketDBContext db = new StockMarketDBContext();

        public void AddCompany(Company value)
        {
            db.Companies.Add(value);
            db.SaveChanges();
        }

        public void DeleteCompany(string id)
        {
            Company company = db.Companies.Find(id);
            db.Companies.Remove(company);
            db.SaveChanges();
        }

        public List<Company> GetAllCompany()
        {
            return db.Companies.ToList();
        }

        public Company GetCompanyByName(string name)
        {
            Company comp = db.Companies.Find(name);
            return comp;
        }

        public void UpdateCompany(Company value)
        {
            db.Companies.Update(value);
            db.SaveChanges();
        }
    }
}

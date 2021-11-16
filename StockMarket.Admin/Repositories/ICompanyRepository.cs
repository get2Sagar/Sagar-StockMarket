using StockMarket.Admin.Entities;
using System.Collections.Generic;
namespace StockMarket.Admin.Repositories
{
    public interface ICompanyRepository
    {
        void AddCompany(Company value);
        void DeleteCompany(string id);
        void UpdateCompany(Company value);
        List<Company> GetAllCompany();
        Company GetCompanyByName(string name);
    }
}

using StockMarket.AccountAPI.Models;
using StockMarket.AccountAPI.Entities;
namespace StockMarket.AccountAPI.Repositories
{
    public interface IUserRepository
    {
        void Register(Users user);

        Users Validate(Login login);
    }
}

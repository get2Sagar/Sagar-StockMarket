using StockMarket.AccountAPI.Entities;
using StockMarket.AccountAPI.Models;
using System.Linq;

namespace StockMarket.AccountAPI.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly StockMarketDBContext db = new StockMarketDBContext();
        public void Register(Users user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public Users Validate(Login login)
        {
            Users user = db.Users.SingleOrDefault(u => u.UserName == login.UserName && u.Password == login.Password);
            return user;
        }
    }
}

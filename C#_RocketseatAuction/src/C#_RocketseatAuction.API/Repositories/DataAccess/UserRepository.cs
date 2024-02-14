using C__RocketseatAuction.API.Contracts;
using C__RocketseatAuction.API.Entities;

namespace C__RocketseatAuction.API.Repositories.DataAccess
{
    public class UserRepository : IUserRepository
    {
        private readonly RocketseatAuctionDbContext _dbContext;

        public UserRepository(RocketseatAuctionDbContext dbContext) => _dbContext = dbContext;

        public bool ExistUserWithEmail(string email)
        {
            return _dbContext.Users.Any(user => user.Email.Equals(email));
        }
        public User GetUserByEmail(string email)
        {
            return _dbContext.Users.First(user => user.Email.Equals(email));
        }
    }
}

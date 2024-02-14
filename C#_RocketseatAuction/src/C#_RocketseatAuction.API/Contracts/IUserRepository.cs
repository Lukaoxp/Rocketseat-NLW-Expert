using C__RocketseatAuction.API.Entities;

namespace C__RocketseatAuction.API.Contracts
{
    public interface IUserRepository
    {
        bool ExistUserWithEmail(string email);
        User GetUserByEmail(string email);
    }
}

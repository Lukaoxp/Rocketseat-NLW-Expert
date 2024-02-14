using C__RocketseatAuction.API.Entities;

namespace C__RocketseatAuction.API.Contracts
{
    public interface IAuctionRepository
    {
        Auction? GetCurrent();
    }
}

using C__RocketseatAuction.API.Contracts;
using C__RocketseatAuction.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace C__RocketseatAuction.API.Repositories.DataAccess
{
    public class AuctionRepository : IAuctionRepository
    {
        private readonly RocketseatAuctionDbContext _dbContext;
        public AuctionRepository(RocketseatAuctionDbContext dbContext) => _dbContext = dbContext;

        public Auction? GetCurrent()
        {
            var today = new DateTime(2024, 1, 25);

            return _dbContext
                .Auctions
                .Include(auction => auction.Items)
                .FirstOrDefault(auction => auction.Starts <= today && auction.Ends >= today);
        }
    }
}

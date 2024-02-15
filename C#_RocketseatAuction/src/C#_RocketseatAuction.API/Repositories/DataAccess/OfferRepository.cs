using C__RocketseatAuction.API.Contracts;
using C__RocketseatAuction.API.Entities;

namespace C__RocketseatAuction.API.Repositories.DataAccess
{
    public class OfferRepository : IOfferRepository
    {
        private readonly RocketseatAuctionDbContext _dbContext;
        public OfferRepository(RocketseatAuctionDbContext dbContext) => _dbContext = dbContext;

        public void Add(Offer offer)
        {
            _dbContext.Offers.Add(offer);

            _dbContext.SaveChanges();
        }
    }
}

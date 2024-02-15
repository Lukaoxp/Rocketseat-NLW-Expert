using C__RocketseatAuction.API.Entities;

namespace C__RocketseatAuction.API.Contracts
{
    public interface IOfferRepository
    {
        public void Add(Offer offer);
    }
}

using C__RocketseatAuction.API.Contracts;
using C__RocketseatAuction.API.Entities;

namespace C__RocketseatAuction.API.UseCases.Auctions.GetCurrent
{
    public class GetCurrentAuctionUseCase
    {
        private readonly IAuctionRepository _repository;

        public GetCurrentAuctionUseCase(IAuctionRepository repository) =>_repository  = repository;

        public Auction? Execute() => _repository.GetCurrent();        
    }
}

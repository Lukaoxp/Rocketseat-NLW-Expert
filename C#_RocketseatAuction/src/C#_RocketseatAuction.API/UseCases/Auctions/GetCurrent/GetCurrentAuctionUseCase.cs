using C__RocketseatAuction.API.Entities;
using C__RocketseatAuction.API.Repositories;
using Microsoft.EntityFrameworkCore;

namespace C__RocketseatAuction.API.UseCases.Auctions.GetCurrent
{
    public class GetCurrentAuctionUseCase
    {
        public Auction? Execute()
        {
            RocketseatAuctionDbContext repository = new();
            
            var today = new DateTime(2024, 1, 25);

            return repository
                .Auctions
                .Include(auction => auction.Items)
                .FirstOrDefault(auction => auction.Starts <= today && auction.Ends >= today);
        }
    }
}

using C__RocketseatAuction.API.UseCases.Auctions.GetCurrent;
using C__RocketseatAuction.API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace C__RocketseatAuction.API.Controllers
{
    public class AuctionController : RocketseatAuctionBaseController
    {
        [HttpGet]
        [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetCurrentAuction([FromServices] GetCurrentAuctionUseCase useCase)
        {

            var result = useCase.Execute();

            return result is null ? NoContent() : Ok(result);
        }
    }
}

using C__RocketseatAuction.API.UseCases.Auctions.GetCurrent;
using C__RocketseatAuction.API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace C__RocketseatAuction.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuctionController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetCurrentAuction()
        {
            GetCurrentAuctionUseCase useCase = new();

            var result = useCase.Execute();

            return result is null ? NoContent() : Ok(result);
        }
    }
}

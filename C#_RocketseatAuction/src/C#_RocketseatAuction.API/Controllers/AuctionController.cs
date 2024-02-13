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
        public IActionResult GetCurrentAuction()
        {
            GetCurrentAuctionUseCase useCase = new GetCurrentAuctionUseCase();

            Auction result = useCase.Execute();

            return Ok(result);
        }
    }
}

using C__RocketseatAuction.API.Communication.Requests;
using C__RocketseatAuction.API.Filters;
using C__RocketseatAuction.API.UseCases.Offers.CreateOffer;
using Microsoft.AspNetCore.Mvc;

namespace C__RocketseatAuction.API.Controllers
{
    [ServiceFilter(typeof(AuthenticationUserAttribute))]
    public class OfferController : RocketseatAuctionBaseController
    {
        [HttpPost]
        [Route("{itemId}")]
        public IActionResult CreateOffer(
            [FromRoute] int itemId,
            [FromBody] RequestCreateOfferJson request,
            [FromServices] CreateOfferUseCase useCase)
        {
            var id = useCase.Execute(itemId, request);

            return Created(string.Empty, id);
        }
    }
}

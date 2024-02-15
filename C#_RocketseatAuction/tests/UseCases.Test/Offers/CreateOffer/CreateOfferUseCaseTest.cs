using Bogus;
using C__RocketseatAuction.API.Communication.Requests;
using C__RocketseatAuction.API.Contracts;
using C__RocketseatAuction.API.Entities;
using C__RocketseatAuction.API.Services;
using C__RocketseatAuction.API.UseCases.Offers.CreateOffer;
using FluentAssertions;
using Moq;

namespace UseCases.Test.Offers.CreateOffer
{
    public class CreateOfferUseCaseTest
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void Success(int itemId)
        {
            //Arrange
            var request = new Faker<RequestCreateOfferJson>()
                .RuleFor(request => request.Price, f => f.Random.Decimal(1, 10000)).Generate();

            var offerRepository = new Mock<IOfferRepository>();
            var loggedUser = new Mock<ILoggedUser>();
            loggedUser.Setup(i => i.User()).Returns(new User());

            var useCase = new CreateOfferUseCase(loggedUser.Object, offerRepository.Object);

            //Act
            var act = () => useCase.Execute(itemId, request);

            //Assert
            act.Should().NotThrow();
        }
    }
}

using Bogus;
using C__RocketseatAuction.API.Contracts;
using C__RocketseatAuction.API.Entities;
using C__RocketseatAuction.API.Enums;
using C__RocketseatAuction.API.UseCases.Auctions.GetCurrent;
using FluentAssertions;
using Moq;

namespace UseCases.Test.Auctions.GetCurrent
{
    public class GetCurrentAuctionUseCaseTest
    {
        [Fact]
        public void Success()
        {
            //Arrange
            var entity = new Faker<Auction>()
                .RuleFor(a => a.Id, f => f.Random.Number(1, 10))
                .RuleFor(a => a.Name, f => f.Lorem.Word())
                .RuleFor(a => a.Starts, f => f.Date.Past())
                .RuleFor(a => a.Ends, f => f.Date.Future())
                .RuleFor(a => a.Items, (f, auction) => new List<Item>
                {
                    new Item
                    {
                        Id = f.Random.Number(1, 700),
                        Name = f.Commerce.ProductName(),
                        Brand = f.Commerce.Department(),
                        BasePrice = f.Random.Decimal(50, 1000),
                        Condition = f.PickRandom<Condition>(),
                        AuctionId = auction.Id
                    }
                }).Generate();

            var mock = new Mock<IAuctionRepository>();
            mock.Setup(i => i.GetCurrent()).Returns(entity);

            var useCase = new GetCurrentAuctionUseCase(mock.Object);

            //Act
            var auction = useCase.Execute();

            //Assert
            auction.Should().NotBeNull();
            auction.Id.Should().Be(entity.Id);
            auction.Name.Should().Be(entity.Name);
        }
    }
}

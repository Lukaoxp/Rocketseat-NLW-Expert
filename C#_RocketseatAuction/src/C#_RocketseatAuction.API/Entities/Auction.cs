namespace C__RocketseatAuction.API.Entities
{
    public class Auction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Starts { get; set; }
        public DateTime Ends { get; set; }
    }
}

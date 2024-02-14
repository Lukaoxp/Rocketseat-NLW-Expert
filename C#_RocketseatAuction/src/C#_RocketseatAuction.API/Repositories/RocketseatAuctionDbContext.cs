using C__RocketseatAuction.API.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace C__RocketseatAuction.API.Repositories
{
    public class RocketseatAuctionDbContext : DbContext
    {
        public DbSet<Auction> Auctions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\vlnote51\\Desktop\\Lucão\\Estudos\\Rocketseat-NLW-Expert\\C#_RocketseatAuction\\leilaoDbNLW.db");
        }
    }
}

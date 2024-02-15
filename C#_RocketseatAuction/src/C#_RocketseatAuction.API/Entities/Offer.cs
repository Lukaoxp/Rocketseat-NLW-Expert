﻿using System.ComponentModel.DataAnnotations.Schema;

namespace C__RocketseatAuction.API.Entities
{
    [Table("Offers")]
    public class Offer
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public decimal Price { get; set; }
        public int ItemId { get; set; }
        public int UserId { get; set; }
    }
}

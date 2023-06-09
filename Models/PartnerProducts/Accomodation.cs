﻿using System.ComponentModel.DataAnnotations;
using TripMeOn.Models.Products;
using TripMeOn.Models.Users;

namespace TripMeOn.Models.PartnerProducts
{
    public class Accomodation
    {
        [Key]
        public int Id { get; set; }
        public int Capacity { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }

        public int PartnerId { get; set; } // foreign key for Partner
        public virtual Partner Partner { get; set; } // navigation property

        public int DestinationId { get; set; }
        public virtual Destination Destination { get; set; }

        public Accomodation() { }

        public Accomodation(string name, string type, decimal price)
        {
            Name = name;
            Type = type;
            Price = price;
        }
    }
}

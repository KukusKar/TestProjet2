using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TripMeOn.Models.Products
{
    public class Destination
    {

        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Le Pays doit être rempli.")]
        [MaxLength(25)]
        public string Country { get; set; }
        
        public string Region { get; set; }
        public string City { get; set; }
        [Required (ErrorMessage = "La description doit être rempli.")]
        public string Description { get; set; }
        public virtual ICollection<TourPackage> TourPackages { get; set; }


        public Destination() { }


        public Destination(string country, string region, string city, string description)
        {
            Country = country;
            Region = region;
            City = city;
            Description = description;
        }

    }
    
}

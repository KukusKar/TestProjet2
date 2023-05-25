using Microsoft.EntityFrameworkCore;
using TripMeOn.Models.PartnerProducts;
using TripMeOn.Models.Products;
using TripMeOn.Models.Users;

namespace TripMeOn.Models
{
    public class BddContext: DbContext
    {
        public DbSet<TourPackage> TourPackages { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Theme> Themes { get; set; }       
        public DbSet<Client> Clients { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Accomodation> Accomodations { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Transportation> Transportations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user id=root;password=kukuskar;database=TripMeOn");
        }
        public void InitializeDb()
        {
            this.Database.EnsureDeleted();
            this.Database.EnsureCreated();
            this.Destinations.AddRange(
                new Destination
                {
                    Id = 1,
                    Country = "Argentina",
                    Region = "South",
                    City = "Tierra del Fuego",
                    Description = "Endroit incroyable" 
                },
                new Destination
                {
                    Id = 2,
                    Country = "France",
                    Region = "South",
                    Description = "Something proche de chez moi :)"
                }
            );
            this.SaveChanges();
        }
    }
}

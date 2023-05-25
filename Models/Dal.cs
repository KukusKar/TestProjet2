using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TripMeOn.Models.Products;
using TripMeOn.Models.Users;
using System.Linq;

namespace TripMeOn.Models
{
    public class Dal : IDal
    {
        private BddContext _bddContext;
        public Dal()
        {
            _bddContext = new BddContext();
        }
        public void DeleteCreateDatabase()
        {
            _bddContext.Database.EnsureDeleted();
            _bddContext.Database.EnsureCreated();
        }
        public void Dispose()
        {
            _bddContext.Dispose();
        }
        //public void InitializeDB()
        //{
        //    _bddContext.Database.EnsureDeleted();
        //    _bddContext.Database.EnsureCreated();
        //    Theme theme = new Theme() { Id = 1, Name = "Patrimonial" };
        //    Destination destination = new Destination() { Id = 1, Country = "France", City = "Paris", Description = "3 days", Region = "IDF" };
        //    TourPackage tourPackage = new TourPackage() { Id = 1, Name = "blabla",DestinationId = 1, ThemeId=1, Price = 599 };
        //    _bddContext.Destinations.Add(destination);
        //    _bddContext.TourPackages.Add(tourPackage);
        //    _bddContext.SaveChanges();
        //}


        //TOUR PACKAGES
        public List<TourPackage> DisplayTourPackages()
        {
            return _bddContext.TourPackages.ToList();
        }
        public int CreateTourPackage(string name, int themeId, int destinationId, double price)
        {
            TourPackage tourPackage = new TourPackage() { Name = name, ThemeId = themeId, DestinationId = destinationId, Price = price };
            _bddContext.TourPackages.Add(tourPackage);
            _bddContext.SaveChanges();
            return tourPackage.Id;
        }
        public void UpdateTourPackage(int id, string name, int themeId, int destinationId, double price)
        {
            TourPackage tourPackage = _bddContext.TourPackages.Find(id);
            if (tourPackage != null)
            {
                tourPackage.Name = name;
                tourPackage.ThemeId = themeId;
                tourPackage.DestinationId = destinationId;
                tourPackage.Price = price;
                _bddContext.SaveChanges();
            }
        }

        //EMPLOYEES
        public List<Employee> GetEmployees()
        {
            return _bddContext.Employees.ToList();
        }
        public int CreateEmployee(string name, string firstname, string email, string password, string adress, string phonenumber, string jobtitle)
        {
            Employee employee = new Employee() { Name = name, FirstName = firstname, Email = email, Password = password, Address = adress, PhoneNumber = phonenumber, JobTitle = jobtitle };
            _bddContext.Employees.Add(employee);
            _bddContext.SaveChanges();
            return employee.Id;
        }

        //PARTNERS

        public List<Partner> GetPartners()
        {
            return _bddContext.Partners.ToList();
        }
        public int CreatePartner(string name, string firstname, string email, string password, string adress, string phonenumber, string companyName)
        {
            Partner partner = new Partner() { Name = name, FirstName = firstname, Email = email, Password = password, Address = adress, PhoneNumber = phonenumber, CompanyName = companyName };
            _bddContext.Partners.Add(partner);
            _bddContext.SaveChanges();
            return partner.Id;
        }

        //CLIENTS
        public List<Client> GetClients()
        {
            return _bddContext.Clients.ToList();
        }
        public int CreateClient(string name, string firstname, string email, string password, string adress, string phonenumber, string clientType)
        {
            Client client = new Client() { Name = name, FirstName = firstname, Email = email, Password = password, Address = adress, PhoneNumber = phonenumber, ClientType = clientType };
            _bddContext.Clients.Add(client);
            _bddContext.SaveChanges();
            return client.Id;
        }

        // DESTINATION
        public List<Destination> GetDestinations()
        {
            return _bddContext.Destinations.ToList();
        }
        public int CreateDestination(string country, string region, string city, string description)
        {
            Destination destination = new Destination { Country = country, Region = region, City = city, Description = description };
            _bddContext.Destinations.Add(destination);
            _bddContext.SaveChanges();

            return destination.Id;
        }

        public void ModifyDestination (int id, string country, string region, string city, string description)
        {
            Destination destination= _bddContext.Destinations.Find(id);
            if (destination != null)
            {
                destination.Id = id;
                destination.Country= country;
                destination.Region = region;
                destination.City = city;
                destination.Description = description;

                _bddContext.SaveChanges();
            }
        }
        public void ModifyDestination(Destination destination)
        {
            _bddContext.Destinations.Update(destination);
            _bddContext.SaveChanges();
        }

        public void ModifyDestination(string country, string region, string city, string description)
        {
            throw new System.NotImplementedException();
        }


        //public void InitializeDB()
        //{
        //    _bddContext.Database.EnsureDeleted();
        //    _bddContext.Database.EnsureCreated();
        //    Theme theme = new Theme() { Id = 1, Name = "Patrimonial" };
        //    Destination destination = new Destination() { Id = 1, Country = "France", City = "Paris", Description = "3 days", Region = "IDF" };
        //    TourPackage tourPackage = new TourPackage() { Id = 1, Name = "blabla", DestinationId = 1, ThemeId = 1, Price = 599 };
        //    _bddContext.Destinations.Add(destination);
        //    _bddContext.TourPackages.Add(tourPackage);
        //    _bddContext.Themes.Add(theme);
        //    _bddContext.SaveChanges();
        //}
    }

}

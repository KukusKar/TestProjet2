using System;
using System.Collections.Generic;
using TripMeOn.Models.Products;
using TripMeOn.Models.Users;

namespace TripMeOn.Models
{
    public interface IDal: IDisposable
    {
        void DeleteCreateDatabase();
        List<TourPackage> DisplayTourPackages();
        int CreateTourPackage(string name, int themeId, int destinationId, double price);
        void UpdateTourPackage(int id, string name, int themeId, int destinationId, double price);
        List<Employee> GetEmployees();
        int CreateEmployee(string name, string firstname, string email, string password, string adress, string phonenumber, string jobTitle);
        List<Partner> GetPartners();
        int CreatePartner(string name, string firstname, string email, string password, string adress, string phonenumber, string companyName);
        List<Client> GetClients();
        int CreateClient(string name, string firstname, string email, string password, string adress, string phonenumber, string clientType);
        List<Destination> GetDestinations();
        int CreateDestination(string country, string region, string city, string description);
        void ModifyDestination(string country, string region, string city, string description);


    }
}


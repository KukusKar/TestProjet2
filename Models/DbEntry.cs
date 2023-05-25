using TripMeOn.Models.Products;
using System.Collections.Generic;
using TripMeOn.Models.Users;
using System.Linq;
using System;

namespace TripMeOn.Models
{
    //public class DbEntry: IDisposable
    //{
    //        private BddContext _bddContext;

    //        public DbEntry(BddContext bddContext)
    //        {
    //            _bddContext = bddContext;
    //        }

    //    public void Dispose()
    //    {
    //        ((IDisposable)_bddContext).Dispose();
    //    }

    //    public void InitializeDB()
    //    {
    //        _bddContext.Database.EnsureDeleted();
    //        _bddContext.Database.EnsureCreated();
    //        Theme theme = new Theme() { Id = 1, Name = "Patrimonial" };
    //        Destination destination = new Destination() { Id = 1, Country = "France", City = "Paris", Description = "3 days", Region = "IDF" };
    //        TourPackage tourPackage = new TourPackage() { Id = 1, Name = "blabla", DestinationId = 1, ThemeId = 1, Price = 599 };
    //        _bddContext.Destinations.Add(destination);
    //        _bddContext.TourPackages.Add(tourPackage);
    //        _bddContext.Themes.Add(theme);
    //        _bddContext.SaveChanges();
    //    }

    //}
}

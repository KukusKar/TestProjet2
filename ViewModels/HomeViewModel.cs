using System;
using TripMeOn.Models.Products;
using System.Linq;

namespace TripMeOn.ViewModels
{
    public class HomeViewModel
    {
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public Destination Destination { get; set; }
    }
}

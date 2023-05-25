using Newtonsoft.Json.Linq;
using System;
using TripMeOn.Models.PartnerProducts;
using TripMeOn.Models.Products;

namespace TripMeOn.ViewModels
{
    public class DeuximeVue
    {
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public Accomodation Accomodation{ get; set; }
    }
}



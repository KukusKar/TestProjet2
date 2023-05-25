using Microsoft.AspNetCore.Mvc;
using System;
using System.Xml.Linq;
using TripMeOn.Models.PartnerProducts;
using TripMeOn.Models.Products;
using TripMeOn.ViewModels;

namespace TripMeOn.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           return View();
        }

        public IActionResult ModifyDestination()
        {
            return View();
        }

        public IActionResult ModifyThemes()
        {
            return View();
        }

        public IActionResult Accomodation()
        {
            Accomodation accomodation = new Accomodation ("Super Hotel", "Tipi", 50);

            DeuximeVue hvm1 = new DeuximeVue
            {
                Message = "Encore bonjour ! Voici un hotel",
                Date = DateTime.Now,
                Accomodation = accomodation
            };

            return View(hvm1);
        }
    }
}

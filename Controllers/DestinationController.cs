using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using TripMeOn.Models;
using TripMeOn.Models.Products;

namespace TripMeOn.Controllers
{
    public class DestinationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ModifyDestination(int id)
        {
            if (id != 0)
            {
                using (IDal dal = new Dal())
                {
                    Destination destination = dal.GetDestinations().Where(r => r.Id == id).FirstOrDefault();
                    if (destination == null)
                    {
                        return View("Error");
                    }
                    return View(destination);
                }
            }
            return View("Error");
        }
        [HttpPost]
        //public IActionResult ModifyDestination(Destination destination)
        //{

        //    if (destination.Id != 0)
        //    {
        //        using (Dal dal = new Dal())
        //        {
        //            dal.ModifyDestination(destination);
        //            return RedirectToAction("ModifyDestination", new { @id = destination.Id });
        //        }
        //    }
        //    else
        //    {
        //        return View("Error");
        //    }
        //}
        [HttpPost]
        public IActionResult ModifyDestination(Destination destination)
        {
            if (!ModelState.IsValid)
                return View(destination);

            if (destination.Id != 0)
            {
                using (Dal dal = new Dal())
                {
                    dal.ModifyDestination(destination.Id, destination.Country, destination.Region, destination.City, destination.Description);
                    return RedirectToAction("ModifyDestination", new { @id = destination.Id });
                }
            }
            else
            {
                return View("Error");
            }
        }

    }
}

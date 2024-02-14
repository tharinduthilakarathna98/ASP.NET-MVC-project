using Microsoft.AspNetCore.Mvc;

using System.Diagnostics;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
     
     public IActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }

        public ViewResult RsvpForm()
        {
            return View();
        }



    }
}
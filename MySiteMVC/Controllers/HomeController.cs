using Microsoft.AspNetCore.Mvc;
using MySiteMVC.Models;
using System.Diagnostics;

namespace MySiteMVC.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            HomeModel home = new HomeModel();
            home.Nome = "Anderson Guimarães";
            home.Email = "anderson.sg2@gmail.com";

            return View(home);
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
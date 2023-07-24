using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult index(Person ps)
        {
            string message = ps.FullName + " - " + ps.ID + " - " + ps.Address + " - " + ps.Birthday;
            ViewBag.thongbao = message;
            return View();
        }
    }
}
using Microsoft.AspNetCore.Mvc;

namespace FirstWebMVC.Controllers 
{
    public class Student1Controller : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Index(int Number)
        {
            int binhphuong = Number * Number;
            ViewBag.Message = "binh phuong cua so " + Number + " la : " + binhphuong;
            return View();
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Formularz.Models;


namespace Formularz.Controllers
{
    public class DaneController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        
        public IActionResult Form(Dane dane)
        {
            if (ModelState.IsValid)
            {
                return Content("Rejestracja zakończona");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Wynik(Dane dane)
        {
            return View(dane);
        }
    }
}

using Laboratorium_2._00.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium_2._00.Controllers
{
    public class BirthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Result([FromForm] Birth model)
        {
            if (!model.IsValid())
            {
                return View("Error");
            }

            ViewBag.Message = $"Cześć {model.Name}, masz {model.CalculateAge()} lat(a).";
            return View("Result");
        }
    }
}

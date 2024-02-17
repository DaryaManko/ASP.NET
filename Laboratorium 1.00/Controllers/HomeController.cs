using Laboratorium_1._00.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Laboratorium_1._00.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public enum Operator
        {
            Unknown, Add, Mul, Sub, Div
        }
        public IActionResult About(Operator op)
        {
            ViewBag.Op = op;
            return View();
        }

        public IActionResult Calculator(double? a, double? b, Operator op)
        {
            ViewBag.A = a;
            ViewBag.B = b;
            ViewBag.Op = op;

            double result = 0;

            if (a.HasValue && b.HasValue)
            {
                switch (op)
                {
                    case Operator.Add:
                        result = a.Value + b.Value;
                        break;
                    case Operator.Sub:
                        result = a.Value - b.Value;
                        break;
                    case Operator.Mul:
                        result = a.Value * b.Value;
                        break;
                    case Operator.Div:
                        if (b.Value != 0)
                            result = a.Value / b.Value;
                        else
                            ViewBag.ErrorMessage = "Błąd: Nie można dzielić przez zero.";
                        break;
                    default:
                        ViewBag.ErrorMessage = "Błąd: Nieznany operator.";
                        break;
                }
            }
            else
            {
                ViewBag.ErrorMessage = "Błąd: Brak wartości dla jednego z operandów.";
            }

            ViewBag.Result = result;

            return View();
        }


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
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

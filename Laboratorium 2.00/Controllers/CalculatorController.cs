using Laboratorium_2._00.Models;
using Microsoft.AspNetCore.Mvc;


namespace Laboratorium_2._00.Controllers
{
    public enum Operator
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }

    public class CalculatorController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Result(Calculator model)
        {
            if (!model.IsValid())
            {
                return View("Error");
            }
            return View(model);
        }
        public IActionResult Form()
        {
            return View();
        }

    }

}

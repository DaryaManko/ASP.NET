using Laboratorium_3._00.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Laboratorium_3._00.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public IActionResult Index()
        {
            return View(_employeeService.FindAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            InitializeOrganizationsList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee model)
        {
            if (ModelState.IsValid)
            {
                _employeeService.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                InitializeOrganizationsList();
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Employee employee = _employeeService.FindById(id);
            if (employee == null)
            {
                return NotFound();
            }

            InitializeOrganizationsList();
            return View(employee);
        }

        [HttpPost]
        public IActionResult Edit(Employee model)
        {
            if (ModelState.IsValid)
            {
                _employeeService.Update(model);
                return RedirectToAction("Index");
            }
            else
            {
                InitializeOrganizationsList();
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            Employee employee = _employeeService.FindById(id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        public IActionResult Delete(int id)
        {
            _employeeService.Delete(id);
            return RedirectToAction("Index");
        }

        private void InitializeOrganizationsList()
        {
            var organizations = new List<SelectListItem>
            {
                new SelectListItem { Value = "1", Text = "A" },
                new SelectListItem { Value = "2", Text = "B" },
                new SelectListItem { Value = "3", Text = "C" }
            };

            ViewBag.Organizations = organizations;
        }
    }
}



using System;
using System.ComponentModel.DataAnnotations;
using Laboratorium_4._00.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Laboratorium_3._00.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        [Required(ErrorMessage = "Proszę podać imię!")]
        [Display(Name = "Imię")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Proszę podać nazwisko!")]
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }

        [Display(Name = "Stanowisko")]
        public string Position { get; set; }

        [Display(Name = "Dział")]
        public string Department { get; set; }

        [Display(Name = "Priorytet")]
        public Priority Priority { get; set; }

        public int OrganizationId { get; set; }

        public List<SelectListItem> Organizations { get; set; }

        public ICollection<EmployeeOrganization> EmployeeOrganizations { get; set; }
    }


    public enum Position
    {
        Manager,
        Developer,
        Designer,
        Tester
    }

}

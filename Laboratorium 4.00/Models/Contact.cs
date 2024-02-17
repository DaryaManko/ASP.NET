using System.ComponentModel.DataAnnotations;

namespace Laboratorium_4._00.Models
{

    public class Contact
    {
        [Required(ErrorMessage = "Proszę podać imię!")]
        [Display(Name = "Imię")]
        public string Name { get; set; }

        [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
        [Required(ErrorMessage = "Proszę podać poprawny e-mail!")]
        public string Email { get; set; }

        public string Subject { get; set; }

        [MinLength(length: 5, ErrorMessage = "Wiadomość musi mieć co najmniej 5 znaków!")]
        [Required(ErrorMessage = "Proszę wpisać wiadomość!")]
        public string Message { get; set; }

        [Display(Name = "Priorytet")]
        public Priority Priority { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}

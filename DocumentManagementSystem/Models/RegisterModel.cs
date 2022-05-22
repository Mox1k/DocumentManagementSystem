using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagementSystem.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Вы не заполнили это поле!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Вы не заполнили это поле!")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Вы не заполнили это поле!")]
        public string Patronymic { get; set; }

        [Required(ErrorMessage = "Вы не заполнили это поле!")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Вы не заполнили это поле!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Вы не заполнили это поле!")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}

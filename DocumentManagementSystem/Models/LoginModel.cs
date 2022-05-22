using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagementSystem.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Вы не заполнили это поле!")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Вы не заполнили это поле!")]
        public string Password { get; set; }
    }
}

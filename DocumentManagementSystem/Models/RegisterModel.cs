using DocumentManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagementSystem.Models
{
    public class RegisterModel : IDataErrorInfo
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
        public string this[string columnName]
        {
            get
            {
                string error = String.Empty;

                switch (columnName)
                {
                    case "Name":
                        if (Name == null || Name == String.Empty)
                        {
                            error = "Поле должно быть заполнено!";
                        }
                        break;
                    case "Surname":
                        if (Surname == null || Surname == String.Empty)
                        {
                            error = "Поле должно быть заполнено!";
                        }
                        break;
                    case "Patronymic":
                        if (Patronymic == null || Patronymic == String.Empty)
                        {
                            error = "Поле должно быть заполнено!";
                        }
                        break;
                    case "Login":
                        if (Login == null || Login == String.Empty)
                        {
                            error = "Поле должно быть заполнено!";
                        }
                        using (ApplicationDbContext _context = new ApplicationDbContext())
                        {
                            var login = _context.Users.Where (x => x.Login == Login).FirstOrDefault();
                            if (login != null)
                            {
                                error = "Логин уже занят";
                            }
                        }
                        break;
                    case "Password":
                        if (Password == null || Password == String.Empty)
                        {
                            error = "Поле должно быть заполнено!";
                        }
                        if (ConfirmPassword != Password)
                        {
                            error = "Пароли не совпадают!";
                        }
                        break;
                    case "ConfirmPassword":
                        if (ConfirmPassword == null || ConfirmPassword == String.Empty)
                        {
                            error = "Поле должно быть заполнено!";
                        }
                        if (ConfirmPassword != Password)
                        {
                            error = "Пароли не совпадают!";
                        }
                        break;
                }
                return error;
            }
        }
        public string Error
        {
            get { throw new NotImplementedException(); }
        }
    }
}

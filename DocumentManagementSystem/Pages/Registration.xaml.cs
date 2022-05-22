using DocumentManagementSystem.Data;
using DocumentManagementSystem.Domain.Entites;
using DocumentManagementSystem.Domain.Enums;
using DocumentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DocumentManagementSystem.Pages
{
    /// <summary>
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        RegisterModel model;

        private void Auth_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/Login.xaml", UriKind.Relative));
        }

        private void RegReg_Click(object sender, RoutedEventArgs e)
        {
            User user = new User()
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                Surname = model.Surname,
                Patronymic = model.Patronymic,
                Login = model.Login,
                Password = model.Password,
                Posts = Posts.Seller
            };

            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }
        public Registration()
        {
            model = new RegisterModel();
            this.DataContext = model;
        }
    }
}

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
using DocumentManagementSystem.Data;
using DocumentManagementSystem.Pages;



namespace DocumentManagementSystem.Pages
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/Registration.xaml", UriKind.Relative));
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            using (ApplicationDbContext _context = new ApplicationDbContext())
                if (Log.Text != String.Empty && Log.Text != null)
                {
                    if (Pass.Text != String.Empty && Pass.Text != null)
                    {
                        var user = _context.Users.Where(x => x.Login == Log.Text && x.Password == Pass.Text).FirstOrDefault();
                        if (user != null)
                        {
                            MainProgramm taskWindow = new MainProgramm();

                            var CloseWindow = Application.Current.Windows;

                            CloseWindow[0].Close();
                            
                            taskWindow.Show();
                        }
                    }
                }
        }
    }
}

using DocumentManagementSystem.Pages;
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
using System.Windows.Shapes;

namespace DocumentManagementSystem
{
    /// <summary>
    /// Interaction logic for MainProgramm.xaml
    /// </summary>
    public partial class MainProgramm : Window
    {
        public MainProgramm()
        {
            InitializeComponent();
            _MainMenuNavigationFrame.Navigate(new MainMenuPage());
        }
    }
}

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

namespace Client
{
    /// <summary>
    /// Interaction logic for CreateUser.xaml
    /// </summary>
    public partial class CreateUser : Page
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void MainMenuBtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new SystemOptions());
        }

        private void RetrieveUserBtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new RetrieveUser());
        }

        private void CreateNewUserButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Creating New User Profile");
        }

        private void UploadDP_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Adding New Profile Picture to User Profile");
        }
    }
}

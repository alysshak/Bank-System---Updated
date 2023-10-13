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
    /// Interaction logic for RetrieveUser.xaml
    /// </summary>
    public partial class RetrieveUser : Page
    {
        public RetrieveUser()
        {
            InitializeComponent();
        }


        private void RetrieveUserBtn_Click(object sender, RoutedEventArgs e)
        {
            string RetrievedUser = SearchBox.Text;
            MessageBox.Show($"Retriving Account Details for {RetrievedUser} Data");

        }

        private void UpdateUserDetailsBtn_Click(object sender, RoutedEventArgs e)
        {
            string fName = FirstNameBox.Text;
            string lname = LastNameBox.Text;
            MessageBox.Show($"Updating {FirstNameBox} {LastNameBox}'s User Data");
        }

        private void CreateUserBtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new CreateUser());
        }

        private void MainMenuBtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new SystemOptions());
        }
    }
}

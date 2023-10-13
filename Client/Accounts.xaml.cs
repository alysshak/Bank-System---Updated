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
    /// Interaction logic for Accounts.xaml
    /// </summary>
    public partial class Accounts : Page
    {
        public Accounts()
        {
            InitializeComponent();
        }

        private void UpdateAccountBtn_Click(object sender, RoutedEventArgs e)
        {
            // Need to add account ID
            string AccountHolderID = DisplayAccountIdBox.Text;
            string AccountHolderName = DisplayAccountHolderBox.Text;
            MessageBox.Show($"Updating Account {AccountHolderID} details for {AccountHolderName}");
        }

        private void DeleteAccBtn_Click(object sender, RoutedEventArgs e)
        {
            string AccountHolderID = DisplayAccountIdBox.Text;
            string AccountHolderName = DisplayAccountHolderBox.Text;
            MessageBox.Show($"Deleting Account {AccountHolderID} for {AccountHolderName}");
        }

        private void RetrieveAccDetailsBtn_Click(object sender, RoutedEventArgs e)
        {
            string RetriveID = AccountIdInput.Text;
            //Add user name as well in message box
            MessageBox.Show($"Retriving Account Details for {RetriveID}");
        }

        private void CreateNewAcc_Click(object sender, RoutedEventArgs e)
        {
            string UserID = UserIdInput.Text;
            //Add user's name
            MessageBox.Show($"Creating New Account for User {UserID}");
        }
    }
}

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
    /// Interaction logic for Transactions.xaml
    /// </summary>
    public partial class Transactions : Page
    {
        public Transactions()
        {
            InitializeComponent();
        }

        private void DepositButton_Click(object sender, RoutedEventArgs e)
        {
            string depositedAmount = TransactionAmountBox.Text;
            string AccountID = AccountNumberBox.Text;
            MessageBox.Show($"Depositing ${depositedAmount} into Account {AccountID}");

            //Update the balance text box
        }

        private void WithdrawButton_Click(object sender, RoutedEventArgs e)
        {
            string withdrawnAmount = TransactionAmountBox.Text;
            string AccountID = AccountNumberBox.Text;
            MessageBox.Show($"Withdrawing ${withdrawnAmount} from Account {AccountID}");

            //Update the balance text box
        }
    }
}

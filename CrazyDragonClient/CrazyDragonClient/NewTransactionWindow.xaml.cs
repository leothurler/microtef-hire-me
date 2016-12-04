using CrazyDragonClient.Controller;
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

namespace CrazyDragonClient
{
    /// <summary>
    /// Interaction logic for NewTransactionWindow.xaml
    /// </summary>
    public partial class NewTransactionWindow : Window
    {
        public NewTransactionWindow()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            UserHomeWindow window = new UserHomeWindow();
            App.Current.MainWindow = window;
            this.Close();
            window.Show();
        }

        private void btnMakeTransaction_Click(object sender, RoutedEventArgs e)
        {
            string amount = txtAmount.Text;
            string type = cbType.SelectedItem != null ? ((ComboBoxItem)cbType.SelectedItem).Content.ToString() : "";
            string number = txtNumber.Text;
            string cardNumber = txtCardNumber.Text;
            string cardPassword = txtCardPassword.Password;

            if ( string.IsNullOrEmpty(amount) || string.IsNullOrEmpty(type) || string.IsNullOrEmpty(number) ||
                 string.IsNullOrEmpty(cardNumber) || string.IsNullOrEmpty(cardPassword) )
                MessageBox.Show("Favor Preencha todos os campos.");
            else
            {
                string jsonDados = "{ \"amount\": \"" + amount + "\"," +
                                     "\"type\": \"" + type + "\"," +
                                     "\"number\": \"" + number + "\"," +
                                     "\"card\": { " +
                                                    "\"number\": \"" + cardNumber + "\"," +
                                                    "\"password\": \"" + cardPassword + "\"," +
                                     " }, " +
                                     "\"userLogin\": \"" + Application.Current.Resources["userLogged"] + "\" }";

                WebserviceRequisitionController requisition = new WebserviceRequisitionController();

                dynamic item = requisition.makeRequisition("http://localhost:60010/api/Transactions/makeTransaction", "POST", jsonDados);
                string message = item["Message"];
                string sucess = item["Sucess"];

                if ("true".Equals(sucess))
                {
                    MessageBox.Show(message);
                }
                else
                    MessageBox.Show(message);
            }
        }
    }
}

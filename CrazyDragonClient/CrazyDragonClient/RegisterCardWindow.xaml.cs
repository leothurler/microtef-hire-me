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
    /// Interaction logic for RegisterCardWindow.xaml
    /// </summary>
    public partial class RegisterCardWindow : Window
    {
        public RegisterCardWindow()
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

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            string cardName = txtName.Text;
            string cardBrand = cbBrand.SelectedItem != null ? ((ComboBoxItem)cbBrand.SelectedItem).Content.ToString() : "";
            string cardNumber = txtNumber.Text;
            string cardPassword = txtPassword.Password;
            string cardExpDate = txtExpDate.Text;
            string cardType = cbType.SelectedItem != null ? ((ComboBoxItem)cbType.SelectedItem).Content.ToString() : "";
            string cardBalance = txtBalance.Text;

            if ( string.IsNullOrEmpty(cardName) || string.IsNullOrEmpty(cardBrand) || string.IsNullOrEmpty(cardNumber) ||
                 string.IsNullOrEmpty(cardPassword) || string.IsNullOrEmpty(cardExpDate) || string.IsNullOrEmpty(cardType) ||
                 string.IsNullOrEmpty(cardBalance) )
                MessageBox.Show("Favor Preencha todos os campos.");
            else
            {
                string jsonDados = "{ \"userLogin\": \"" + Application.Current.Resources["userLogged"] + "\"," +
                                     "\"cardholderName\": \"" + cardName + "\"," +
                                     "\"number\": \"" + cardNumber + "\"," +
                                     "\"expirationDate\": \"" + cardExpDate + "\"," +
                                     "\"cardBrand\": \"" + cardBrand + "\"," +
                                     "\"password\": \"" + cardPassword + "\"," +
                                     "\"type\": \"" + cardType + "\"," +
                                     "\"balance\": \"" + cardBalance + "\"" +
                                    " } ";

                WebserviceRequisitionController requisition = new WebserviceRequisitionController();

                dynamic item = requisition.makeRequisition("http://localhost:60010/api/Card/registerCard", "POST", jsonDados);
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

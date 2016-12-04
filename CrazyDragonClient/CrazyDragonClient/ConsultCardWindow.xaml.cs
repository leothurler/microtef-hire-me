using CrazyDragonClient.Controller;
using CrazyDragonClient.Model;
using System.Linq;
using System.Windows;

namespace CrazyDragonClient
{
    public partial class ConsultCardWindow : Window
    {
        public ConsultCardWindow()
        {
            InitializeComponent();
            loadTransactions();
        }

        private void loadTransactions()
        {
            WebserviceRequisitionController requisition = new WebserviceRequisitionController();

            dynamic item = requisition.makeRequisition("http://localhost:60010/api/Card/getUserCards?userLogin=" + Application.Current.Resources["userLogged"], "GET", null);
            string sucess = item["Sucess"];

            if ("true".Equals(sucess))
            {
                dynamic data = item["Data"];

                for( int i = 0; i < Enumerable.Count(data); i++ )
                {
                    lvCardData.Items.Add(new lvCardItem { cardName = data[i]["cardholderName"],
                                                          cardNumber = data[i]["number"],
                                                          cardExpDate = data[i]["expirationDate"],
                                                          cardBrand = data[i]["cardBrand"],
                                                          cardBalance = data[i]["balance"],
                                                          cardType = data[i]["type"]
                    });
                }
               
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            UserHomeWindow window = new UserHomeWindow();
            App.Current.MainWindow = window;
            this.Close();
            window.Show();
        }
    }
}

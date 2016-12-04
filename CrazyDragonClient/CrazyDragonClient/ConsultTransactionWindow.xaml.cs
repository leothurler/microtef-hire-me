using CrazyDragonClient.Controller;
using CrazyDragonClient.Model;
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
    public partial class ConsultTransactionWindow : Window
    {
        public ConsultTransactionWindow()
        {
            InitializeComponent();
            loadTransactions();
        }

        private void loadTransactions()
        {
            WebserviceRequisitionController requisition = new WebserviceRequisitionController();

            dynamic item = requisition.makeRequisition("http://localhost:60010/api/Transactions/getUserTransactions?userLogin=" + Application.Current.Resources["userLogged"], "GET", null);
            string sucess = item["Sucess"];

            if ("true".Equals(sucess))
            {
                dynamic data = item["Data"];

                for( int i = 0; i < Enumerable.Count(data); i++ )
                {
                    lvTransactionsData.Items.Add(new lvTransactionItem { amount = data[i]["amount"],
                                                              type = data[i]["type"],
                                                              number = data[i]["number"],
                                                              cardName = data[i]["card"]["cardholderName"],
                                                              cardNumber = data[i]["card"]["number"],
                                                              cardExpDate = data[i]["card"]["expirationDate"],
                                                              cardBrand = data[i]["card"]["cardBrand"]
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

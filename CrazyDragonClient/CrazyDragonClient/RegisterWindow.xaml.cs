using CrazyDragonClient.Controller;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
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
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            string login = txtLogin.Text;
            string password = txtPassword.Password;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
                MessageBox.Show("Favor Preencha todos os campos.");
            else
            {
                string jsonDados = "{ \"login\": \"" + login + "\"," +
                                     "\"name\": \"" + name + "\"," +
                                     "\"password\": \"" + password + "\"";

                WebserviceRequisitionController requisition = new WebserviceRequisitionController();

                dynamic item = requisition.makeRequisition("http://localhost:60010/api/User/registerUser", "POST", jsonDados);
                string message = item["Message"];

                MessageBox.Show(message);
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            App.Current.MainWindow = mainWindow;
            this.Close();
            mainWindow.Show();
        }
    }
}

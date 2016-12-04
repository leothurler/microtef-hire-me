using CrazyDragonClient.Controller;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CrazyDragonClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Password;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
                MessageBox.Show("Favor Preencha todos os campos.");
            else
            {
                string jsonDados = "{ \"login\": \"" + login + "\"," +
                                     "\"password\": \"" + password + "\"";

                WebserviceRequisitionController requisition = new WebserviceRequisitionController();

                dynamic item = requisition.makeRequisition("http://localhost:60010/api/User/loginUser", "POST", jsonDados);
                string message = item["Message"];
                string sucess = item["Sucess"];

                if( "true".Equals(sucess))
                {
                    Application.Current.Resources["userLogged"] = login;

                    UserHomeWindow window = new UserHomeWindow();
                    App.Current.MainWindow = window;
                    this.Close();
                    window.Show();
                }
                else
                    MessageBox.Show(message);
            }
        }

        private void newUser_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow();
            App.Current.MainWindow = registerWindow;
            this.Close();
            registerWindow.Show();
        }
    }
}

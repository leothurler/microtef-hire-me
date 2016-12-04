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
    /// Interaction logic for UserHomeWindow.xaml
    /// </summary>
    public partial class UserHomeWindow : Window
    {
        public UserHomeWindow()
        {
            InitializeComponent();
        }

        private void btnConsultTransaction_Click(object sender, RoutedEventArgs e)
        {
            ConsultTransactionWindow window = new ConsultTransactionWindow();
            App.Current.MainWindow = window;
            this.Close();
            window.Show();
        }

        private void btnNewTransaction_Click(object sender, RoutedEventArgs e)
        {
            NewTransactionWindow window = new NewTransactionWindow();
            App.Current.MainWindow = window;
            this.Close();
            window.Show();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources["userLogged"] = "";
            MainWindow window = new MainWindow();
            App.Current.MainWindow = window;
            this.Close();
            window.Show();
        }

        private void btnRegisterCards_Click(object sender, RoutedEventArgs e)
        {
            RegisterCardWindow window = new RegisterCardWindow();
            App.Current.MainWindow = window;
            this.Close();
            window.Show();
        }

        private void btnConsultCards_Click(object sender, RoutedEventArgs e)
        {
            ConsultCardWindow window = new ConsultCardWindow();
            App.Current.MainWindow = window;
            this.Close();
            window.Show();
        }
    }
}

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
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;


namespace MyAssignment.com
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
        MySqlConnection connection = new MySqlConnection("server=localhost; user=root; database=logintsena; port=3306; password='';");

        private void Button_Click(object sender, RoutedEventArgs e) //login
        {
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `username`, `password` FROM `subscribers` WHERE `username` = '" + usernametxt.Text + "' AND `password` = '" + passwordtxt.Text + "'", connection);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                NavigationWindow window = new NavigationWindow();
                window.Source = new Uri("Home.xaml", UriKind.Relative);
                window.Show();
                this.Close();
            }
            else
            {

            }
            connection.Close();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)//signup
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)//username
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)// password
        {

        }
    }
}

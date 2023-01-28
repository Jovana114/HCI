using HCI.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace HCI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxUsername.Text.Length == 0)
            {
                errormessage.Text = "Enter an email.";
                TextBoxUsername.Focus();
            }
            else if (!Regex.IsMatch(TextBoxUsername.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                errormessage.Text = "Enter a valid email.";
                TextBoxUsername.Select(0, TextBoxUsername.Text.Length);
                TextBoxUsername.Focus();
            }
            else if (TextBoxPassword.Password.Length == 0)
            {
                errormessage.Text = "Enter password.";
                TextBoxPassword.Focus();
            }
            else
            {
                string email = TextBoxUsername.Text;
                string password = TextBoxPassword.Password;
                Home1 home = new Home1();
                home.Show();
                this.Close();
            }
        }

    }
}

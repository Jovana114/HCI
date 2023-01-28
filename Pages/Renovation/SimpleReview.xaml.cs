using HCI.Model;
using HCI.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace HCI.Pages.Renovation
{

    public partial class SimpleReview : Window
    {

        RenovationService renovationService = new RenovationService();
        private ObservableCollection<RenovationSimple> renovationsSimple = new ObservableCollection<RenovationSimple>();

        public SimpleReview()
        {
            InitializeComponent();
            renovationsSimple = renovationService.GetAllRenovationSimple();
            dgUsers.ItemsSource = renovationsSimple;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (dgUsers.SelectedItem == null)
                MessageBox.Show("Item is not selected", "Greska");
            else
            {
                if (renovationService.DeleteRenovationSimple((RenovationSimple)dgUsers.SelectedItem))
                {
                    renovationsSimple.Remove((RenovationSimple)dgUsers.SelectedItem);
                }
            }
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

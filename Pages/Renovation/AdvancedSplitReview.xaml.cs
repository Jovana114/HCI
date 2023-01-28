using HCI.Model;
using HCI.Pages.RearrangeEquipmrnt;
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

    public partial class AdvancedSplitReview : Window
    {

        RenovationAdvancedSplitService renovationService = new RenovationAdvancedSplitService();
        private ObservableCollection<RenovationAdvanced> renovationsAdvanced = new ObservableCollection<RenovationAdvanced>();

        public AdvancedSplitReview()
        {
            InitializeComponent();
            renovationsAdvanced = renovationService.GetAllRenovationSimple();
            dgUsers.ItemsSource = renovationsAdvanced;
            dgUsers1.ItemsSource = renovationService.GetAllRenovationSimpleRooms();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (dgUsers.SelectedItem == null)
                MessageBox.Show("Item is not selected", "Error");
            else
            {
                if (renovationService.DeleteRenovationAdvanced((RenovationAdvanced)dgUsers.SelectedItem))
                {
                    renovationsAdvanced.Remove((RenovationAdvanced)dgUsers.SelectedItem);
                }
            }
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (dgUsers.SelectedItem == null)
                MessageBox.Show("Item is not selected", "Error");
            else
            {
                if (dgUsers1.Visibility == Visibility.Visible)
                    dgUsers1.Visibility = Visibility.Hidden;
                else
                    dgUsers1.Visibility = Visibility.Visible;
            }

        }
    }
}

using HCI.ViewModel;
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

namespace HCI.Pages.Rooms
{
    public partial class RoomsWithEquipment : Window
    {

        StaticEquipmentViewModel sevm = new StaticEquipmentViewModel();
        DinamicEquipmentViewModel devm = new DinamicEquipmentViewModel();

        public RoomsWithEquipment()
        {
            InitializeComponent();

            dgUsers.ItemsSource = sevm.getAll();
            dgUsers1.ItemsSource = devm.getAll();
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OpenStaticEquipment(object sender, RoutedEventArgs e)
        {
            if (dgUsers.Visibility == Visibility.Visible)
                dgUsers.Visibility = Visibility.Hidden;
            else
                dgUsers.Visibility = Visibility.Visible;
        }

        private void OpenDinamicEquipment(object sender, RoutedEventArgs e)
        {
            if (dgUsers1.Visibility == Visibility.Visible)
                dgUsers1.Visibility = Visibility.Hidden;
            else
                dgUsers1.Visibility = Visibility.Visible;
        }
    }
}

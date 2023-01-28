using HCI.Model;
using HCI.ViewModel;
using HCI.Views;
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

namespace HCI.Pages.RearrangeEquipmrnt
{

    public partial class SpecifyNewRooms : Window
    {
        private ObservableCollection<Room> rooms = new ObservableCollection<Room>();

        public SpecifyNewRooms(ObservableCollection<Room> rooms)
        {
            InitializeComponent();
            rooms = rooms;

            dgEquipment.ItemsSource = rooms;
        }

        private void potvrdi(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void odustani(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void add(object sender, RoutedEventArgs e)
        {
            Room room = new Room(0, "", "", false, 0);

            rooms.Add(room);

        }

        private void dg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}


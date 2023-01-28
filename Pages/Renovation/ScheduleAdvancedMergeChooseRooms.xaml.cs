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

    public partial class ScheduleAdvancedMergeChooseRooms : Window
    {
        private RoomViewModel revm = new RoomViewModel();
        private ObservableCollection<Room> allRooms = new ObservableCollection<Room>();
        private ObservableCollection<Room> choosedRooms = new ObservableCollection<Room>();
        RenovationAdvanced renovationAdvanced;
        private ObservableCollection<Room> choosedRoom;

        public ScheduleAdvancedMergeChooseRooms(ObservableCollection<Room> se)
        {
            InitializeComponent();
            choosedRooms = se;

            allRooms = revm.getAll();

            if (choosedRooms != null)
            {
                foreach (Room se1 in allRooms.ToArray<Room>())
                {
                    foreach (Room choosedSE in choosedRooms)
                    {
                        if (choosedSE.Id == se1.Id)
                        {
                            allRooms.Remove(se1);
                        }
                    }
                }

            }

            dgEquipment.ItemsSource = allRooms;
            dgChoosedEquipment.ItemsSource = choosedRooms;
        }
        private void dgChoosed_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            foreach (Room selectedEquipment in dgEquipment.SelectedItems.Cast<Room>().ToList())
            {
                choosedRooms.Add(selectedEquipment);
                allRooms.Remove(selectedEquipment);
            }

        }

        private void potvrdi(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void odustani(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            foreach (Room choosedSE in dgChoosedEquipment.SelectedItems.Cast<Room>().ToList())
            {
                choosedRooms.Remove(choosedSE);
                allRooms.Add(choosedSE);
            }
        }
    }
}


using HCI.Model;
using HCI.Pages.RearrangeEquipmrnt;
using HCI.Repository;
using HCI.ViewModel;
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

    public partial class ScheduleAdvancedMerge : Window
    {
        ObservableCollection<Room> roomList = new ObservableCollection<Room>();

        DatePicker izborDatuma;
        ComboBox comboBoxSati;

        RenovationAdvanced renovation;

        RenovationAdvancedMergeRepository renovationRepository = RenovationAdvancedMergeRepository.Instance;

        public ScheduleAdvancedMerge()
        {
            InitializeComponent();

            comboBoxSati = sati;
            izborDatuma = timePicker;

            kalendarInicijalizacija();
        }

        private void Submit(object sender, RoutedEventArgs e)
        {

            Room room = new Room(0, nameRoom.Text, typeRoom.Text, false, 0);

            RenovationAdvanced renovation = new RenovationAdvanced(
                int.Parse(id.Text),
                room,
                roomList.ToList<Room>(),
                type1.Text,
                (DateTime)timePicker.SelectedDate,
                sati.SelectedValue.ToString(),
                int.Parse(durationText.Text));

            RenovationAdvancedMergeRepository.Instance.renovation.Add(renovation);
            renovationRepository.Save();
            this.Close();


            string messageBoxText = "Renovation submited!";
            string caption = "Success";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxResult result;

            result = MessageBox.Show(messageBoxText, caption, button);
        }

        public void kalendarInicijalizacija()
        {
            DateTime danas = DateTime.Today;

            for (DateTime tm = danas.AddHours(8); tm < danas.AddHours(22); tm = tm.AddMinutes(30))
            {
                comboBoxSati.Items.Add(tm.ToShortTimeString());

            }

            CalendarDateRange kalendar = new CalendarDateRange(DateTime.MinValue, DateTime.Today.AddDays(-1));
            izborDatuma.BlackoutDates.Add(kalendar);
        }

        private void date_changed(object sender, SelectionChangedEventArgs e)
        {

        }

        private void sati_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Select(object sender, RoutedEventArgs e)
        {
            ScheduleAdvancedMergeChooseRooms samcr = new ScheduleAdvancedMergeChooseRooms(roomList);
            samcr.Show();
            selected.Text = "Selected";
        }
    }

}


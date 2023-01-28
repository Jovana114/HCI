using HCI.Model;
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

    public partial class ScheduleSimple : Window
    {

        private ObservableCollection<Room> rooms = new ObservableCollection<Room>();
        private RoomViewModel rvm = new RoomViewModel();
        RenovationSimple renovation;

        RenovationRepository renovationRepository = RenovationRepository.Instance;

        DatePicker izborDatuma;
        ComboBox comboBoxSati;

        public ScheduleSimple()
        {
            InitializeComponent();

            rooms = rvm.getAll();
            foreach (Room room in rooms)
            {
                cbProstorija1.Items.Add(room.Name);
            }

            comboBoxSati = sati;
            izborDatuma = timePicker;

            kalendarInicijalizacija();
        }

        private void Submit(object sender, RoutedEventArgs e)
        {

            Room firstRoom = new Room();
            firstRoom = rvm.getRoomByName(cbProstorija1.SelectedItem.ToString());

            Room secondRoom = new Room();
            secondRoom = rvm.getRoomByName(cbProstorija1.SelectedItem.ToString());

            RenovationSimple renovationSimple1 = new RenovationSimple(
                int.Parse(id.Text),
                firstRoom,
                type.Text,
                (DateTime)timePicker.SelectedDate,
                sati.SelectedValue.ToString(),
                int.Parse(durationText.Text));

            RenovationRepository.Instance.renovation.Add(renovationSimple1);
            renovationRepository.Save();
            this.Close();


            string messageBoxText = "Simple renovation submited!";
            string caption = "Success";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxResult result;

            result = MessageBox.Show(messageBoxText, caption, button);
        }

        private void cbProstorija_SelectionChanged1(object sender, SelectionChangedEventArgs e)
        {

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

    }

}


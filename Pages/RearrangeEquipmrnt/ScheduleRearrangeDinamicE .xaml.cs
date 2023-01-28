using HCI.Model;
using HCI.Repository;
using HCI.Service;
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

namespace HCI.Pages.RearrangeEquipmrnt
{
    public partial class ScheduleRearrangeDinamicE : Window
    {

        private ObservableCollection<Room> rooms = new ObservableCollection<Room>();
        private ObservableCollection<DinamicEquipment> choosedDinamicEquipment = new ObservableCollection<DinamicEquipment>();
        private List<int> setAmounts = new List<int>();
        private RoomViewModel rvm = new RoomViewModel();
        RearrangeEquipmentDinamic rearrangeDinamicEquipment;
        DatePicker izborDatuma;
        ComboBox comboBoxSati;
        RearrangeDinamicEquipmentService rearrangeDinamicEquipmentService = new RearrangeDinamicEquipmentService();
        RearrangeDinamicEquipmentRepository rearrangeDinamicEquipmentRepository = RearrangeDinamicEquipmentRepository.Instance;

        public ScheduleRearrangeDinamicE()
        {
            InitializeComponent();

            rooms = rvm.getAll();
            foreach(Room room in rooms)
            {
                cbProstorija.Items.Add(room.Name);
                cbProstorija1.Items.Add(room.Name);
            }

            

            comboBoxSati = sati;
            izborDatuma = timePicker;

            kalendarInicijalizacija();

        }

        private void Submit(object sender, RoutedEventArgs e)
        {

            Room firstRoom = new Room();
            firstRoom = rvm.getRoomByName(cbProstorija.SelectedItem.ToString());

            Room secondRoom = new Room();
            secondRoom = rvm.getRoomByName(cbProstorija1.SelectedItem.ToString());

            RearrangeEquipmentDinamic rearrangeDinamicEquipment1 = new RearrangeEquipmentDinamic(
                int.Parse(id.Text),
                firstRoom,
                choosedDinamicEquipment.ToList<DinamicEquipment>(),
                secondRoom,
                setAmounts,
                (DateTime)timePicker.SelectedDate,
                sati.SelectedValue.ToString(),
                int.Parse(durationText.Text));

                RearrangeDinamicEquipmentRepository.Instance.rearrangeEquipment.Add(rearrangeDinamicEquipment1);
                rearrangeDinamicEquipmentRepository.Save();
                this.Close();
            

            string messageBoxText = "Static equipment rearregment submited!";
            string caption = "Success";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxResult result;

            result = MessageBox.Show(messageBoxText, caption, button);
        }

        private void Select(object sender, RoutedEventArgs e)
        {
            AddDinamicEquipment ae = new AddDinamicEquipment(choosedDinamicEquipment);
            saved.Text = "Saved.";
            ae.Show();
        }

        private void cbProstorija_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

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

        private void Set(object sender, RoutedEventArgs e)
        {
            SetDinamicAmounts ssa = new SetDinamicAmounts(choosedDinamicEquipment, setAmounts);
            set.Text = "Set.";
            ssa.Show();
        }
    }
}

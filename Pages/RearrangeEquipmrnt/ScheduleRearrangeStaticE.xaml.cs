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
    public partial class ScheduleRearrangeStaticE : Window
    {

        private ObservableCollection<Room> rooms = new ObservableCollection<Room>();
        private ObservableCollection<StaticEquipment> choosedStaticEquipment = new ObservableCollection<StaticEquipment>();
        private List<int> setAmounts = new List<int>();
        private RoomViewModel rvm = new RoomViewModel();
        RearrangeEquipmentStatic rearrangeStaticEquipment;
        DatePicker izborDatuma;
        ComboBox comboBoxSati;
        RearrangeStaticEquipmentService rearrangeStaticEquipmentService = new RearrangeStaticEquipmentService();
        RearrangeStaticEquipmentRepository rearrangeStaticEquipmentRepository = RearrangeStaticEquipmentRepository.Instance;

        public ScheduleRearrangeStaticE()
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

            RearrangeEquipmentStatic rearrangeStaticEquipment1 = new RearrangeEquipmentStatic(
                int.Parse(id.Text),
                firstRoom,
                choosedStaticEquipment.ToList<StaticEquipment>(),
                secondRoom,
                setAmounts,
                (DateTime)timePicker.SelectedDate,
                sati.SelectedValue.ToString(),
                int.Parse(durationText.Text));

                RearrangeStaticEquipmentRepository.Instance.rearrangeEquipment.Add(rearrangeStaticEquipment1);
                rearrangeStaticEquipmentRepository.Save();
                this.Close();
            

            string messageBoxText = "Static equipment rearregment submited!";
            string caption = "Success";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxResult result;

            result = MessageBox.Show(messageBoxText, caption, button);
        }

        private void Select(object sender, RoutedEventArgs e)
        {
            AddStaticEquipment ae = new AddStaticEquipment(choosedStaticEquipment);
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
            SetStaticAmounts ssa = new SetStaticAmounts(choosedStaticEquipment, setAmounts);
            set.Text = "Set.";
            ssa.Show();
        }
    }
}

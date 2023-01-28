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

    public partial class AddStaticEquipment : Window
    {
        private StaticEquipmentViewModel sevm = new StaticEquipmentViewModel();
        private ObservableCollection<StaticEquipment> allStaticEquipment = new ObservableCollection<StaticEquipment>();
        private ObservableCollection<StaticEquipment> choosedSEquipment = new ObservableCollection<StaticEquipment>();
        RearrangeEquipmentStatic rearrangeStaticEquipment;
        private ObservableCollection<StaticEquipment> choosedStaticEquipment;
        private RearrangeEquipmentStatic rearrangeStaticEquipment1;

        public AddStaticEquipment(ObservableCollection<StaticEquipment> se)
        {
            InitializeComponent();
            choosedSEquipment = se;

            allStaticEquipment = sevm.getAll();

            if (choosedSEquipment != null)
            {
                foreach (StaticEquipment se1 in allStaticEquipment.ToArray<StaticEquipment>())
                {
                    foreach (StaticEquipment choosedSE in choosedSEquipment)
                    {
                        if (choosedSE.Id == se1.Id)
                        {
                            allStaticEquipment.Remove(se1);
                        }
                    }
                }

            }

            dgEquipment.ItemsSource = allStaticEquipment;
            dgChoosedEquipment.ItemsSource = choosedSEquipment;
        }
        private void dgChoosed_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            foreach (StaticEquipment selectedEquipment in dgEquipment.SelectedItems.Cast<StaticEquipment>().ToList())
            {
                choosedSEquipment.Add(selectedEquipment);
                allStaticEquipment.Remove(selectedEquipment);
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
            foreach (StaticEquipment choosedSE in dgChoosedEquipment.SelectedItems.Cast<StaticEquipment>().ToList())
            {
                choosedSEquipment.Remove(choosedSE);
                allStaticEquipment.Add(choosedSE);
            }
        }
    }
}


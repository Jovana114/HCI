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

    public partial class AddDinamicEquipment : Window
    {
        private DinamicEquipmentViewModel sevm = new DinamicEquipmentViewModel();
        private ObservableCollection<DinamicEquipment> allDinamicEquipment = new ObservableCollection<DinamicEquipment>();
        private ObservableCollection<DinamicEquipment> choosedDEquipment = new ObservableCollection<DinamicEquipment>();
        RearrangeEquipmentDinamic rearrangeDinamicEquipment;
        private ObservableCollection<DinamicEquipment> choosedDinamicEquipment;
        private RearrangeEquipmentDinamic rearrangeDinamicEquipment1;

        public AddDinamicEquipment(ObservableCollection<DinamicEquipment> se)
        {
            InitializeComponent();
            choosedDEquipment = se;

            allDinamicEquipment = sevm.getAll();

            if (choosedDEquipment != null)
            {
                foreach (DinamicEquipment se1 in allDinamicEquipment.ToArray<DinamicEquipment>())
                {
                    foreach (DinamicEquipment choosedSE in choosedDEquipment)
                    {
                        if (choosedSE.Id == se1.Id)
                        {
                            allDinamicEquipment.Remove(se1);
                        }
                    }
                }

            }

            dgEquipment.ItemsSource = allDinamicEquipment;
            dgChoosedEquipment.ItemsSource = choosedDEquipment;
        }
        private void dgChoosed_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            foreach (DinamicEquipment selectedEquipment in dgEquipment.SelectedItems.Cast<DinamicEquipment>().ToList())
            {
                choosedDEquipment.Add(selectedEquipment);
                allDinamicEquipment.Remove(selectedEquipment);
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
            foreach (DinamicEquipment choosedSE in dgChoosedEquipment.SelectedItems.Cast<DinamicEquipment>().ToList())
            {
                choosedDEquipment.Remove(choosedSE);
                allDinamicEquipment.Add(choosedSE);
            }
        }
    }
}


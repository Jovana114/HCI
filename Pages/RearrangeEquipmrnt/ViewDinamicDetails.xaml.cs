using HCI.Model;
using HCI.Service;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace HCI.Pages.RearrangeEquipmrnt
{
    public partial class ViewDinamicDetails : Window
    {
        RearrangeDinamicEquipmentService rearrangeEquipmentService = new RearrangeDinamicEquipmentService();
        RearrangeEquipmentDinamic rearrangeEquipment;
        private ObservableCollection<DinamicEquipment>  dinamicEquipments = new ObservableCollection<DinamicEquipment>();
        private List<int>  amount = new List<int>();
        

        public ViewDinamicDetails(RearrangeEquipmentDinamic rearrangeEquipment1)
        {
            InitializeComponent();
            this.rearrangeEquipment = rearrangeEquipment1;

            foreach (RearrangeEquipmentDinamic re in rearrangeEquipmentService.GetAllRearrangeEquipment())
            {
                if (re.id == rearrangeEquipment1.id)
                {
                    amount = re.amount;
                    foreach (DinamicEquipment dinamicEquipment in re.dinamicEquipment)
                    {
                        dinamicEquipments.Add(dinamicEquipment);
                    }
                }
            }

            dgUsers1.ItemsSource = dinamicEquipments;
            dgUsers2.ItemsSource = amount;
        }

        private void Button_Click_222(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

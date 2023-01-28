using HCI.Model;
using HCI.Service;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace HCI.Pages.RearrangeEquipmrnt
{
    public partial class ViewDinamic : Window
    {
        private ObservableCollection<RearrangeEquipmentDinamic> rearrangeEquipments = new ObservableCollection<RearrangeEquipmentDinamic>();
        RearrangeDinamicEquipmentService rearrangeEquipmentService = new RearrangeDinamicEquipmentService();
        RearrangeEquipmentDinamic rearrangeEquipment11 = new RearrangeEquipmentDinamic();
        ObservableCollection<DinamicEquipment> dinamicEquipment = new ObservableCollection<DinamicEquipment>();

        public ViewDinamic()
        {
            InitializeComponent();
            rearrangeEquipments = rearrangeEquipmentService.GetAllRearrangeEquipment();
            dgUsers.ItemsSource = rearrangeEquipments;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (dgUsers.SelectedItem == null)
                MessageBox.Show("Item is not selected", "Greska");
            else
            {
                if (rearrangeEquipmentService.DeleteRearrangeEquipment((RearrangeEquipmentDinamic)dgUsers.SelectedItem))
                {
                    rearrangeEquipments.Remove((RearrangeEquipmentDinamic)dgUsers.SelectedItem);
                }
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (dgUsers.SelectedItem == null)
                MessageBox.Show("Item is not selected", "Greska");
            else
            {
                ViewDinamicDetails vsd = new ViewDinamicDetails((RearrangeEquipmentDinamic)dgUsers.SelectedItem);
                vsd.Show();
            }
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

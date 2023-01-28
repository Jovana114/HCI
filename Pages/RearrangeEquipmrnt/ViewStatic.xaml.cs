using HCI.Model;
using HCI.Service;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace HCI.Pages.RearrangeEquipmrnt
{
    public partial class ViewStatic : Window
    {
        private ObservableCollection<RearrangeEquipmentStatic> rearrangeEquipments = new ObservableCollection<RearrangeEquipmentStatic>();
        RearrangeStaticEquipmentService rearrangeEquipmentService = new RearrangeStaticEquipmentService();
        RearrangeEquipmentStatic rearrangeEquipment11 = new RearrangeEquipmentStatic();
        ObservableCollection<StaticEquipment> staticEquipment = new ObservableCollection<StaticEquipment>();

        public ViewStatic()
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
                if (rearrangeEquipmentService.DeleteRearrangeEquipment((RearrangeEquipmentStatic)dgUsers.SelectedItem))
                {
                    rearrangeEquipments.Remove((RearrangeEquipmentStatic)dgUsers.SelectedItem);
                }
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (dgUsers.SelectedItem == null)
                MessageBox.Show("Item is not selected", "Greska");
            else
            {
                ViewlStaticDetails vsd = new ViewlStaticDetails((RearrangeEquipmentStatic)dgUsers.SelectedItem);
                vsd.Show();
            }
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

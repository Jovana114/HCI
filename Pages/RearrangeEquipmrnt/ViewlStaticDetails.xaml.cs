using HCI.Model;
using HCI.Service;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace HCI.Pages.RearrangeEquipmrnt
{
    public partial class ViewlStaticDetails : Window
    {
        RearrangeStaticEquipmentService rearrangeEquipmentService = new RearrangeStaticEquipmentService();
        RearrangeEquipmentStatic rearrangeEquipment;
        private ObservableCollection<StaticEquipment>  staticEquipments = new ObservableCollection<StaticEquipment>();
        private List<int>  amount = new List<int>();
        

        public ViewlStaticDetails(RearrangeEquipmentStatic rearrangeEquipment1)
        {
            InitializeComponent();
            this.rearrangeEquipment = rearrangeEquipment1;

            foreach (RearrangeEquipmentStatic re in rearrangeEquipmentService.GetAllRearrangeEquipment())
            {
                if (re.id == rearrangeEquipment1.id)
                {
                    amount = re.amount;
                    foreach (StaticEquipment staticEquipment in re.staticEquipment)
                    {
                        staticEquipments.Add(staticEquipment);
                    }
                }
            }

            dgUsers1.ItemsSource = staticEquipments;
            dgUsers2.ItemsSource = amount;
        }

        private void Button_Click_222(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

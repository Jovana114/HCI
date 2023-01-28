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

    public partial class SetStaticAmounts : Window
    {
        private List<int> setAmounts = new List<int>();
        private RearrangeEquipmentStatic rearrangeStaticEquipment;
        private ObservableCollection<StaticEquipment> choosedSEquipment;
        private int amount;

        public SetStaticAmounts(ObservableCollection<StaticEquipment> choosedStaticEquipment, List<int> se)
        {
            InitializeComponent();
            this.setAmounts = se;
            choosedSEquipment = choosedStaticEquipment;

            cse.ItemsSource = choosedSEquipment;
        }

        private void potvrdi(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void odustani(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SetAmount(object sender, RoutedEventArgs e)
        {
            if (cse.SelectedItem == null)
                MessageBox.Show("Item is not selected", "Greska");
            else
            {
                SetSetAmount ssa = new SetSetAmount(setAmounts, amount);
                ssa.Show();
            }
        }
    }
}


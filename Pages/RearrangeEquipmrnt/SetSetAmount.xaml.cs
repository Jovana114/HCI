using HCI.Model;
using HCI.Service;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace HCI.Pages.RearrangeEquipmrnt
{
    public partial class SetSetAmount : Window
    {
        private int amount = new int();
        private List<int> setAmounts;

        public SetSetAmount(List<int> se1, int amount1)
        {
            InitializeComponent();
            this.setAmounts = se1;
            this.amount = amount1;
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            amount = int.Parse(amonutText.Text);
            setAmounts.Add(amount);
            this.Close();
        }
    }
}

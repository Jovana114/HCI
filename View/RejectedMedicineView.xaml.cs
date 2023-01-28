using HCI.ViewModel;
using System;
using System.Collections.Generic;
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

namespace HCI.Views
{
    public partial class RejectedMedicineView : UserControl
    {
        public RejectedMedicineView()
        {
            InitializeComponent();
            this.DataContext = new HCI.ViewModel.RejectedMedicineViewModel();
        }

        private void UpdateMedicine(object sender, RoutedEventArgs e)
        {
            if (addRoomSp1.Visibility == Visibility.Visible)
                addRoomSp1.Visibility = Visibility.Hidden;
            else
                addRoomSp1.Visibility = Visibility.Visible;
        }

        private void UpdateMedicine1(object sender, RoutedEventArgs e)
        {
            if (a.Visibility == Visibility.Visible)
                a.Visibility = Visibility.Hidden;
            else
                a.Visibility = Visibility.Visible;
        }

        private void Submit(object sender, RoutedEventArgs e)
        {
            string messageBoxText = "Sent!";
            string caption = "Success";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxResult result;

            result = MessageBox.Show(messageBoxText, caption, button);
        }
    }
}

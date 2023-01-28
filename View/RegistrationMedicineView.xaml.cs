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
    public partial class RegistrationMedicineView : UserControl
    {
        public RegistrationMedicineView()
        {
            InitializeComponent();
            this.DataContext = new HCI.ViewModel.RegistrationMedicineViewModel();
        }

        private void Submit1(object sender, RoutedEventArgs e)
        {
            string messageBoxText = "Sent!";
            string caption = "Success";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxResult result;

            result = MessageBox.Show(messageBoxText, caption, button);
        }
    }
}

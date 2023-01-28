using HCI.Pages.Rooms;
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
    public partial class QuestionnaireHospitaView : UserControl
    {
        public QuestionnaireHospitaView()
        {
            InitializeComponent();
            this.DataContext = new HCI.ViewModel.QuestionnaireHospitaViewModel();
        }

        private void Marks(object sender, RoutedEventArgs e)
        {
            if (dgrMain.Visibility == Visibility.Visible)
                dgrMain.Visibility = Visibility.Hidden;
            else
                dgrMain.Visibility = Visibility.Visible;
        }

        private void QuesttionaireTemplates(object sender, RoutedEventArgs e)
        {
            if (dgrMain1.Visibility == Visibility.Visible)
                dgrMain1.Visibility = Visibility.Hidden;
            else
                dgrMain1.Visibility = Visibility.Visible;
        }

    }
}

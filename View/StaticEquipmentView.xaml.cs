using HCI.Model;
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
    public partial class StaticEquipmentView : UserControl
    {

        public StaticEquipmentView()
        {
            InitializeComponent();
            this.DataContext = new HCI.ViewModel.StaticEquipmentViewModel();
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            if (addRoomSp.Visibility == Visibility.Visible)
                addRoomSp.Visibility = Visibility.Hidden;
            else
                addRoomSp.Visibility = Visibility.Visible;
        }
    }
}

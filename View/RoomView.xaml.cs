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
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using System.ComponentModel;
using System.Drawing;


namespace HCI.Views
{
    public partial class RoomView : UserControl
    {
        public RoomView()
        {
            InitializeComponent();
            this.DataContext = new HCI.ViewModel.RoomViewModel();
        }

        private void AddNewRoom(object sender, RoutedEventArgs e)
        {
            if (addRoomSp.Visibility == Visibility.Visible)
                addRoomSp.Visibility = Visibility.Hidden;
            else
                addRoomSp.Visibility = Visibility.Visible;
        }

        private void OpenReportCommand(object sender, RoutedEventArgs e)
        {
            if (exp.Visibility == Visibility.Visible)
                exp.Visibility = Visibility.Hidden;
            else
                exp.Visibility = Visibility.Visible;
        }

    }
}

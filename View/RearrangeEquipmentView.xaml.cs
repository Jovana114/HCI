using HCI.Model;
using HCI.Pages.RearrangeEquipmrnt;
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
    public partial class RearrangeEquipmentView : UserControl
    {

        public RearrangeEquipmentView()
        {
            InitializeComponent();
        }

        private void Schedule_static(object sender, RoutedEventArgs e)
        {
            ScheduleRearrangeStaticE srse = new ScheduleRearrangeStaticE();
            srse.Show();
        }

        private void Schedule_dinamic(object sender, RoutedEventArgs e)
        {
            ScheduleRearrangeDinamicE srd = new ScheduleRearrangeDinamicE();
            srd.Show();
        }

        private void Scheduled_static_review(object sender, RoutedEventArgs e)
        {
            ViewStatic vs = new ViewStatic();
            vs.Show();
        }

        private void Scheduled_dinamic_review(object sender, RoutedEventArgs e)
        {
            ViewDinamic vd = new ViewDinamic();
            vd.Show();
        }

    }
}

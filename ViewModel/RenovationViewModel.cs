using HCI.Pages.Renovation;
using HCI.Pages.Tutorial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI.ViewModel
{
    public class RenovationViewModel : BindableBase
    {
        public MyICommand ScheduleSimpleCommand { get; set; }
        public MyICommand ReviewSimpleCommand { get; set; }
        public MyICommand ScheduleAdvancedMergeCommand { get; set; }
        public MyICommand ReviewAdvancedMergeCommand { get; set; }
        public MyICommand ScheduleAdvancedSplitCommand { get; set; }
        public MyICommand ReviewAdvancedSplitCommand { get; set; }
        public MyICommand Tutorial { get; set; }

        public RenovationViewModel()
        {
            ScheduleSimpleCommand = new MyICommand(OnScheduleSimpleCommand);
            ReviewSimpleCommand = new MyICommand(OnReviewSimpleCommand);
            ScheduleAdvancedMergeCommand = new MyICommand(OnScheduleAdvancedMergeCommand);
            ReviewAdvancedMergeCommand = new MyICommand(OnReviewAdvancedMergeCommand);
            ScheduleAdvancedSplitCommand = new MyICommand(OnScheduleAdvancedSplitCommand);
            ReviewAdvancedSplitCommand = new MyICommand(OnReviewAdvancedSplitCommand);
            Tutorial = new MyICommand(OnTutorial);
        }

        public void OnTutorial()
        {
            Tutorial t = new Tutorial();
            t.Show();
        }

        public void OnScheduleSimpleCommand()
        {
            ScheduleSimple ss = new ScheduleSimple();
            ss.Show();
        }

        public void OnReviewSimpleCommand()
        {
            SimpleReview sr = new SimpleReview();
            sr.Show();
        }

        public void OnScheduleAdvancedMergeCommand()
        {
            ScheduleAdvancedMerge sam = new ScheduleAdvancedMerge();
            sam.Show();
        }

        public void OnReviewAdvancedMergeCommand()
        {
            AdvancedMergeReview amr = new AdvancedMergeReview();
            amr.Show();
        }

        public void OnScheduleAdvancedSplitCommand()
        {
            ScheduleAdvancedSplit sas = new ScheduleAdvancedSplit();
            sas.Show();
        }

        public void OnReviewAdvancedSplitCommand()
        {
            AdvancedSplitReview asr = new AdvancedSplitReview();
            asr.Show();
        }

    }
}

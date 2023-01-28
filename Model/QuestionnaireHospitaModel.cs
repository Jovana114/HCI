using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI.Model
{
    public class QuestionnaireHospitaModel : INotifyPropertyChanged
    {
        private int markForService;
        private int markForRecommedation;
        private int markForPossibilityOfVisitingAgain;

        public QuestionnaireHospitaModel()
        {
        }

        public int Service
        {
            get { return markForService; }
            set
            {
                if (markForService != value)
                {
                    markForService = value;
                    RaisePropertyChanged("Mark for service");
                }
            }
        }

        public int Recommedation
        {
            get { return markForRecommedation; }
            set
            {
                if (markForRecommedation != value)
                {
                    markForRecommedation = value;
                    RaisePropertyChanged("Mark for recommedation");
                }
            }
        }

        public int Revisiting
        {
            get { return markForPossibilityOfVisitingAgain; }
            set
            {
                if (markForPossibilityOfVisitingAgain != value)
                {
                    markForPossibilityOfVisitingAgain = value;
                    RaisePropertyChanged("Mark for possibility of visiting hospital again");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

            private void RaisePropertyChanged(string property)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(property));
                }
            }
        }
    
}

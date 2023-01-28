using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI.Model
{
    public class QuestionnaireDoctorModel : INotifyPropertyChanged
    {
        private string doctor;
        private float averageMark;

        public QuestionnaireDoctorModel()
        {
        }

        public string Doctor
        {
            get { return doctor; }
            set
            {
                if (doctor != value)
                {
                    doctor = value;
                    RaisePropertyChanged("Doctor");
                }
            }
        }

        public float AverageMark
        {
            get { return averageMark; }
            set
            {
                if (averageMark != value)
                {
                    averageMark = value;
                    RaisePropertyChanged("Mark");
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

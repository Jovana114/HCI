using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI.Model
{
    public class DinamicEquipmentModel
    {
    }
    public class DinamicEquipment : INotifyPropertyChanged
    {
        private string name;
        private int id;
        private string type;
        private int currentAmount;
        private int optimalAmount;

        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }

        public int Id
        {
            get { return id; }
            set
            {
                if (id != value)
                {
                    id = value;
                    RaisePropertyChanged("Id");
                }
            }
        }

        public string Type
        {
            get { return type; }
            set
            {
                if (type != value)
                {
                    type = value;
                    RaisePropertyChanged("Type");
                }
            }
        }

        public int CurrentAmount
        {
            get { return currentAmount; }
            set
            {
                if (currentAmount != value)
                {
                    currentAmount = value;
                    RaisePropertyChanged("CurrentAmount");
                }
            }
        }

        public int OptimalAmount
        {
            get { return optimalAmount; }
            set
            {
                if (optimalAmount != value)
                {
                    optimalAmount = value;
                    RaisePropertyChanged("OptimalAmount");
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

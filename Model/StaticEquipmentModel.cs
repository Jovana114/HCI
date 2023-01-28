using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI.Model
{
    public class StaticEquipmentModel
    {
    }
    public class StaticEquipment : INotifyPropertyChanged
    {
        private string name;
        private int id;
        private string type;
        private int currentAomunt;
        private int optimalAomunt;

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

        public int CurrentAomunt
        {
            get { return currentAomunt; }
            set
            {
                if (currentAomunt != value)
                {
                    currentAomunt = value;
                    RaisePropertyChanged("CurrentAomunt");
                }
            }
        }

        public int OptimalAomunt
        {
            get { return optimalAomunt; }
            set
            {
                if (optimalAomunt != value)
                {
                    optimalAomunt = value;
                    RaisePropertyChanged("OptimalAomunt");
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

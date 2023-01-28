using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI.Model
{
    public class RoomModel
    {
    }
    public class Room : INotifyPropertyChanged
    {
        private string name;
        private int id;
        private string type;
        private bool active;
        private int occupationTime;

        public Room()
        {
        }

        public Room(int v1, string text1, string text2, bool v2, int v3)
        {
            this.id = v1;
            this.name = text1;
            this.type = text2;
            this.active = v2;
            this.occupationTime = v3;
        }

        public Room(string text1, string text2)
        {
            this.name = text1;
            this.type = text2;
        }

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

        public bool Active
        {
            get { return active; }
            set
            {
                if (active != value)
                {
                    active = value;
                    RaisePropertyChanged("Active");
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

        public int OccupationTime
        {
            get { return occupationTime; }
            set
            {
                if (occupationTime != value)
                {
                    occupationTime = value;
                    RaisePropertyChanged("OccupationTime");
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

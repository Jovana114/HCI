using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI.Model
{
    public class MedicineModel
    {
    }
    public class Medicine : INotifyPropertyChanged
    {
        private string name;
        private int id;
        private int amount;
        private string composition;
        private string allergens;

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

        public int Amount
        {
            get { return amount; }
            set
            {
                if (amount != value)
                {
                    amount = value;
                    RaisePropertyChanged("Amount");
                }
            }
        }

        public string Composition
        {
            get { return composition; }
            set
            {
                if (composition != value)
                {
                    composition = value;
                    RaisePropertyChanged("Composition");
                }
            }
        }

        public string Allergens
        {
            get { return allergens; }
            set
            {
                if (allergens != value)
                {
                    allergens = value;
                    RaisePropertyChanged("Allergens");
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

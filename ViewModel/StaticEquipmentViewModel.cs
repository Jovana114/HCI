using HCI.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HCI.ViewModel
{
    public class StaticEquipmentViewModel : BindableBase
    {
        public ObservableCollection<StaticEquipment> StaticEquipments { get; set; }
        public MyICommand DeleteCommand { get; set; }
        public MyICommand AddCommand { get; set; }
        public MyICommand SearchCommand { get; set; }
        public MyICommand FilterCommand1 { get; set; }
        public MyICommand FilterCommand2 { get; set; }
        private StaticEquipment selectedStaticEquipment;
        private string nText;
        private int iText;
        private string tText;
        private int cText;
        private int oText;
        private string searchText;


        public StaticEquipmentViewModel()
        {
            LoadStaticEquipments();
            DeleteCommand = new MyICommand(OnDelete, CanDelete);
            AddCommand = new MyICommand(OnAdd);
            SearchCommand = new MyICommand(OnSearch);
            FilterCommand1 = new MyICommand(OnFilter1);
            FilterCommand2 = new MyICommand(OnFilter2);

        }

        public ObservableCollection<StaticEquipment> getAll()
        {
            return StaticEquipments;
        }

        private void OnFilter1()
        {
            ObservableCollection<StaticEquipment> list = new ObservableCollection<StaticEquipment>();

            foreach (StaticEquipment st in StaticEquipments.ToList())
            {
                if (st.CurrentAomunt != st.OptimalAomunt)
                {
                    StaticEquipments.Remove(st);
                }
            }
            
        }

        private void OnFilter2()
        {
            foreach (StaticEquipment st in StaticEquipments.ToList())
            {
                if (st.CurrentAomunt == st.OptimalAomunt)
                {

                    StaticEquipments.Remove(st);
                }
            }
        }


        private void OnSearch()
        {

            foreach (StaticEquipment st in StaticEquipments.ToList())
            {
                if (!st.Name.Equals(SearchText))
                {
                    StaticEquipments.Remove(st);
                    SearchCommand.RaiseCanExecuteChanged();
                }
            }
        }

        public StaticEquipment SelectedStaticEquipment
        {
            get { return selectedStaticEquipment; }
            set
            {
                selectedStaticEquipment = value;
                DeleteCommand.RaiseCanExecuteChanged();
            }
        }

        public void LoadStaticEquipments()
        {
            ObservableCollection<StaticEquipment> staticEquipments =
                new ObservableCollection<StaticEquipment>();

            staticEquipments.Add(new StaticEquipment { Name = "S1", Id = 1, Type = "Static", CurrentAomunt = 20, OptimalAomunt = 50});
            staticEquipments.Add(new StaticEquipment { Name = "S2", Id = 2, Type = "Static", CurrentAomunt = 21, OptimalAomunt = 51});
            staticEquipments.Add(new StaticEquipment { Name = "S3", Id = 3, Type = "Static", CurrentAomunt = 22, OptimalAomunt = 52});
            staticEquipments.Add(new StaticEquipment { Name = "S4", Id = 4, Type = "Static", CurrentAomunt = 50, OptimalAomunt = 50});

            StaticEquipments = staticEquipments;
        }

        private bool CanDelete()
        {
            return SelectedStaticEquipment != null;
        }

        private void OnDelete()
        {
            StaticEquipments.Remove(SelectedStaticEquipment);
        }

        public string NText
        {
            get { return nText; }
            set
            {
                if (nText != value)
                {
                    nText = value;
                    OnPropertyChanged("NText");
                }
            }
        }

        public int IText
        {
            get { return iText; }
            set
            {
                if (iText != value)
                {
                    iText = value;
                    OnPropertyChanged("IText");
                }
            }
        }


        public string TText
        {
            get { return tText; }
            set
            {
                if (tText != value)
                {
                    tText = value;
                    OnPropertyChanged("TText");
                }
            }
        }

        public int CText
        {
            get { return cText; }
            set
            {
                if (cText != value)
                {
                    cText = value;
                    OnPropertyChanged("CText");
                }
            }
        }


        public int OText
        {
            get { return oText; }
            set
            {
                if (oText != value)
                {
                    oText = value;
                    OnPropertyChanged("OText");
                }
            }
        }

        public string SearchText
        {
            get { return searchText; }
            set
            {
                if (searchText != value)
                {
                    searchText = value;
                    OnPropertyChanged("SearchText");
                }
            }
        }

        private void OnAdd()
        {
            StaticEquipments.Add(new StaticEquipment { Name = NText, Id = IText, Type = TText, CurrentAomunt = CText, OptimalAomunt = OText});
        }
        
    }
}

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
    public class DinamicEquipmentViewModel : BindableBase
    {
        public ObservableCollection<DinamicEquipment> DinamicEquipments { get; set; }
        public MyICommand DeleteCommand { get; set; }
        public MyICommand AddCommand { get; set; }
        public MyICommand SearchCommand { get; set; }
        public MyICommand FilterCommand1 { get; set; }
        public MyICommand FilterCommand2 { get; set; }
        private DinamicEquipment selectedDinamicEquipment;
        private string nText;
        private int iText;
        private string tText;
        private int cText;
        private int oText;
        private string searchText;

        public DinamicEquipmentViewModel()
        {
            LoadDinamicEquipments();
            DeleteCommand = new MyICommand(OnDelete, CanDelete);
            AddCommand = new MyICommand(OnAdd);
            SearchCommand = new MyICommand(OnSearch);
            FilterCommand1 = new MyICommand(OnFilter1);
            FilterCommand2 = new MyICommand(OnFilter2);
        }

        public ObservableCollection<DinamicEquipment> getAll()
        {
            return DinamicEquipments;
        }


        private void OnSearch()
        {

            foreach (DinamicEquipment st in DinamicEquipments.ToList())
            {
                if (!st.Name.Equals(SearchText))
                {
                    DinamicEquipments.Remove(st);
                    SearchCommand.RaiseCanExecuteChanged();
                }
            }
        }

        private void OnFilter1()
        {

            foreach (DinamicEquipment st in DinamicEquipments.ToList())
            {
                if (st.CurrentAmount != st.OptimalAmount)
                {

                    DinamicEquipments.Remove(st);
                    SearchCommand.RaiseCanExecuteChanged();
                }
            }
        }

        private void OnFilter2()
        {
            foreach (DinamicEquipment st in DinamicEquipments.ToList())
            {
                if (st.CurrentAmount == st.OptimalAmount)
                {

                    DinamicEquipments.Remove(st);
                    SearchCommand.RaiseCanExecuteChanged();
                }
            }
        }

        public DinamicEquipment SelectedDinamicEquipment
        {
            get { return selectedDinamicEquipment; }
            set
            {
                selectedDinamicEquipment = value;
                DeleteCommand.RaiseCanExecuteChanged(); 
            }
        }

        public void LoadDinamicEquipments()
        {
            ObservableCollection<DinamicEquipment> dinamicEquipments =
                new ObservableCollection<DinamicEquipment>();

            dinamicEquipments.Add(new DinamicEquipment { Name = "D1", Id = 1, Type = "Dinamic", CurrentAmount = 20, OptimalAmount = 50});
            dinamicEquipments.Add(new DinamicEquipment { Name = "D2", Id = 2, Type = "Dinamic", CurrentAmount = 21, OptimalAmount = 51});
            dinamicEquipments.Add(new DinamicEquipment { Name = "D3", Id = 3, Type = "Dinamic", CurrentAmount = 22, OptimalAmount = 523});
            dinamicEquipments.Add(new DinamicEquipment { Name = "D4", Id = 4, Type = "Dinamic", CurrentAmount = 23, OptimalAmount = 50});

            DinamicEquipments = dinamicEquipments;
        }

        private bool CanDelete()
        {
            return SelectedDinamicEquipment != null;
        }

        private void OnDelete()
        {
            DinamicEquipments.Remove(SelectedDinamicEquipment);
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
            DinamicEquipments.Add(new DinamicEquipment { Name = NText, Id = IText, Type = TText, CurrentAmount = CText, OptimalAmount = OText});
        }
        
    }
}

using HCI.Model;
using HCI.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI.ViewModel
{
    public class RejectedMedicineViewModel : BindableBase
    {

        public ObservableCollection<RejectedMedicine> Medicines { get; set; }
        public MyICommand DeleteCommand { get; set; }
        public MyICommand UpdateCommand { get; set; }
        public MyICommand SubmitCommand { get; set; }
        public MyICommand SelectCommand { get; set; }
        private RejectedMedicine selectedMedicine;
        private string nText;
        private int iText;
        private int aText;
        private string cText;
        private string allText;

        public RejectedMedicineViewModel()
        {
            LoadMedicines();
            DeleteCommand = new MyICommand(OnDelete, CanDelete);
            UpdateCommand = new MyICommand(OnUpdate, CanDelete);
            SubmitCommand = new MyICommand(OnDelete, CanDelete);
        }

        public RejectedMedicine SelectedMedicine
        {
            get { return selectedMedicine; }
            set
            {
                selectedMedicine = value;
                DeleteCommand.RaiseCanExecuteChanged();
                UpdateCommand.RaiseCanExecuteChanged();
                SubmitCommand.RaiseCanExecuteChanged();
            }
        }

        private bool CanDelete()
        {
            return selectedMedicine != null;
        }

        private void OnDelete()
        {
            Medicines.Remove(selectedMedicine);
        }

        private void OnUpdate()
        {
            Medicines.Remove(SelectedMedicine);
            Medicines.Add(new RejectedMedicine { Name = NText, Id = IText, Amount = AText, Composition = CText, Allergens = AllText });
        }

        public void LoadMedicines()
        {
            ObservableCollection<RejectedMedicine> medicines =
                new ObservableCollection<RejectedMedicine>();

            medicines.Add(new RejectedMedicine { Name = "RM1", Id = 1, Amount = 10, Composition = "C1, C2, C3", Allergens = "A1, A2, A3" });
            medicines.Add(new RejectedMedicine { Name = "RM2", Id = 2, Amount = 11, Composition = "C1, C2, C3", Allergens = "A1, A2, A3" });
            medicines.Add(new RejectedMedicine { Name = "RM3", Id = 8, Amount = 17, Composition = "C1, C2, C3", Allergens = "A1, A2, A3" });

            Medicines = medicines;
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

        public int AText
        {
            get { return aText; }
            set
            {
                if (aText != value)
                {
                    aText = value;
                    OnPropertyChanged("AText");
                }
            }
        }

        public string CText
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

        public string AllText
        {
            get { return allText; }
            set
            {
                if (allText != value)
                {
                    allText = value;
                    OnPropertyChanged("AllText");
                }
            }
        }

    }
}

using HCI.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI.ViewModel
{
    public class MedicineViewModel : BindableBase
    {
        public ObservableCollection<Medicine> Medicines { get; set; }
        public MyICommand DeleteCommand { get; set; }
        private Medicine selectedMedicine;
        private string nText;
        private int iText;
        private int aText;
        private string cText;
        private string allText;

        public MedicineViewModel()
        {
            LoadMedicines();
            DeleteCommand = new MyICommand(OnDelete, CanDelete);
        }


        public Medicine SelectedMedicine
        {
            get { return selectedMedicine; }
            set
            {
                selectedMedicine = value;
                DeleteCommand.RaiseCanExecuteChanged();
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

        public void LoadMedicines()
        {
            ObservableCollection<Medicine> medicines =
                new ObservableCollection<Medicine>();

            medicines.Add(new Medicine { Name = "M1", Id = 1, Amount = 10, Composition = "C1, C2, C3", Allergens = "A1, A2, A3" });
            medicines.Add(new Medicine { Name = "M2", Id = 2, Amount = 11, Composition = "C1, C2, C3", Allergens = "A1, A2, A3" });
            medicines.Add(new Medicine { Name = "M3", Id = 3, Amount = 12, Composition = "C1, C2, C3", Allergens = "A1, A2, A3" });
            medicines.Add(new Medicine { Name = "M4", Id = 4, Amount = 13, Composition = "C1, C2, C3", Allergens = "A1, A2, A3" });
            medicines.Add(new Medicine { Name = "M5", Id = 5, Amount = 14, Composition = "C1, C2, C3", Allergens = "A1, A2, A3" });
            medicines.Add(new Medicine { Name = "M6", Id = 6, Amount = 15, Composition = "C1, C2, C3", Allergens = "A1, A2, A3" });
            medicines.Add(new Medicine { Name = "M7", Id = 7, Amount = 16, Composition = "C1, C2, C3", Allergens = "A1, A2, A3" });
            medicines.Add(new Medicine { Name = "M8", Id = 8, Amount = 17, Composition = "C1, C2, C3", Allergens = "A1, A2, A3" });

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

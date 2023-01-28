using HCI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI
{
    internal class Home1ViewModel : BindableBase
    {
        public MyICommand<string> NavCommand { get; private set; }
        private RoomViewModel roomViewModel = new RoomViewModel();
        private HomeViewModel homeViewModel = new HomeViewModel();
        private MedicineViewModel medicineViewModel = new MedicineViewModel();
        private RegistrationMedicineViewModel registrationMedicineViewModel = new RegistrationMedicineViewModel();
        private RejectedMedicineViewModel rejectedMedicineViewModel = new RejectedMedicineViewModel();
        private StaticEquipmentViewModel staticEquipmentViewModel = new StaticEquipmentViewModel();
        private DinamicEquipmentViewModel dinamicEquipmentViewModel = new DinamicEquipmentViewModel();
        private RearrangeEquipmentViewModel rearrangeEquipmentViewModel = new RearrangeEquipmentViewModel();
        private RenovationViewModel renovationSimpleViewModel = new RenovationViewModel();
        private QuestionnaireHospitaViewModel questionnaireHospitaViewModel = new QuestionnaireHospitaViewModel();
        private BindableBase currentViewModel;

        public Home1ViewModel()
        {
            NavCommand = new MyICommand<string>(OnNav);
            CurrentViewModel = homeViewModel;
        }

        public BindableBase CurrentViewModel
        {
            get { return currentViewModel; }
            set
            {
                SetProperty(ref currentViewModel, value);
            }
        }

        private void OnNav(string destination)
        {
            switch (destination)
            {
                case "home":
                    CurrentViewModel = homeViewModel;
                    break;
                case "room":
                    CurrentViewModel = roomViewModel;
                    break;
                case "roomRenovation":
                    CurrentViewModel= renovationSimpleViewModel;
                    break;
                case "medicine":
                    CurrentViewModel = medicineViewModel;
                    break;
                case "registrationMedicine":
                    CurrentViewModel = registrationMedicineViewModel;
                    break;
                case "rejectedMedicine":
                    CurrentViewModel = rejectedMedicineViewModel;
                    break;
                case "staticEquipment":
                    CurrentViewModel = staticEquipmentViewModel;
                    break;
                case "dinamicEquipment":
                    CurrentViewModel = dinamicEquipmentViewModel;
                    break;
                case "rearrangeEquipment":
                    CurrentViewModel = rearrangeEquipmentViewModel;
                    break;
                case "QuestionnaireReviewHospitals":
                    CurrentViewModel = questionnaireHospitaViewModel;
                    break;
            }
        }
    }
}

using HCI.Model;
using HCI.Pages.Rooms;
using HCI.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HCI.ViewModel
{
    public class QuestionnaireHospitaViewModel : BindableBase
    {
        public ObservableCollection<QuestionnaireHospitaModel> QuestionnaireHospitaModels { get; set; }
        public ObservableCollection<QuestionnaireDoctorModel> QuestionnaireDoctorModels { get; set; }

        public QuestionnaireHospitaViewModel()
        {
            LoadQuestionnaireHospitalModels();
            LoadQuestionnaireDoctorModels();
        }

        public ObservableCollection<QuestionnaireHospitaModel> getAll()
        {
            return QuestionnaireHospitaModels;
        }

        public void LoadQuestionnaireHospitalModels()
        {
            ObservableCollection<QuestionnaireHospitaModel> questionnaireHospitaModels =
                new ObservableCollection<QuestionnaireHospitaModel>();

            questionnaireHospitaModels.Add(new QuestionnaireHospitaModel
            {
                Service = 5,
                Recommedation = 5,
                Revisiting = 5
            });

            QuestionnaireHospitaModels = questionnaireHospitaModels;
        }

        public void LoadQuestionnaireDoctorModels()
        {
            ObservableCollection<QuestionnaireDoctorModel> questionnaireDoctorModels =
                new ObservableCollection<QuestionnaireDoctorModel>();

            questionnaireDoctorModels.Add(new QuestionnaireDoctorModel
            {
                Doctor = "John Doe",
                AverageMark = 5
            });

            questionnaireDoctorModels.Add(new QuestionnaireDoctorModel
            {
                Doctor = "Jane Doe",
                AverageMark = 5
            });

            questionnaireDoctorModels.Add(new QuestionnaireDoctorModel
            {
                Doctor = "Jessy Doe",
                AverageMark = 5
            });

            QuestionnaireDoctorModels = questionnaireDoctorModels;
        }

    }
}

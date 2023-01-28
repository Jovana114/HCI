using HCI.Model;
using HCI.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HCI.Service
{
    public class RenovationService
    {
        RenovationRepository renovationRepository = RenovationRepository.Instance;

        public ObservableCollection<RenovationSimple> GetAllRenovationSimple()
        {
            RenovationRepository renovationRepository = RenovationRepository.Instance;
            return renovationRepository.GetAll();
        }

        public bool CreateRenovationSimple(RenovationSimple renovationSimple)
        {
            RenovationRepository.Instance.renovation.Add(renovationSimple);

            renovationRepository.Save();

            return true;
        }

        public bool DeleteRenovationSimple(RenovationSimple deletedRenovationSimple)
        {

            foreach (RenovationSimple renovationSimple in RenovationRepository.Instance.renovation)
            {
                if (renovationSimple.id == deletedRenovationSimple.id)
                {
                    RenovationRepository.Instance.renovation.Remove(renovationSimple);
                    renovationRepository.Save();
                    return true;
                }
            }
            return false;
        }

    }
}

using HCI.Model;
using HCI.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HCI.Service
{
    public class RenovationAdvancedSplitService
    {
        RenovationAdvancedSplitRepository renovationRepository = RenovationAdvancedSplitRepository.Instance;

        public ObservableCollection<RenovationAdvanced> GetAllRenovationSimple()
        {
            RenovationAdvancedSplitRepository renovationRepository = RenovationAdvancedSplitRepository.Instance;
            return renovationRepository.GetAll();
        }

        public ObservableCollection<Room> GetAllRenovationSimpleRooms()
        {
            RenovationAdvancedMergeRepository renovationRepository = RenovationAdvancedMergeRepository.Instance;
            ObservableCollection<RenovationAdvanced> ra = new ObservableCollection<RenovationAdvanced>();
            ra = renovationRepository.GetAll();

            ObservableCollection<Room> rooms = new ObservableCollection<Room>();
            foreach (RenovationAdvanced ra1 in ra)
            {
                foreach (Room room in ra1.rooms)
                {
                    rooms.Add(room);
                }
            }
            return rooms;
        }

        public bool CreateRenovationAdvanced(RenovationAdvanced renovationAdvanced)
        {
            RenovationAdvancedSplitRepository.Instance.renovation.Add(renovationAdvanced);

            renovationRepository.Save();

            return true;
        }

        public bool DeleteRenovationAdvanced(RenovationAdvanced deletedRenovationAdvanced)
        {

            foreach (RenovationAdvanced renovationAdvanced in RenovationAdvancedSplitRepository.Instance.renovation)
            {
                if (renovationAdvanced.id == deletedRenovationAdvanced.id)
                {
                    RenovationAdvancedSplitRepository.Instance.renovation.Remove(renovationAdvanced);
                    renovationRepository.Save();
                    return true;
                }
            }
            return false;
        }

    }
}

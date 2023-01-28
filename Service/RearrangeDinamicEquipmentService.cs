using HCI.Model;
using HCI.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HCI.Service
{
    public class RearrangeDinamicEquipmentService
    {
        RearrangeDinamicEquipmentRepository rearrangeEquipmentRepository = RearrangeDinamicEquipmentRepository.Instance;

        public ObservableCollection<DinamicEquipment> GetAllRearrangeEquipmentDinamicEquipment()
        {
            ObservableCollection<DinamicEquipment> dinamicEquipment = new ObservableCollection<DinamicEquipment>();
            foreach (RearrangeEquipmentDinamic rearrangeEquipment in rearrangeEquipmentRepository.GetAll())
            {

                foreach (DinamicEquipment dinamicEquipment1 in rearrangeEquipment.dinamicEquipment)
                {
                    dinamicEquipment.Add(dinamicEquipment1);
                }
            }

            return dinamicEquipment;
        }

        public ObservableCollection<RearrangeEquipmentDinamic> GetAllRearrangeEquipment()
        {
            RearrangeDinamicEquipmentRepository rearrangeEquipmentRepository = RearrangeDinamicEquipmentRepository.Instance;
            return rearrangeEquipmentRepository.GetAll();
        }

        public bool CreateRearrangeEquipment(RearrangeEquipmentDinamic rearrangeEquipment)
        {
            RearrangeDinamicEquipmentRepository.Instance.rearrangeEquipment.Add(rearrangeEquipment);

            rearrangeEquipmentRepository.Save();

            return true;
        }

        public bool UpdateRearrangeEquipment(RearrangeEquipmentDinamic newRearrangeEquipment, int index)
        {
            foreach (RearrangeEquipmentDinamic rearrangeEquipment in rearrangeEquipmentRepository.GetAll())
            {
                if (rearrangeEquipment.id == newRearrangeEquipment.id)
                {
                    RearrangeDinamicEquipmentRepository.Instance.rearrangeEquipment.Remove(rearrangeEquipment);
                    RearrangeDinamicEquipmentRepository.Instance.rearrangeEquipment.Insert(index, newRearrangeEquipment);
                    rearrangeEquipmentRepository.Save();
                    return true;
                }
            }
            return false;
        }

        public bool DeleteRearrangeEquipment(RearrangeEquipmentDinamic deletedRearrangeEquipment)
        {

            foreach (RearrangeEquipmentDinamic rearrangeEquipment in RearrangeDinamicEquipmentRepository.Instance.rearrangeEquipment)
            {
                if (rearrangeEquipment.id == deletedRearrangeEquipment.id)
                {
                    RearrangeDinamicEquipmentRepository.Instance.rearrangeEquipment.Remove(rearrangeEquipment);
                    rearrangeEquipmentRepository.Save();
                    return true;
                }
            }
            return false;
        }

    }
}

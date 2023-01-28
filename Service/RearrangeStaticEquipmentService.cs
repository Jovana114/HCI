using HCI.Model;
using HCI.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HCI.Service
{
    public class RearrangeStaticEquipmentService
    {
        RearrangeStaticEquipmentRepository rearrangeEquipmentRepository = RearrangeStaticEquipmentRepository.Instance;

        public ObservableCollection<StaticEquipment> GetAllRearrangeEquipmentStaticEquipment()
        {
            ObservableCollection<StaticEquipment> staticEquipment = new ObservableCollection<StaticEquipment>();
            foreach (RearrangeEquipmentStatic rearrangeEquipment in rearrangeEquipmentRepository.GetAll())
            {

                foreach (StaticEquipment staticEquipment1 in rearrangeEquipment.staticEquipment)
                {
                    staticEquipment.Add(staticEquipment1);
                }
            }

            return staticEquipment;
        }

        public ObservableCollection<RearrangeEquipmentStatic> GetAllRearrangeEquipment()
        {
            RearrangeStaticEquipmentRepository rearrangeEquipmentRepository = RearrangeStaticEquipmentRepository.Instance;
            return rearrangeEquipmentRepository.GetAll();
        }

        public bool CreateRearrangeEquipment(RearrangeEquipmentStatic rearrangeEquipment)
        {
            RearrangeStaticEquipmentRepository.Instance.rearrangeEquipment.Add(rearrangeEquipment);

            rearrangeEquipmentRepository.Save();

            return true;
        }

        public bool UpdateRearrangeEquipment(RearrangeEquipmentStatic newRearrangeEquipment, int index)
        {
            foreach (RearrangeEquipmentStatic rearrangeEquipment in rearrangeEquipmentRepository.GetAll())
            {
                if (rearrangeEquipment.id == newRearrangeEquipment.id)
                {
                    RearrangeStaticEquipmentRepository.Instance.rearrangeEquipment.Remove(rearrangeEquipment);
                    RearrangeStaticEquipmentRepository.Instance.rearrangeEquipment.Insert(index, newRearrangeEquipment);
                    rearrangeEquipmentRepository.Save();
                    return true;
                }
            }
            return false;
        }

        public bool DeleteRearrangeEquipment(RearrangeEquipmentStatic deletedRearrangeEquipment)
        {

            foreach (RearrangeEquipmentStatic rearrangeEquipment in RearrangeStaticEquipmentRepository.Instance.rearrangeEquipment)
            {
                if (rearrangeEquipment.id == deletedRearrangeEquipment.id)
                {
                    RearrangeStaticEquipmentRepository.Instance.rearrangeEquipment.Remove(rearrangeEquipment);
                    rearrangeEquipmentRepository.Save();
                    return true;
                }
            }
            return false;
        }

    }
}

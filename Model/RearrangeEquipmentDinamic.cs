using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI.Model
{
    public class RearrangeEquipmentStatic
    {
        public int id { get; set; }
        public Room firstRoom { get; set; }
        public List<StaticEquipment> staticEquipment { get; set; }
        public Room secondRoom { get; set; }
        public List<int> amount { get; set; }
        public DateTime dateTime { get; set; }
        public String hours { get; set; }
        public int duration { get; set; }

        public RearrangeEquipmentStatic(int Id, Room firstRoom, List<StaticEquipment> staticEquipment, Room secondRoom, List<int> amount, DateTime dateTime, string hours, int duration)
        {
            this.id = Id;
            this.firstRoom = firstRoom;
            this.staticEquipment = staticEquipment;
            this.secondRoom = secondRoom;
            this.amount = amount;
            this.dateTime = dateTime;
            this.hours = hours;
            this.duration = duration;
        }

        public RearrangeEquipmentStatic(int id, List<StaticEquipment> staticEquipment)
        {
            this.id = id;
            this.staticEquipment = staticEquipment;
        }

        public RearrangeEquipmentStatic()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI.Model
{
    public class RearrangeEquipmentDinamic
    {
        public int id { get; set; }
        public Room firstRoom { get; set; }
        public List<DinamicEquipment> dinamicEquipment { get; set; }
        public Room secondRoom { get; set; }
        public List<int> amount { get; set; }
        public DateTime dateTime { get; set; }
        public String hours { get; set; }
        public int duration { get; set; }

        public RearrangeEquipmentDinamic(int Id, Room firstRoom, List<DinamicEquipment> dinamicEquipment, Room secondRoom, List<int> amount, DateTime dateTime, string hours, int duration)
        {
            this.id = Id;
            this.firstRoom = firstRoom;
            this.dinamicEquipment = dinamicEquipment;
            this.secondRoom = secondRoom;
            this.amount = amount;
            this.dateTime = dateTime;
            this.hours = hours;
            this.duration = duration;
        }

        public RearrangeEquipmentDinamic()
        {
        }
    }
}

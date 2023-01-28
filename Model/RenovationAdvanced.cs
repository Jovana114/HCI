using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI.Model
{
    public class RenovationAdvanced
    {
        public int id { get; set; }
        public Room room { get; set; }
        public List<Room> rooms { get; set; }
        public string type { get; set; }
        public DateTime dateTime { get; set; }
        public String hours { get; set; }
        public int duration { get; set; }

        public RenovationAdvanced(int id, Room room, List<Room> rooms, string type, DateTime dateTime, string hours, int duration)
        {
            this.id = id;
            this.room = room;
            this.rooms = rooms;
            this.type = type;
            this.dateTime = dateTime;
            this.hours = hours;
            this.duration = duration;
        }

        public RenovationAdvanced(List<Room> rooms)
        {
            this.rooms = rooms;
        }

        public RenovationAdvanced()
        {
        }
    }
}

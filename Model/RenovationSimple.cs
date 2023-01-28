using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI.Model
{
    public class RenovationSimple
    {
        public int id { get; set; }
        public Room room { get; set; }
        public string type { get; set; }
        public DateTime dateTime { get; set; }
        public String hours { get; set; }
        public int duration { get; set; }

        public RenovationSimple(int id, Room room, string type, DateTime dateTime, string hours, int duration)
        {
            this.id = id;
            this.room = room;
            this.type = type;
            this.dateTime = dateTime;
            this.hours = hours;
            this.duration = duration;
        }

        public RenovationSimple()
        {
        }
    }
}

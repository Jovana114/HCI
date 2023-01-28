using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI.Model
{
    public class RoomReport : ValidationBase
    {
        private DateTime from;
        private DateTime to;

        public DateTime From
        {
            get { return from; }
            set
            {
                if (from != value)
                {
                    from = value;
                    OnPropertyChanged("From");
                }
            }
        }

        public DateTime To
        {
            get { return to; }
            set
            {
                if (to != value)
                {
                    to = value;
                    OnPropertyChanged("To");
                }
            }
        }

        protected override void ValidateSelf()
        {
            if (this.From.GetHashCode() == 0)
            {
                this.ValidationErrors["From"] = "From is required.";
            }
            if (this.To.GetHashCode() == 0)
            {
                this.ValidationErrors["To"] = "To cannot be empty.";
            }
        }
    }
}

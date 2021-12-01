using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyleDelacruzc969.classes
{
    class OtherAppointment : Client
    {
        public string OtherType { get; set; }

        public OtherAppointment()
        {

        }

        public OtherAppointment(string AppointmentId, string CustomerName, string OtherType, string Start, string End, string UserId, string CustomerId)
        {
            this.AppointmentId = AppointmentId;
            this.CustomerName = CustomerName;
            this.Type = OtherType;
            this.Start = Start;
            this.End = End;
            this.UserId = UserId;
            this.CustomerId = CustomerId;

        }

        public override bool getType(string type)
        {
            if (type != "Presentation")
            {
                return true;

            }
            return false;
        }
    }
}

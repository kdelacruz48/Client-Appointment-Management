using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyleDelacruzc969.classes
{
    class PresentationAppointment:Client
    {
        public string PresentationType { get; set; }
        
        public PresentationAppointment()
        {

        }

        public PresentationAppointment(string AppointmentId, string CustomerName, string PresentationType, string Start, string End, string UserId, string CustomerId)
        {
            this.AppointmentId = AppointmentId;
            this.CustomerName = CustomerName;
            this.Type = PresentationType;
            this.Start = Start;
            this.End = End;
            this.UserId = UserId;
            this.CustomerId = CustomerId;
        }


        public override bool getType(string type)
        {
            if (type == "Presentation")
            {
                return true;

            }
            return false;
        }
    }

    

    
}

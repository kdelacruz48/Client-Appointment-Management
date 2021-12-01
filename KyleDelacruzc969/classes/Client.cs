using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyleDelacruzc969.classes
{
    public abstract class Client
    {
        public string AppointmentId { get; set; }
        public string CustomerName { get; set; }
        public string Type { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public string UserId { get; set; }
        public string CustomerId { get; set; }

    }
}

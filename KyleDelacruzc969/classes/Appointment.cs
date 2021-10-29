using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyleDelacruzc969.classes
{
    class Appointment
    {

        public string customerName { get; set; }

        public string type { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
        public string userId { get; set; }

        public int customerId { get; set; }
     
    
        public Appointment(int customerId, string customerName, string type, DateTime start, DateTime end, string userId )
        {
            this.customerId = customerId;
            this.customerName = customerName;
            this.start = start;
            this.end = end;
            this.userId = userId;
            this.type = type;

        }
        public static void addAppointment(Appointment appointment)
        {
            string dateTimeInsertS = appointment.start.ToString("yyyy-MM-dd HH:mm");
            string dateTimeInserE = appointment.end.ToString("yyyy-MM-dd HH:mm");
            
            sql.Help.getAppointmentID();

            string connectionString = ConfigurationManager.ConnectionStrings["MyMySqlKey"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connectionString);

            con.Open();

           
            string sqlString = "INSERT INTO appointment  VALUES('" + sql.Help.nextAppointment + "','" + appointment.customerId + "','" + appointment.userId + "','" + "not needed" + "','" + "not needed" + "','" + "not needed" + "','" + "not needed" + "','" + appointment.type + "','" + "not needed" + "','" + dateTimeInsertS + "','" + dateTimeInserE + "','" + "2019-01-01 00:00:00" + "','" + null + "','" + "2019-01-01 00:00:00" + "','" + null + "' )";
            MySqlCommand cmd = new MySqlCommand(sqlString, con);
            
            
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}

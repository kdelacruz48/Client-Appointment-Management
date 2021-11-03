using KyleDelacruzc969.Pages;
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
        public int appointmentId { get; set; }
        public string customerName { get; set; }

        public string type { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
        public int userId { get; set; }

        public int customerId { get; set; }
     
    
        public Appointment(int customerId, string customerName, string type, DateTime start, DateTime end, int userId )
        {
            this.customerId = customerId;
            this.customerName = customerName;
            this.start = start;
            this.end = end;
            this.userId = userId;
            this.type = type;

        }

        public Appointment(int appointmentId, int customerId, string customerName, string type, DateTime start, DateTime end, int userId)
        {
            this.appointmentId = appointmentId;
            this.customerId = customerId;
            this.customerName = customerName;
            this.start = start;
            this.end = end;
            this.userId = userId;
            this.type = type;
        }
        public static void addAppointment(Appointment appointment)  //add apointment to database
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

        public static void modifyAppointment(Appointment update)  //modify appointment in database 
        {
            string dateTimeInsertS = update.start.ToString("yyyy-MM-dd HH:mm");
            string dateTimeInserE = update.end.ToString("yyyy-MM-dd HH:mm");

            var Id = Main.IndexRow.Cells[0].Value;

            string connectionString = ConfigurationManager.ConnectionStrings["MyMySqlKey"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connectionString);

            con.Open();


            string sqlString = "UPDATE appointment set appointmentId ='" + Id + "',customerId ='" + update.customerId + "',userId ='" + update.userId +  "',type='" + update.type +  "',start='" + dateTimeInsertS + "',end='" + dateTimeInserE + "' WHERE (appointmentId = '" + Id + "')"; 
            
            MySqlCommand cmd = new MySqlCommand(sqlString, con);


            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}

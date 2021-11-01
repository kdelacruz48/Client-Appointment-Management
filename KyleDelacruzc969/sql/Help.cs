using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KyleDelacruzc969.classes;
using KyleDelacruzc969.Pages;
using MySql.Data.MySqlClient;

namespace KyleDelacruzc969.sql
{
	class Help
	{
		public static int addressIndex;
		public static int customerIndex;
		public static int customerId;
		public static int appointmentCount;
		public static int nextAppointment;
		public static DataGridViewRow modifyIndex;
		public static void getAddressID()
		{
			string connectionString = ConfigurationManager.ConnectionStrings["MyMySqlKey"].ConnectionString;
			MySqlConnection con = new MySqlConnection(connectionString);

			con.Open();
			string sqlString = "SELECT * FROM address";
			MySqlCommand cmd = new MySqlCommand(sqlString, con);
			MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
			DataTable address = new DataTable();

			adp.Fill(address);
			con.Close();

			foreach (DataRow row in address.Rows)
			{
				Main.addressCount++;
			}

		}

		public static void getAddress(string address1)
		{
			string connectionString = ConfigurationManager.ConnectionStrings["MyMySqlKey"].ConnectionString;
			MySqlConnection con = new MySqlConnection(connectionString);

			con.Open();
			string sqlString = "SELECT * FROM address";
			MySqlCommand cmd = new MySqlCommand(sqlString, con);
			MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
			DataTable address = new DataTable();

			adp.Fill(address);
			con.Close();

			DataRow[] rows = address.Select("address = '" + address1 + "'");
			addressIndex = address.Rows.IndexOf(rows[0]);
			addressIndex = addressIndex + 1;
		}

		public static void NameForDelete(string custName)
		{


			string connectionString = ConfigurationManager.ConnectionStrings["MyMySqlKey"].ConnectionString;
			MySqlConnection con = new MySqlConnection(connectionString);

			con.Open();
			string sqlString = "SELECT * FROM customer";
			MySqlCommand cmd = new MySqlCommand(sqlString, con);
			MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
			DataTable address = new DataTable();

			adp.Fill(address);
			con.Close();




			DataRow[] rows = address.Select("customerName = '" + custName + "'");
			customerIndex = address.Rows.IndexOf(rows[0]);
			customerIndex = customerIndex + 1;



		}

		public static int getCustomerID(string custName)
		{


			string connectionString = ConfigurationManager.ConnectionStrings["MyMySqlKey"].ConnectionString;
			MySqlConnection con = new MySqlConnection(connectionString);

			con.Open();
			string sqlString = "SELECT * FROM customer";
			MySqlCommand cmd = new MySqlCommand(sqlString, con);
			MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
			DataTable cust = new DataTable();

			adp.Fill(cust);
			con.Close();




			DataRow[] rows = cust.Select("customerName = '" + custName + "'");
			DataRow row = rows[0];
			var custString = row["customerId"].ToString();
			var customerId1 = Int32.TryParse(custString, out customerId);

			return customerId;
		}

		public static void getAppointmentID()
		{

			string connectionString = ConfigurationManager.ConnectionStrings["MyMySqlKey"].ConnectionString;
			MySqlConnection con = new MySqlConnection(connectionString);

			con.Open();
			string sqlString = "SELECT * FROM appointment";
			MySqlCommand cmd = new MySqlCommand(sqlString, con);
			MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
			DataTable appointment = new DataTable();

			adp.Fill(appointment);
			con.Close();

			appointmentCount = 0;
			nextAppointment = 0;


			foreach (DataRow row in appointment.Rows)
			{
				appointmentCount++;
			}
			nextAppointment = appointmentCount + 1;
		}


		public static Appointment getAppointmentToModify()
		{


			string connectionString = ConfigurationManager.ConnectionStrings["MyMySqlKey"].ConnectionString;
			MySqlConnection con = new MySqlConnection(connectionString);

			con.Open();
			string sqlString = "SELECT * FROM appointment";
			MySqlCommand cmd = new MySqlCommand(sqlString, con);
			MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
			DataTable appointment = new DataTable();

			adp.Fill(appointment);
			con.Close();


			var tempID = modifyIndex.Cells[0].Value + string.Empty;

			DataRow[] rows = appointment.Select("appointmentId = '" + tempID + "'");
			DataRow row = rows[0];
			var custId = row["customerId"].ToString();
			var custName = row["customerName"].ToString();
			var type = row["type"].ToString();
			var start = row["start"].ToString();
			var end = row["end"].ToString();
			var userId1 = row["userId"].ToString();
			int userId;
			Int32.TryParse(userId1, out userId);

			int customerId;
			int.TryParse(custId, out customerId);

			var start1 = Convert.ToDateTime(start);
			var end1 = Convert.ToDateTime(end);
			Appointment update = new Appointment(customerId, custName, type, start1, end1, userId);

			return update;

		}

		public static bool isCustomer(string custName)
		{
			string connectionString = ConfigurationManager.ConnectionStrings["MyMySqlKey"].ConnectionString;
			MySqlConnection con = new MySqlConnection(connectionString);

			con.Open();
			string sqlString = "SELECT * FROM customer WHERE customerName = '" + custName + "'";
			MySqlCommand cmd = new MySqlCommand(sqlString, con);
			MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
			DataTable cust = new DataTable();

			adp.Fill(cust);
			con.Close();



			try
			{
				DataRow[] rows = cust.Select("customerName = '" + custName + "'");
				DataRow row = rows[0];
				if (row == null)
				{
					return false;
				}
			}
			catch (Exception)
			{

				return false;
			}


			return true;
		}

		public static bool hasAppointment(DateTime start, DateTime end)
        {

			

			string connectionString = ConfigurationManager.ConnectionStrings["MyMySqlKey"].ConnectionString;
			MySqlConnection con = new MySqlConnection(connectionString);

			con.Open();
			string sqlString = "SELECT * FROM appointment";
			MySqlCommand cmd = new MySqlCommand(sqlString, con);
			MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
			DataTable appointment = new DataTable();

			adp.Fill(appointment);
			con.Close();

			
            foreach (DataRow item in appointment.Rows)
            {
				var start1 = item["start"].ToString();
				DateTime startAppointment= DateTime.Parse(start1);

				var end1 = item["end"].ToString();
				DateTime endAppointment = DateTime.Parse(end1);

				if ( start > startAppointment && start < endAppointment || start < startAppointment && end > startAppointment)  // check to see if appointment overlapps
				{
					
						return true;
				}
            }

			return false;


		}


		public static bool hasAppIn15(int userID)
        {
			{



				string connectionString = ConfigurationManager.ConnectionStrings["MyMySqlKey"].ConnectionString;
				MySqlConnection con = new MySqlConnection(connectionString);

				con.Open();
				string sqlString = "SELECT * FROM appointment";
				MySqlCommand cmd = new MySqlCommand(sqlString, con);
				MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
				DataTable appointment = new DataTable();

				adp.Fill(appointment);
				con.Close();


				foreach (DataRow item in appointment.Rows)
				{
					var start1 = item["start"].ToString();
					DateTime startAppointment1 = DateTime.Parse(start1);
					DateTime startAppointment = startAppointment1.ToLocalTime();

					var end1 = item["end"].ToString();
					DateTime endAppointment = DateTime.Parse(end1);

					var IdCheck = item["userId"].ToString();
					int IdCheck1 = int.Parse(IdCheck);


					var now = DateTime.Now;
					now = now.ToLocalTime();
					var plus = now.AddMinutes(15);

					if (now < startAppointment && plus > startAppointment && IdCheck1 == userID )  
					{

						return true;
					}
				}

				return false;


			}
		}

		
    }
}

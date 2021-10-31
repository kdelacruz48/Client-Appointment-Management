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
			string sqlString = "SELECT * FROM customer WHERE customerName = '"+custName+"'";
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
		
    }
}

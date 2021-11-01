using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KyleDelacruzc969.classes;
using MySql.Data.MySqlClient;

namespace KyleDelacruzc969.Pages
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();

			string connectionString = ConfigurationManager.ConnectionStrings["MyMySqlKey"].ConnectionString;
			MySqlConnection con = new MySqlConnection(connectionString);

			con.Open();
			string sqlString = "SELECT customerName, address, city, country, phone, customerId FROM client_schedule.customer Left join client_schedule.address on customer.addressID = address.addressId Left join client_schedule.city on address.cityId = city.cityId Left join client_schedule.country on city.countryId = country.countryId; ";
			string sqlAppointment = "SELECT appointmentId, customer.customerId, customerName, type, start, end, userId FROM client_schedule.customer INNER JOIN client_schedule.appointment on customer.customerId = appointment.customerId";
			

			MySqlCommand cmd = new MySqlCommand(sqlString, con);
			MySqlCommand cmd1 = new MySqlCommand(sqlAppointment, con);
		

			MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
			
			/*MySqlDataAdapter adp1 = new MySqlDataAdapter(cmd1)*/;
			//DataTable appointment = new DataTable();
			DataTable customer = new DataTable();
			
			//adp1.Fill(appointment);
			adp.Fill(customer);
			
			dgvCustomers.DataSource = customer;
			
			
			//dgvAppointment.DataSource = appointment;

			MySqlDataReader reader = cmd1.ExecuteReader();
			BindingList<Appointment> appointments = new BindingList<Appointment>();

			if (reader.HasRows)
			{
				while (reader.Read())
				{
					appointments.Add(new Appointment(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4).ToLocalTime(), reader.GetDateTime(5).ToLocalTime(), reader.GetInt32(6)));
				}
			}
			else
			{
				MessageBox.Show("Empty list");
			}

			reader.Close();
			dgvAppointment.DataSource = appointments;


			customerCount = dgvCustomers.Rows.Count;
			

		}
		public static int customerCount;
		public static int addressCount = 1;
		public static DataGridViewRow CustomerIndex;
		public static DataGridViewRow IndexRow;
		public static DateTime modifyTime;

		private void buttonLogOut_Click(object sender, EventArgs e)
		{
			this.Close();
			
		}

		private void Main_Load(object sender, EventArgs e)
		{

		}

		private void buttonAddC_Click(object sender, EventArgs e)
		{
			AddCustomer AC1 = new AddCustomer();
			

			AC1.FormClosed += new FormClosedEventHandler(Form_Closed);
	        
			void Form_Closed(object sender1, EventArgs e1)
			{
				AddCustomer form = (AddCustomer)sender1;
				

				string connectionString = ConfigurationManager.ConnectionStrings["MyMySqlKey"].ConnectionString;
				MySqlConnection con = new MySqlConnection(connectionString);

				con.Open();
				string sqlString = "SELECT customerName, address,  city, country, phone, customerId FROM client_schedule.customer Left join client_schedule.address on customer.addressID = address.addressId Left join client_schedule.city on address.cityId = city.cityId Left join client_schedule.country on city.countryId = country.countryId; ";


				MySqlCommand cmd = new MySqlCommand(sqlString, con);
				MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
				DataTable customer = new DataTable();
				adp.Fill(customer);
				dgvCustomers.DataSource = customer;

			}
			AC1.Show();
		}

        private void buttonDeleteC_Click(object sender, EventArgs e)
        {

			

			
				var ID = dgvCustomers.SelectedRows[0].Index;
				var custName = dgvCustomers.SelectedRows[0].Cells[0].Value + string.Empty;

				var deleteName = dgvCustomers.SelectedRows[0].Cells[0].Value;
				var deleteAddress = dgvCustomers.SelectedRows[0].Cells[1].Value;


				sql.Help.NameForDelete(custName);

				string connectionString = ConfigurationManager.ConnectionStrings["MyMySqlKey"].ConnectionString;
				MySqlConnection con = new MySqlConnection(connectionString);

				con.Open();

				string sqlString1 = "DELETE FROM address WHERE (address = '" + deleteAddress + "')";
				string sqlString = "DELETE FROM customer WHERE (customerName = '" + deleteName + "')";

				MySqlCommand cmd1 = new MySqlCommand(sqlString1, con);
				MySqlCommand cmd = new MySqlCommand(sqlString, con);

				try
				{
					cmd.ExecuteNonQuery();
					cmd1.ExecuteNonQuery();
				}

				catch
				{
					//throwing exception for sql insert occaisonaly but usually works fine, still perfoms correct opperation
					//wether exception is thrown or not.
				}
				con.Close();



				MySqlConnection con2 = new MySqlConnection(connectionString);

				con.Open();
				string sqlString2 = "SELECT customerName, address, city, country, phone, customerId FROM client_schedule.customer Left join client_schedule.address on customer.addressID = address.addressId Left join client_schedule.city on address.cityId = city.cityId Left join client_schedule.country on city.countryId = country.countryId; ";


				MySqlCommand cmd2 = new MySqlCommand(sqlString2, con2);
				MySqlDataAdapter adp2 = new MySqlDataAdapter(cmd2);
				DataTable customer = new DataTable();
				adp2.Fill(customer);
				dgvCustomers.DataSource = customer;




			

			
        }

        private void buttonModifyC_Click(object sender, EventArgs e)
        {
			CustomerIndex = dgvCustomers.SelectedRows[0];
			IndexRow = dgvCustomers.SelectedRows[0];

			ModifyCustomer MC1 = new ModifyCustomer();

			MC1.FormClosed += new FormClosedEventHandler(Form_Closed);

			void Form_Closed(object sender1, EventArgs e1)
			{
				ModifyCustomer form = (ModifyCustomer)sender1;


				string connectionString = ConfigurationManager.ConnectionStrings["MyMySqlKey"].ConnectionString;
				MySqlConnection con = new MySqlConnection(connectionString);

				con.Open();
				string sqlString = "SELECT customerName, address, city, country, phone, customerId FROM client_schedule.customer Left join client_schedule.address on customer.addressID = address.addressId Left join client_schedule.city on address.cityId = city.cityId Left join client_schedule.country on city.countryId = country.countryId; ";


				MySqlCommand cmd = new MySqlCommand(sqlString, con);
				MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
				DataTable customer = new DataTable();
				adp.Fill(customer);
				dgvCustomers.DataSource = customer;

			}

			MC1.Show();

            
        }

        private void buttonAddA_Click(object sender, EventArgs e)
        {
			AddAppointment A1 = new AddAppointment();

			A1.FormClosed += new FormClosedEventHandler(Form_Closed);

			void Form_Closed(object sender1, EventArgs e1)
			{
				AddAppointment form = (AddAppointment)sender1;


				string connectionString = ConfigurationManager.ConnectionStrings["MyMySqlKey"].ConnectionString;
				MySqlConnection con = new MySqlConnection(connectionString);

				con.Open();
				string sqlAppointment = "SELECT appointmentId, customer.customerId, customerName, type, start, end, userId FROM client_schedule.customer INNER JOIN client_schedule.appointment on customer.customerId = appointment.customerId";

				MySqlCommand cmd1 = new MySqlCommand(sqlAppointment, con);
				MySqlDataReader reader = cmd1.ExecuteReader();
				BindingList<Appointment> appointments = new BindingList<Appointment>();

				if (reader.HasRows)
				{
					while (reader.Read())
					{
						appointments.Add(new Appointment(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4).ToLocalTime(), reader.GetDateTime(5).ToLocalTime(), reader.GetInt32(6)));
					}
				}
				else
				{
					MessageBox.Show("Empty list");
				}

				reader.Close();
				dgvAppointment.DataSource = appointments;

			}
			A1.Show();
        }

        private void buttonDeleteA_Click(object sender, EventArgs e)
        {
			sql.Help.getAppointmentID();
			var ID = sql.Help.appointmentCount;

			

			string connectionString = ConfigurationManager.ConnectionStrings["MyMySqlKey"].ConnectionString;
			MySqlConnection con = new MySqlConnection(connectionString);

			con.Open();

			string sqlString = "DELETE FROM appointment WHERE (appointmentID = '" +ID + "')";
			

			
			MySqlCommand cmd = new MySqlCommand(sqlString, con);

		
			cmd.ExecuteNonQuery();
				
			
			con.Close();


			

			con.Open();
			string sqlAppointment = "SELECT appointmentId, customer.customerId, customerName, type, start, end, userId FROM client_schedule.customer INNER JOIN client_schedule.appointment on customer.customerId = appointment.customerId";

			MySqlCommand cmd1 = new MySqlCommand(sqlAppointment, con);
			MySqlDataReader reader = cmd1.ExecuteReader();
			BindingList<Appointment> appointments = new BindingList<Appointment>();

			if (reader.HasRows)
			{
				while (reader.Read())
				{
					appointments.Add(new Appointment(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4).ToLocalTime(), reader.GetDateTime(5).ToLocalTime(), reader.GetInt32(6)));
				}
			}
			else
			{
				MessageBox.Show("Empty list");
			}

			reader.Close();
			dgvAppointment.DataSource = appointments;
		}

        private void dgvAppointment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
			dgvAppointment.EndEdit();
			dgvAppointment.Refresh();
			dgvAppointment.Update();
			IndexRow = dgvAppointment.SelectedRows[0];
			sql.Help.modifyIndex = dgvAppointment.SelectedRows[0];
			var timeString = dgvAppointment.SelectedRows[0].Cells[3]+string.Empty;
			 
        }

		private void buttonModifyA_Click(object sender, EventArgs e)
		{
			IndexRow = dgvAppointment.SelectedRows[0];
			ModifyAppointment MA1 = new ModifyAppointment();

			MA1.FormClosed += new FormClosedEventHandler(Form_Closed);

			void Form_Closed(object sender1, EventArgs e1)
			{
				ModifyAppointment form = (ModifyAppointment)sender1;


				string connectionString = ConfigurationManager.ConnectionStrings["MyMySqlKey"].ConnectionString;
				MySqlConnection con = new MySqlConnection(connectionString);

				con.Open();
				string sqlAppointment = "SELECT appointmentId, customer.customerId, customerName, type, start, end, userId FROM client_schedule.customer INNER JOIN client_schedule.appointment on customer.customerId = appointment.customerId";

				MySqlCommand cmd1 = new MySqlCommand(sqlAppointment, con);
				MySqlDataReader reader = cmd1.ExecuteReader();
				BindingList<Appointment> appointments = new BindingList<Appointment>();

				if (reader.HasRows)
				{
					while (reader.Read())
					{
						appointments.Add(new Appointment(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4).ToLocalTime(), reader.GetDateTime(5).ToLocalTime(), reader.GetInt32(6)));
					}
				}
				else
				{
					MessageBox.Show("Empty list");
				}

				reader.Close();
				dgvAppointment.DataSource = appointments;
			}
				MA1.Show();
			
		}

        private void buttonAll_Click(object sender, EventArgs e)
        {
			string connectionString = ConfigurationManager.ConnectionStrings["MyMySqlKey"].ConnectionString;
			MySqlConnection con = new MySqlConnection(connectionString);

			con.Open();
			string sqlAppointment = "SELECT appointmentId, customer.customerId, customerName, type, start, end, userId FROM client_schedule.customer INNER JOIN client_schedule.appointment on customer.customerId = appointment.customerId";

			MySqlCommand cmd1 = new MySqlCommand(sqlAppointment, con);
			MySqlDataReader reader = cmd1.ExecuteReader();
			BindingList<Appointment> appointments = new BindingList<Appointment>();

			if (reader.HasRows)
			{
				while (reader.Read())
				{
					appointments.Add(new Appointment(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4).ToLocalTime(), reader.GetDateTime(5).ToLocalTime(), reader.GetInt32(6)));
				}
			}
			else
			{
				MessageBox.Show("Empty list");
			}

			reader.Close();
			dgvAppointment.DataSource = appointments;
		}

        private void buttonWeekly_Click(object sender, EventArgs e)
        {
			var now = DateTime.Now;
			var now1 = now.ToString("yyyy-MM-dd HH:mm");
			var week = now.AddDays(7);
			var week1 = week.ToString("yyyy-MM-dd HH:mm");
			string connectionString = ConfigurationManager.ConnectionStrings["MyMySqlKey"].ConnectionString;
			MySqlConnection con = new MySqlConnection(connectionString);

			con.Open();
			string sqlAppointment = "SELECT appointmentId, customer.customerId, customerName, type, start, end, userId FROM client_schedule.customer INNER JOIN client_schedule.appointment on customer.customerId = appointment.customerId WHERE (start BETWEEN'" + now1 + "'AND'" + week1 + "')";

			MySqlCommand cmd1 = new MySqlCommand(sqlAppointment, con);
			MySqlDataReader reader = cmd1.ExecuteReader();
			BindingList<Appointment> appointments = new BindingList<Appointment>();

			if (reader.HasRows)
			{
				while (reader.Read())
				{
					appointments.Add(new Appointment(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4).ToLocalTime(), reader.GetDateTime(5).ToLocalTime(), reader.GetInt32(6)));
				}
			}
			else
			{
				MessageBox.Show("Empty list");
			}
			reader.Close();
			dgvAppointment.DataSource = appointments;

		}

        private void buttonMonth_Click(object sender, EventArgs e)
        {
			var now = DateTime.Now;
			var now1 = now.ToString("yyyy-MM-dd HH:mm");
			var month = now.AddDays(30);
			var month1 = month.ToString("yyyy-MM-dd HH:mm");
			string connectionString = ConfigurationManager.ConnectionStrings["MyMySqlKey"].ConnectionString;
			MySqlConnection con = new MySqlConnection(connectionString);

			con.Open();
			string sqlAppointment = "SELECT appointmentId, customer.customerId, customerName, type, start, end, userId FROM client_schedule.customer INNER JOIN client_schedule.appointment on customer.customerId = appointment.customerId WHERE (start BETWEEN'" + now1 + "'AND'" + month1 + "')";

			MySqlCommand cmd1 = new MySqlCommand(sqlAppointment, con);
			MySqlDataReader reader = cmd1.ExecuteReader();
			BindingList<Appointment> appointments = new BindingList<Appointment>();

			if (reader.HasRows)
			{
				while (reader.Read())
				{
					appointments.Add(new Appointment(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4).ToLocalTime(), reader.GetDateTime(5).ToLocalTime(), reader.GetInt32(6)));
				}
			}
			else
			{
				MessageBox.Show("Empty list");
			}
			reader.Close();
			dgvAppointment.DataSource = appointments;
		}
    }
}

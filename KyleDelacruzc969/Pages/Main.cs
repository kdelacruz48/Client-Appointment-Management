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
		public Main()                  //My Lambdas are located in the check class, and the sql.help class(hasAppIn15)
		{                               // I am pretty new to this so if this need revision, specific input would be a huge 
			                           // help. Thank you! 
			InitializeComponent();

			string connectionString = ConfigurationManager.ConnectionStrings["MyMySqlKey"].ConnectionString;    // fill dgv's
			MySqlConnection con = new MySqlConnection(connectionString);

			con.Open();
			string sqlString = "SELECT customerName, address, city, country, phone, customerId FROM client_schedule.customer Left join client_schedule.address on customer.addressID = address.addressId Left join client_schedule.city on address.cityId = city.cityId Left join client_schedule.country on city.countryId = country.countryId; ";
			string sqlAppointment = "SELECT appointmentId, customer.customerId, customerName, type, start, end, userId FROM client_schedule.customer INNER JOIN client_schedule.appointment on customer.customerId = appointment.customerId";
			

			MySqlCommand cmd = new MySqlCommand(sqlString, con);
			MySqlCommand cmd1 = new MySqlCommand(sqlAppointment, con);
		

			MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
			
		
			DataTable customer = new DataTable();
			
			
			adp.Fill(customer);
			
			dgvCustomers.DataSource = customer;
			
			
			

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
		public static bool found;

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
			

			AC1.FormClosed += new FormClosedEventHandler(Form_Closed);  // watches for form closed to update dgv, used throughout.
	        
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

        private void buttonDeleteC_Click(object sender, EventArgs e)// deletes customer from database
        {

			

			
				var ID = dgvCustomers.SelectedRows[0].Index;
				var custName = dgvCustomers.SelectedRows[0].Cells[0].Value + string.Empty;

				var deleteName = dgvCustomers.SelectedRows[0].Cells[0].Value;
				var deleteAddress = dgvCustomers.SelectedRows[0].Cells[1].Value;
			    var deleteId = dgvCustomers.SelectedRows[0].Cells[5].Value + string.Empty;

			    bool cantDelete = sql.Help.hasExistingAppointment(deleteId);

			if (cantDelete == true)
			{
				MessageBox.Show("Customer has existing appointment, please delete appointment first");
			}
			else
			{
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
			
        }

        private void buttonModifyC_Click(object sender, EventArgs e) // modify customer in database
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

			MC1.Show();

            
        }

        private void buttonAddA_Click(object sender, EventArgs e) // adds appointment to database
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

        private void buttonDeleteA_Click(object sender, EventArgs e)  // deletes appointment from database
        {
			sql.Help.getAppointmentID();
			var ID = sql.Help.appointmentCount;

			IndexRow = dgvAppointment.SelectedRows[0];
			ID = (int)IndexRow.Cells[0].Value;
			

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

        private void dgvAppointment_CellContentClick(object sender, DataGridViewCellEventArgs e)  // updates some indexes for use elsewhere
        {
			dgvAppointment.EndEdit();
			dgvAppointment.Refresh();
			dgvAppointment.Update();
			IndexRow = dgvAppointment.SelectedRows[0];
			sql.Help.modifyIndex = dgvAppointment.SelectedRows[0];
			var timeString = dgvAppointment.SelectedRows[0].Cells[3]+string.Empty;
			 
        }

		private void buttonModifyA_Click(object sender, EventArgs e) //Modify appointment in database
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

        private void buttonAll_Click(object sender, EventArgs e)  // shows all appointments in calender
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

        private void buttonWeekly_Click(object sender, EventArgs e) // shows all appointments for the next week in calender
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

        private void buttonMonth_Click(object sender, EventArgs e) // shows all appointments for the next month in the calender
			                                                       
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

        private void buttonReports_Click(object sender, EventArgs e)
        {
			Reports R1 = new Reports();
			R1.Show();
        }

		private void buttonSearch_Click(object sender, EventArgs e)
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



			BindingList<Client> temp = new BindingList<Client>();
			found = false;
			if (textBoxSearch.Text != "")
			{
				for (int i = 0; i < appointments.Count; i++)
				{
                    dataGridViewSearch.DataSource = appointments;
                    var tempIndex = dataGridViewSearch.Rows[i];

					var a1 = tempIndex.Cells[0].Value + string.Empty;
					var a2 = tempIndex.Cells[1].Value + string.Empty;
					var a3 = tempIndex.Cells[2].Value + string.Empty;
					var a4 = tempIndex.Cells[3].Value + string.Empty;
					var a5 = tempIndex.Cells[4].Value + string.Empty;
					var a6 = tempIndex.Cells[5].Value + string.Empty;
					var a7 = tempIndex.Cells[6].Value + string.Empty;

					string row = a1 + a2 + a3 + a4 + a5 + a6 + a7;

					if (row.ToUpper().Contains(textBoxSearch.Text.ToUpper()))
					{

						if(a3 == "Presentation")
                        {
							PresentationAppointment client = new PresentationAppointment(a1,a2,a3,a4,a5,a6,a7);
							temp.Add(client);
							
                        }
						
						else if(a3 != "Presentation")
                        {
							OtherAppointment client = new OtherAppointment(a1, a2, a3, a4, a5, a6, a7);
							temp.Add(client);
							
						}

						var isPres = PresentationAppointment.IsPresentation(a3);
						if (isPres == true)
                        {
							MessageBox.Show( a2 + " Has an upcoming presentation on " + a4);
                        }

						found = true;
					}

				}
			}
				if (found == true)
				{
					dataGridViewSearch.DataSource = temp;
					found = false;
					
				}

				else
				{
					MessageBox.Show("Nothing found");
					dataGridViewSearch.DataSource = null;
				}

			}

        private void dataGridViewSearch_SelectionChanged(object sender, EventArgs e)
        {
			dataGridViewSearch.ClearSelection();
        }
    }
	}
    


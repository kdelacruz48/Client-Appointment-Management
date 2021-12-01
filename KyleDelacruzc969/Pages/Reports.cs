using KyleDelacruzc969.classes;
using MySql.Data.MySqlClient;
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

namespace KyleDelacruzc969.Pages
{
	public partial class Reports : Form
	{
		public Reports()
		{
			InitializeComponent();



		}

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
			
			comboBox1.Enabled = true;
			comboBox2.Enabled = true;
			comboBox3.Enabled = false;

			comboBox1.SelectedIndex = -1;
			comboBox2.SelectedIndex = -1;
			comboBox3.SelectedIndex= -1;
			
        }

        private void labelReports_Click(object sender, EventArgs e)
        {

        }

        private void Reports_Load(object sender, EventArgs e)
        {
			radioButtonType.Checked = true;
		}

        private void buttonShow_Click(object sender, EventArgs e)
        {
			
			if (radioButtonType.Checked == true)        // display report of number of appointments that are of a selected type and month
			{
				var month = comboBox2.Text.ToString();
				var type = comboBox1.Text.ToString();

				string connectionString = ConfigurationManager.ConnectionStrings["MyMySqlKey"].ConnectionString;
				MySqlConnection con = new MySqlConnection(connectionString);

				con.Open();
				string sqlAppointment = "SELECT appointmentId, customer.customerId, customerName, type, start, end, userId FROM client_schedule.customer INNER JOIN client_schedule.appointment on customer.customerId = appointment.customerId WHERE start LIKE '%-" + month + "-%' AND type LIKE '%" + type + "%'";

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

				else if (comboBox1.Text.ToString() == "")
				{
					MessageBox.Show("Please select a type");
				}
				else if (comboBox2.Text.ToString() == "")
				{
					MessageBox.Show("Please select a month");
				}
				else
				{
					MessageBox.Show("Empty list");
				}

				reader.Close();
				dgvReports.DataSource = appointments;
			}

			else if (radioButtonSchedule.Checked == true)  // report shows selected user's appointments
			{

				if (comboBox3.Text.ToString() == "")
				{
					MessageBox.Show("Please select a userID");
				}

				else
				{


					var userID = comboBox3.Text.ToString();



					string connectionString = ConfigurationManager.ConnectionStrings["MyMySqlKey"].ConnectionString;
					MySqlConnection con = new MySqlConnection(connectionString);

					con.Open();
					string sqlAppointment = "SELECT appointmentId, customer.customerId, customerName, type, start, end, userId FROM client_schedule.customer INNER JOIN client_schedule.appointment on customer.customerId = appointment.customerId WHERE userId LIKE '%" + userID + "%'";

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
					dgvReports.DataSource = appointments;
				}
			}

			

			else   // shows a report with a list of customers and their phone numbers
			{




				string connectionString = ConfigurationManager.ConnectionStrings["MyMySqlKey"].ConnectionString;
				MySqlConnection con = new MySqlConnection(connectionString);

				con.Open();
				string sqlPhone = "SELECT customer.customerId, customerName, phone FROM client_schedule.customer INNER JOIN client_schedule.address on customer.addressId = address.addressId";


				MySqlCommand cmd = new MySqlCommand(sqlPhone, con);
				MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
				DataTable phone = new DataTable();
				adp.Fill(phone);
				dgvReports.DataSource = phone;

			}
		}

        private void buttonExit_Click(object sender, EventArgs e)
        {
			this.Close();
        }

        private void radioButtonSchedule_CheckedChanged(object sender, EventArgs e)
        {

			comboBox1.SelectedIndex = -1;
			comboBox2.SelectedIndex = -1;
			comboBox3.SelectedIndex = -1;

			comboBox1.Enabled = false;
			comboBox2.Enabled = false;
			comboBox3.Enabled = true;
        }

        private void radioButtonPhone_CheckedChanged(object sender, EventArgs e)
        {
			

			comboBox1.SelectedIndex = -1;
			comboBox2.SelectedIndex = -1;
			comboBox1.Enabled = false;
			comboBox2.Enabled = false;
			comboBox3.Enabled = false;
		}

        private void radioButtonCustomerCountry_CheckedChanged(object sender, EventArgs e)
        {
			
		}
    }
}

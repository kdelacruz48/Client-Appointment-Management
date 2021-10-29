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
	public partial class AddAppointment : Form
	{
		public AddAppointment()
		{
			InitializeComponent();
			string connectionString = ConfigurationManager.ConnectionStrings["MyMySqlKey"].ConnectionString;
			MySqlConnection con = new MySqlConnection(connectionString);

			con.Open();
			string sqlString = "SELECT customerName FROM customer";
			

			MySqlCommand cmd = new MySqlCommand(sqlString, con);
			MySqlDataAdapter adp2 = new MySqlDataAdapter(cmd);
			DataTable customerName = new DataTable();
			adp2.Fill(customerName);
			con.Close();

			

			this.comboBoxName.DataSource = customerName;
			this.comboBoxName.DisplayMember = "customerName";
			this.comboBoxName.SelectedIndex = -1;
			this.textBoxUserID.Text = Login.userID +string.Empty;


			TimeSpan timeEnd = dateTimePicker2.Value.TimeOfDay;    // make appoint ment end 30 minutes after set, formatted in AM/PM
			var t = timeEnd += TimeSpan.FromMinutes(30);
			string format = t.ToString(@"hh\:mm\:ss");
			string format1 = DateTime.Parse(format).ToString("hh:mm tt");
			this.textBoxEnd.Text = format1; 



		}

        private void AddAppointment_Load(object sender, EventArgs e)
        {
			

		}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
			
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
			if (comboBoxName.Text == "")
			{
				MessageBox.Show("Please select a name");
			}

			else if (comboBoxType.Text == "")
			{
				MessageBox.Show("Please select an appointment type");
			}

			else
			{
				var name = comboBoxName.Text;
				var type = comboBoxType.Text;
				DateTime start;
				DateTime end;

				var date = dateTimePicker1.Value.Date;
				TimeSpan time = dateTimePicker2.Value.TimeOfDay;
				var result = date + time;
				result = result.ToUniversalTime();


				var custID = sql.Help.getCustomerID(name);
				start = result;
				end = result.AddMinutes(30);
				var userID = textBoxUserID.Text;


				Appointment appointment = new Appointment(custID, name, type, start, end, userID);
				Appointment.addAppointment(appointment);
				this.Close();
			}
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
			TimeSpan timeEnd = dateTimePicker2.Value.TimeOfDay;
			var t = timeEnd += TimeSpan.FromMinutes(30);
			string format = t.ToString(@"hh\:mm\:ss");
			string format1 = DateTime.Parse(format).ToString("hh:mm tt");
			this.textBoxEnd.Text = format1;

		}

        private void buttonCancel_Click(object sender, EventArgs e)
        {
			this.Close();
        }
    }
}

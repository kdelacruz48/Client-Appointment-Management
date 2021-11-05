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
	public partial class ModifyAppointment : Form
	{
		public ModifyAppointment()
		{


			InitializeComponent();
			string connectionString = ConfigurationManager.ConnectionStrings["MyMySqlKey"].ConnectionString;
			MySqlConnection con = new MySqlConnection(connectionString);

			con.Open();
			string sqlString = "SELECT customerName FROM customer";


			MySqlCommand cmd = new MySqlCommand(sqlString, con);
			MySqlDataAdapter adp2 = new MySqlDataAdapter(cmd);
			DataTable customerName = new DataTable();
			adp2.Fill(customerName);                              // for populating name combobox with customers
			con.Close();



			this.comboBoxName.DataSource = customerName;
			this.comboBoxName.DisplayMember = "customerName";

			comboBoxName.Text = Main.IndexRow.Cells[1].Value.ToString();


			if (Main.IndexRow.Cells[2].Value + string.Empty == "Consultation")
				comboBoxType.SelectedIndex = 0;

			else if (Main.IndexRow.Cells[2].Value + string.Empty == "Review")
				comboBoxType.SelectedIndex = 1;

			else if (Main.IndexRow.Cells[2].Value + string.Empty == "Final")
				comboBoxType.SelectedIndex = 2;

			else
				comboBoxType.SelectedIndex = -1;


			dateTimePicker1.Value = (DateTime)Main.IndexRow.Cells[3].Value;
			dateTimePicker2.Value = (DateTime)Main.IndexRow.Cells[3].Value;



			TimeSpan timeEnd = dateTimePicker2.Value.TimeOfDay;    // make appoint ment end 30 minutes after set, formatted in AM/PM
			var t = timeEnd += TimeSpan.FromMinutes(30);
			string format = t.ToString(@"hh\:mm\:ss");
			string format1 = DateTime.Parse(format).ToString("hh:mm tt");
			this.textBoxEnd.Text = format1;


			textBoxUserID.Text = Main.IndexRow.Cells[5].Value + string.Empty;






		}

		private void dateTimePicker2_ValueChanged(object sender, EventArgs e)  //makes appointment end 30 minutes after start while changining time
		{
			TimeSpan timeEnd = dateTimePicker2.Value.TimeOfDay;
			var t = timeEnd += TimeSpan.FromMinutes(30);
			string format = t.ToString(@"hh\:mm\:ss");
			string format1 = DateTime.Parse(format).ToString("hh:mm tt");
			this.textBoxEnd.Text = format1;
		}

		private void ModifyAppointment_Load(object sender, EventArgs e)
		{

		}

		private void buttonModify_Click(object sender, EventArgs e) // modifies appointment in database
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
				var local = result.ToLocalTime();

				TimeSpan s = DateTime.Parse("9:00 AM").TimeOfDay;
				TimeSpan en = DateTime.Parse("5:00 PM").TimeOfDay;
				

				if (local.TimeOfDay < s || local.TimeOfDay > en)  // checks if outside buisness hours
				{
					MessageBox.Show("outside buisness hours");
				}

				else
				{


					var custID = sql.Help.getCustomerID(name);
					start = result;
					end = result.AddMinutes(30);
					var userID1 = textBoxUserID.Text;
					int userID;
					Int32.TryParse(userID1, out userID);


                    bool appointmentCheck = sql.Help.hasAppointment(start, end);




                    if (appointmentCheck == true)                           // checks if user already has a scheduled appointment
					{
						MessageBox.Show("User already has scheduled meeting");

					}
					else
					{


						Appointment appointment = new Appointment(custID, name, type, start, end, userID);
						Appointment.modifyAppointment(appointment);
						this.Close();
					}
				}
			}
		}

        private void buttonCancel_Click(object sender, EventArgs e)
        {
			this.Close();
        }
    }
}

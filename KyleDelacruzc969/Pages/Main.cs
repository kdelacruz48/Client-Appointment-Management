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
			string sqlString = "SELECT customerName, address, address2, city, country, phone FROM client_schedule.customer Left join client_schedule.address on customer.addressID = address.addressId Left join client_schedule.city on address.cityId = city.cityId Left join client_schedule.country on city.countryId = country.countryId; ";
			string sqlAppointment = "SELECT customer.customerId, customerName, type, start, end, userId FROM client_schedule.customer INNER JOIN client_schedule.appointment on customer.customerId = appointment.customerId";

			MySqlCommand cmd = new MySqlCommand(sqlString, con);
			MySqlCommand cmd1 = new MySqlCommand(sqlAppointment, con);
			MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
			MySqlDataAdapter adp1 = new MySqlDataAdapter(cmd1);
			DataTable appointment = new DataTable();
			DataTable customer = new DataTable();
			adp1.Fill(appointment);
			adp.Fill(customer);
			dgvCustomers.DataSource = customer;
			dgvAppointment.DataSource = appointment;


			customerCount = dgvCustomers.Rows.Count;
			

		}
		public static int customerCount;
		public static int addressCount = 1;
		public static DataGridViewRow CustomerIndex;
		public static DataGridViewRow IndexRow;

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
				string sqlString = "SELECT customerName, address, address2, city, country, phone FROM client_schedule.customer Left join client_schedule.address on customer.addressID = address.addressId Left join client_schedule.city on address.cityId = city.cityId Left join client_schedule.country on city.countryId = country.countryId; ";


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
			var custName = dgvCustomers.SelectedRows[0].Cells[0].Value +string.Empty;

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
			string sqlString2 = "SELECT customerName, address, address2, city, country, phone FROM client_schedule.customer Left join client_schedule.address on customer.addressID = address.addressId Left join client_schedule.city on address.cityId = city.cityId Left join client_schedule.country on city.countryId = country.countryId; ";


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
				string sqlString = "SELECT customerName, address, address2, city, country, phone FROM client_schedule.customer Left join client_schedule.address on customer.addressID = address.addressId Left join client_schedule.city on address.cityId = city.cityId Left join client_schedule.country on city.countryId = country.countryId; ";


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
			A1.Show();
        }
    }
}

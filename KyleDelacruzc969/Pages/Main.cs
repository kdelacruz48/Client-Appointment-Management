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


			MySqlCommand cmd = new MySqlCommand(sqlString, con);
			MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
			DataTable customer = new DataTable();
			adp.Fill(customer);
			dgvCustomers.DataSource = customer;

			customerCount = dgvCustomers.Rows.Count;
			

		}
		public static int customerCount;
		public static int addressCount = 1;
		public static DataGridViewRow CustomerIndex;

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
			var forDelete = ID + 1;

			string connectionString = ConfigurationManager.ConnectionStrings["MyMySqlKey"].ConnectionString;
			MySqlConnection con = new MySqlConnection(connectionString);

			con.Open();

			string sqlString1 = "DELETE FROM address WHERE (addressID = " + forDelete + ")";
			string sqlString = "DELETE FROM customer WHERE (customerId = " + forDelete + ")";
			MySqlCommand cmd1 = new MySqlCommand(sqlString1, con);
			MySqlCommand cmd = new MySqlCommand(sqlString, con);

			cmd.ExecuteNonQuery();
			cmd1.ExecuteNonQuery();
			con.Close();


			string connectionString1 = ConfigurationManager.ConnectionStrings["MyMySqlKey"].ConnectionString;
			MySqlConnection con2 = new MySqlConnection(connectionString);

			con.Open();
			string sqlString2 = "SELECT customerName, address, address2, city, country, phone FROM client_schedule.customer Left join client_schedule.address on customer.addressID = address.addressId Left join client_schedule.city on address.cityId = city.cityId Left join client_schedule.country on city.countryId = country.countryId; ";


			MySqlCommand cmd2 = new MySqlCommand(sqlString2, con2);
			MySqlDataAdapter adp2 = new MySqlDataAdapter(cmd2);
			DataTable customer = new DataTable();
			adp2.Fill(customer);
			dgvCustomers.DataSource = customer;






			
        }
    }
}

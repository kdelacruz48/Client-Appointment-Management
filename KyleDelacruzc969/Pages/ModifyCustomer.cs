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
	public partial class ModifyCustomer : Form
	{
		public ModifyCustomer()
		{
			InitializeComponent();


		}
		public string name;
		public string nameCheck;
		public string address;
		public string phone;
		public string city;
		public string country;
		public int cityID;

		private void ModifyCustomer_Load(object sender, EventArgs e)   // populates the form
        {
			name = Main.CustomerIndex.Cells[0].Value + string.Empty;
			address = Main.CustomerIndex.Cells[1].Value+ string.Empty;
			city  = Main.CustomerIndex.Cells[2].Value + string.Empty;
			country = Main.CustomerIndex.Cells[3].Value + string.Empty;
			phone = Main.CustomerIndex.Cells[4].Value +string.Empty;

			textBoxName.Text = name;
			textBoxAddress.Text = address;
			textBoxPhone.Text = phone;
			textBoxCity.Text = city;
			textBoxCountry.Text = country;

			nameCheck = name;
		}

        private void buttonAdd_Click(object sender, EventArgs e) //Modify button -- modify customer in the database
        {
			sql.Help.getAddress(address);

			var modifyName = Main.IndexRow.Cells[0].Value;
			var modifyAddress = Main.IndexRow.Cells[1].Value;
			var modifyId = Main.IndexRow.Cells[5].Value.ToString();
			var modifyCheck = Main.IndexRow.Cells[5].Value;

			name = textBoxName.Text;
			address = textBoxAddress.Text; 
			phone = textBoxPhone.Text;
			city = textBoxCity.Text;
			country = textBoxCountry.Text;

			

			//if (city == "New York" )
			//{
			//	cityID = 1;
			//}
			//else if (city == "Los Angeles" )
			//{
			//	cityID = 2;
			//}
			//else if (city == "Toronto")
			//{
			//	cityID = 3;
			//}
			//else if (city == "Vancouver")
			//{
			//	cityID = 4;
			//}
			//else
			//{
			//	cityID = 5;
			//}


			bool check = Check.isNumber(phone);
			bool isCust = sql.Help.isCustomer(textBoxName.Text);
			

			if(textBoxName.Text == string.Empty)
            {
				MessageBox.Show("Please enter a name");
            }

			else if(textBoxAddress.Text == string.Empty)
			{
				MessageBox.Show("Please enter an address");
			}
			else if(textBoxPhone.Text == string.Empty || check == false)
			{
				MessageBox.Show("Please enter a valid phone number");
			}
			else if(nameCheck != textBoxName.Text && isCust == true)
            {
				MessageBox.Show("customer already exists");
            }
			else if (textBoxCity.Text == string.Empty)
            {
				MessageBox.Show("please select a city");
            }
			else if (textBoxCountry.Text == string.Empty)
            {
				MessageBox.Show("Please enter a country");
            }
			else
			{

				sql.Help.findCCForModify(modifyId);

				string connectionString = ConfigurationManager.ConnectionStrings["MyMySqlKey"].ConnectionString;
				MySqlConnection con = new MySqlConnection(connectionString);

				con.Open();



				string sqlStringAddress = "UPDATE  address  SET address ='" + address + "', cityID ='" + sql.Help.CityId + "',phone ='" + phone + "' WHERE (address = '" + modifyAddress + "')";

				string sqlString = "UPDATE customer SET customerName ='" + name + "' WHERE (customerName = '" + modifyName + "')";
				string sqlCity = "UPDATE city SET city ='" + city + "' WHERE (cityId = '" +sql.Help.CityId + "')";
				string sqlCountry = "UPDATE country SET country ='" + country + "'WHERE (countryId = '" + sql.Help.CountryId + "')";
				MySqlCommand cmd3 = new MySqlCommand(sqlCountry, con);
				MySqlCommand cmd2 = new MySqlCommand(sqlCity, con);
				MySqlCommand cmd = new MySqlCommand(sqlString, con);
				MySqlCommand cmd1 = new MySqlCommand(sqlStringAddress, con);
				cmd3.ExecuteNonQuery();
				cmd2.ExecuteNonQuery();
				cmd1.ExecuteNonQuery();
				cmd.ExecuteNonQuery();
				con.Close();
				this.Close();
			}
        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
			//if (comboBoxCity.Text == "New York" || comboBoxCity.Text == "Los Angeles")
			//{
			//	comboBoxCountry.Text = "US";
			//}

			//else if (comboBoxCity.Text == "Toronto" || comboBoxCity.Text == "Vancouver")
			//{
			//	comboBoxCountry.Text = "Canada";
			//}

			//else
			//{
			//	comboBoxCountry.Text = "Norway";
			//}
		}

        private void buttonCancel_Click(object sender, EventArgs e)
        {
			this.Close();
        }
    }
}

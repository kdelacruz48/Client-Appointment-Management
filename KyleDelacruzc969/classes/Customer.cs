using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KyleDelacruzc969.Pages;
using KyleDelacruzc969.sql;
using MySql.Data.MySqlClient;

namespace KyleDelacruzc969.classes
{
	class Customer
	{
		public string CustomerName { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string Country { get; set; }
		public string Phone { get; set; }


		




		public Customer(string CustomerName, string Address, string City, string Country, string Phone)
		{
			this.CustomerName = CustomerName;
			this.Address = Address;
			this.City = City;
			this.Country = Country;
			this.Phone = Phone;
		}
		
		public static void AddCustomer(Customer customer)
		{
			var address = customer.Address;
			var cityID = customer.City;
			var phone = customer.Phone;
			int city;


			Main.addressCount = 1;
			Help.getAddressID();


			if (cityID == "New York" || cityID == "Los Angeles")
			{
				city = 1;
			}
			else if (cityID == "Toronto" || cityID == "Vancouver")
			{
				city = 2;
			}
			else
			{
				city = 3;
			}
			

			string connectionString = ConfigurationManager.ConnectionStrings["MyMySqlKey"].ConnectionString;               
			MySqlConnection con = new MySqlConnection(connectionString);
			                                                               
			con.Open();
			
			string sqlStringAddress = "INSERT INTO address  VALUES('" + Main.addressCount + "','" + address + "','" + "" + "','" + city + "','" + 11111 + "','" + phone + "','" + "2019-01-01 00:00:00" + "','" + null + "','" + "2019-01-01 00:00:00" + "','" + null + "' )";
			string sqlString = "INSERT INTO customer  VALUES('" + Main.addressCount + "','" + customer.CustomerName + "','" + Main.addressCount + "','" + 1 + "','" + "2019-01-01 00:00:00" + "','" + null + "','" + "2019-01-01 00:00:00" + "','" + null + "' )";
			MySqlCommand cmd = new MySqlCommand(sqlString, con);
			MySqlCommand cmd1 = new MySqlCommand(sqlStringAddress, con);
			cmd1.ExecuteNonQuery();
			cmd.ExecuteNonQuery();
			con.Close();
			
			Main.customerCount++;
			Main.addressCount++;
			

		}
	}
}

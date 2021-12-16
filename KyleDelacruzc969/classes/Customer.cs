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

        public static void AddCustomer(Customer customer)  // add customer to database
        {
            var address = customer.Address;
            var cityID = customer.City;
            var phone = customer.Phone;
            var country = customer.Country;


            if (Main.addressCount == 1)
            {

                Help.getAddressID();
            }

            //if (cityID == "New York" || cityID == "Los Angeles")
            //{
            //	city = 1;
            //}
            //else if (cityID == "Toronto" || cityID == "Vancouver")
            //{
            //	city = 2;
            //}
            //else
            //{
            //	city = 3;
            //}
            var cityTemp = sql.Help.findLastCity();

            string connectionString = ConfigurationManager.ConnectionStrings["MyMySqlKey"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connectionString);

            con.Open();

            string sqlStringAddress = "INSERT INTO address  VALUES('" + Main.addressCount + "','" + address + "','" + "" + "','" + cityTemp + "','" + 11111 + "','" + phone + "','" + "2019-01-01 00:00:00" + "','" + null + "','" + "2019-01-01 00:00:00" + "','" + null + "' )";
            string sqlString = "INSERT INTO customer  VALUES('" + Main.addressCount + "','" + customer.CustomerName + "','" + Main.addressCount + "','" + 1 + "','" + "2019-01-01 00:00:00" + "','" + null + "','" + "2019-01-01 00:00:00" + "','" + null + "' )";
            string sqlCity = "INSERT INTO city VALUES ('" + cityTemp + "','" + cityID + "','" + cityTemp + "','" + "2019-01-01 00:00:00" + "','" + null + "','" + "2019-01-01 00:00:00" + "','" + null + "' )";
            string sqlCountry = "INSERT INTO country VALUES ('" + cityTemp + "','" + country + "','" + "2019-01-01 00:00:00" + "','" + null + "','" + "2019-01-01 00:00:00" + "','" + null + "' )";
            MySqlCommand cmd = new MySqlCommand(sqlString, con);
            MySqlCommand cmd1 = new MySqlCommand(sqlStringAddress, con);
            MySqlCommand cmd2 = new MySqlCommand(sqlCity, con);
            MySqlCommand cmd3 = new MySqlCommand(sqlCountry, con);

            cmd3.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            cmd.ExecuteNonQuery();


            con.Close();

            Main.customerCount++;
            Main.addressCount++;


        }


    }
}

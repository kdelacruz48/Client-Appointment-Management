﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KyleDelacruzc969.Pages;
using MySql.Data.MySqlClient;

namespace KyleDelacruzc969.sql
{
	class Help
	{

		public static void getAddressID()
		{
			string connectionString = ConfigurationManager.ConnectionStrings["MyMySqlKey"].ConnectionString;
			MySqlConnection con = new MySqlConnection(connectionString);

			con.Open();
			string sqlString = "SELECT * FROM address";
			MySqlCommand cmd = new MySqlCommand(sqlString, con);
			MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
			DataTable address = new DataTable();

			adp.Fill(address);
			con.Close();

			foreach (DataRow row in address.Rows)
			{
				Main.addressCount++;
			}

		}
		
		
	}
}
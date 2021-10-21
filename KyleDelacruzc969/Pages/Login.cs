﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KyleDelacruzc969.Pages
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
			string connectionString = ConfigurationManager.ConnectionStrings["MyMySqlKey"].ConnectionString;
			MySqlConnection con = new MySqlConnection(connectionString);

			con.Open();
			string sqlString = "SELECT * From User";
			MySqlCommand cmd = new MySqlCommand(sqlString, con);    //this will not stay here, and delete dgv just for testing
			MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			adp.Fill(dt);
			dataGridView1.DataSource = dt;
		}

		public static bool IsUser = false;
		public static bool IsEnglish = true;

		private void buttonLogin_Click(object sender, EventArgs e)
		{

			var region = RegionInfo.CurrentRegion.TwoLetterISORegionName;
			
			if (IsUser == true)
			{

				Main M1 = new Main();
				M1.Show();


			}

			else if (IsUser == false && region != "US" )
			{
				MessageBox.Show("falsch Anmeldeinformation en");
			}

			else
			{
				MessageBox.Show("Invalid login");
			}
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void Login_Load(object sender, EventArgs e)
		{
			var region = RegionInfo.CurrentRegion.TwoLetterISORegionName;
			

			
			if (region != "US") //switches language to German if region selected if not US
			{
				labelUserName.Text = "Nutzername";
				labelPassword.Text = "Passwort";
				buttonLogin.Text = "Einloggen";
				buttonExit.Text = "Ausgang";
				labelLogIn.Text = "Einloggen";
				this.Text = "Einloggen";
			}
			

		}
	}
}
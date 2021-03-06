using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
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
		
		}

		public static bool IsUser = false;
		public static bool IsEnglish = true;
		public static string userName;
		public static string password;
		public static int userID;
		public bool hasAppointment;
		private void buttonLogin_Click(object sender, EventArgs e)
		{
			
		


			List<string> list = new List<string>();
			var region = RegionInfo.CurrentRegion.TwoLetterISORegionName;

			string connectionString = ConfigurationManager.ConnectionStrings["MyMySqlKey"].ConnectionString;
			MySqlConnection con = new MySqlConnection(connectionString);

			con.Open();
			string sqlString = "SELECT * From User";                       //search database for user and password
			MySqlCommand cmd = new MySqlCommand(sqlString, con);    
			MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			adp.Fill(dt);


			foreach (DataRow row in dt.Rows)
			{
				foreach (DataColumn column in dt.Columns)
				{

					var temp = row[column].ToString();
					list.Add(temp);

					
				}
			}

			foreach (var l in list)
			{
				if (l == textBoxUserName.Text)
				{
					userName = l;
				}

				if (l == textBoxPassword.Text)
				{
					password = l;
				}

				
			}


			if (userName == textBoxUserName.Text && password == textBoxPassword.Text)   // check if correct username and password
			{

				Main M1 = new Main();


				if (textBoxUserName.Text == "test")
				{
					userID = 1;
					hasAppointment = sql.Help.hasAppIn15(userID);              // check for appointment in next 15

					if (hasAppointment == true)
					{

						MessageBox.Show("You have an appointment in the next 15 minutes");

					}

				}
				else
				{
					userID = 2;
					hasAppointment = sql.Help.hasAppIn15(userID);

					if (hasAppointment == true)
					{
						MessageBox.Show("You have an appointment in the next 15 minutes");

					}
				}

				try          //write login info to txt file
				{
					var time = DateTime.Now.ToLocalTime();
					using (StreamWriter login = new StreamWriter("C:\\Users\\LabUser\\source\\repos\\KyleDelacruzc969\\LoginTracker.txt", true))
					{
						login.WriteLine("user " + userID +" logged in at " + time + ".");
					}
				}

				catch (DirectoryNotFoundException)
				{
					MessageBox.Show("Not Found");
				}

				M1.Show();

			}

			else if (IsUser == false && region != "US")   // input validation for different region login
			{
				MessageBox.Show("falsch Anmeldeinformation en");

				try
				{
					var time = DateTime.Now.ToLocalTime();                  //txt file for login
					using (StreamWriter login = new StreamWriter("LoginTracker.txt", true))
					{
						login.WriteLine("failed login at " + time + ".");
					}
				}

				catch (DirectoryNotFoundException)
				{
					MessageBox.Show("Not Found");  //not sure why you guys are getting this message, it has never popped up on my end
				}
			}

			else if (IsUser == false && region == "US")
			{
				MessageBox.Show("Invalid login");
				try
				{
					var time = DateTime.Now.ToLocalTime();
					using (StreamWriter login = new StreamWriter("C:\\Users\\LabUser\\source\\repos\\KyleDelacruzc969\\LoginTracker.txt", true))
					{
						login.WriteLine("failed login at " + time + ".");
					}
				}

				catch (DirectoryNotFoundException)
				{
					MessageBox.Show("Not Found");
				}
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
			

			
			if (region != "US") //switches language to German if region selected is not US
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

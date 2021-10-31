using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KyleDelacruzc969.classes;

namespace KyleDelacruzc969.Pages
{
	public partial class AddCustomer : Form
	{
		public AddCustomer()
		{
			InitializeComponent();
		}

		string name1;
		string address1;
		string city1;
		string country1;
		string phone1;

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			name1 = textBoxName.Text;
			address1 = textBoxAddress.Text;
			city1 = comboBoxCity.Text;
			country1 = comboBoxCountry.Text;
			phone1 = textBoxPhone.Text;

			bool check = Check.isNumber(phone1);
			bool isCust = sql.Help.isCustomer(name1);

			if (textBoxName.Text == string.Empty)
			{
				MessageBox.Show("Please enter a name");
			}

			else if (textBoxAddress.Text == string.Empty)
			{
				MessageBox.Show("Please enter an address");
			}
			else if (textBoxPhone.Text == string.Empty || check == false)
			{
				MessageBox.Show("Please enter a valid phone number");
			}
			else if(comboBoxCity.Text == string.Empty)
            {
				MessageBox.Show("please enter a city");
            }

			
			else if (isCust == true)
			{
				MessageBox.Show("cannot create duplicate customer");
			}
			else
			{
				Customer customer = new Customer(name1, address1, city1, country1, phone1);

				Customer.AddCustomer(customer);

				Close();
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBoxCity.Text == "New York" || comboBoxCity.Text == "Los Angeles")
			{
				comboBoxCountry.Text = "US";
			}

			else if (comboBoxCity.Text == "Toronto" || comboBoxCity.Text == "Vancouver")
			{
				comboBoxCountry.Text = "Canada";
			}

			else 
			{
				comboBoxCountry.Text = "Norway";
			}
		}

        private void labelAdd_Click(object sender, EventArgs e)
        {

        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}

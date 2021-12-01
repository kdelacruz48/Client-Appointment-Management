
namespace KyleDelacruzc969.Pages
{
	partial class Main
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.AppointmentsLabel = new System.Windows.Forms.Label();
            this.CustomersLabel = new System.Windows.Forms.Label();
            this.dgvAppointment = new System.Windows.Forms.DataGridView();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.buttonMonth = new System.Windows.Forms.Button();
            this.buttonReports = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonAddA = new System.Windows.Forms.Button();
            this.buttonModifyA = new System.Windows.Forms.Button();
            this.buttonDeleteA = new System.Windows.Forms.Button();
            this.buttonAddC = new System.Windows.Forms.Button();
            this.buttonModifyC = new System.Windows.Forms.Button();
            this.buttonDeleteC = new System.Windows.Forms.Button();
            this.buttonAll = new System.Windows.Forms.Button();
            this.buttonWeekly = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelx = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // AppointmentsLabel
            // 
            this.AppointmentsLabel.AutoSize = true;
            this.AppointmentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentsLabel.Location = new System.Drawing.Point(30, 159);
            this.AppointmentsLabel.Name = "AppointmentsLabel";
            this.AppointmentsLabel.Size = new System.Drawing.Size(188, 20);
            this.AppointmentsLabel.TabIndex = 0;
            this.AppointmentsLabel.Text = "Appointment Calender";
            // 
            // CustomersLabel
            // 
            this.CustomersLabel.AutoSize = true;
            this.CustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersLabel.Location = new System.Drawing.Point(30, 389);
            this.CustomersLabel.Name = "CustomersLabel";
            this.CustomersLabel.Size = new System.Drawing.Size(95, 20);
            this.CustomersLabel.TabIndex = 1;
            this.CustomersLabel.Text = "Customers";
            // 
            // dgvAppointment
            // 
            this.dgvAppointment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointment.Location = new System.Drawing.Point(23, 182);
            this.dgvAppointment.MultiSelect = false;
            this.dgvAppointment.Name = "dgvAppointment";
            this.dgvAppointment.ReadOnly = true;
            this.dgvAppointment.RowHeadersVisible = false;
            this.dgvAppointment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointment.Size = new System.Drawing.Size(743, 182);
            this.dgvAppointment.TabIndex = 2;
            this.dgvAppointment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointment_CellContentClick);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(23, 415);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(625, 152);
            this.dgvCustomers.TabIndex = 3;
            // 
            // buttonMonth
            // 
            this.buttonMonth.Location = new System.Drawing.Point(791, 311);
            this.buttonMonth.Name = "buttonMonth";
            this.buttonMonth.Size = new System.Drawing.Size(103, 31);
            this.buttonMonth.TabIndex = 4;
            this.buttonMonth.Text = "Month";
            this.buttonMonth.UseVisualStyleBackColor = true;
            this.buttonMonth.Click += new System.EventHandler(this.buttonMonth_Click);
            // 
            // buttonReports
            // 
            this.buttonReports.Location = new System.Drawing.Point(734, 415);
            this.buttonReports.Name = "buttonReports";
            this.buttonReports.Size = new System.Drawing.Size(160, 51);
            this.buttonReports.TabIndex = 5;
            this.buttonReports.Text = "Reports";
            this.buttonReports.UseVisualStyleBackColor = true;
            this.buttonReports.Click += new System.EventHandler(this.buttonReports_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(734, 512);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(160, 55);
            this.buttonLogOut.TabIndex = 6;
            this.buttonLogOut.Text = "Switch User";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonAddA
            // 
            this.buttonAddA.Location = new System.Drawing.Point(244, 370);
            this.buttonAddA.Name = "buttonAddA";
            this.buttonAddA.Size = new System.Drawing.Size(75, 39);
            this.buttonAddA.TabIndex = 7;
            this.buttonAddA.Text = "Add";
            this.buttonAddA.UseVisualStyleBackColor = true;
            this.buttonAddA.Click += new System.EventHandler(this.buttonAddA_Click);
            // 
            // buttonModifyA
            // 
            this.buttonModifyA.Location = new System.Drawing.Point(335, 370);
            this.buttonModifyA.Name = "buttonModifyA";
            this.buttonModifyA.Size = new System.Drawing.Size(75, 39);
            this.buttonModifyA.TabIndex = 8;
            this.buttonModifyA.Text = "Modify";
            this.buttonModifyA.UseVisualStyleBackColor = true;
            this.buttonModifyA.Click += new System.EventHandler(this.buttonModifyA_Click);
            // 
            // buttonDeleteA
            // 
            this.buttonDeleteA.Location = new System.Drawing.Point(428, 370);
            this.buttonDeleteA.Name = "buttonDeleteA";
            this.buttonDeleteA.Size = new System.Drawing.Size(75, 39);
            this.buttonDeleteA.TabIndex = 9;
            this.buttonDeleteA.Text = "Delete";
            this.buttonDeleteA.UseVisualStyleBackColor = true;
            this.buttonDeleteA.Click += new System.EventHandler(this.buttonDeleteA_Click);
            // 
            // buttonAddC
            // 
            this.buttonAddC.Location = new System.Drawing.Point(244, 573);
            this.buttonAddC.Name = "buttonAddC";
            this.buttonAddC.Size = new System.Drawing.Size(75, 39);
            this.buttonAddC.TabIndex = 10;
            this.buttonAddC.Text = "Add";
            this.buttonAddC.UseVisualStyleBackColor = true;
            this.buttonAddC.Click += new System.EventHandler(this.buttonAddC_Click);
            // 
            // buttonModifyC
            // 
            this.buttonModifyC.Location = new System.Drawing.Point(335, 573);
            this.buttonModifyC.Name = "buttonModifyC";
            this.buttonModifyC.Size = new System.Drawing.Size(75, 39);
            this.buttonModifyC.TabIndex = 11;
            this.buttonModifyC.Text = "Modify";
            this.buttonModifyC.UseVisualStyleBackColor = true;
            this.buttonModifyC.Click += new System.EventHandler(this.buttonModifyC_Click);
            // 
            // buttonDeleteC
            // 
            this.buttonDeleteC.Location = new System.Drawing.Point(428, 573);
            this.buttonDeleteC.Name = "buttonDeleteC";
            this.buttonDeleteC.Size = new System.Drawing.Size(75, 39);
            this.buttonDeleteC.TabIndex = 12;
            this.buttonDeleteC.Text = "Delete";
            this.buttonDeleteC.UseVisualStyleBackColor = true;
            this.buttonDeleteC.Click += new System.EventHandler(this.buttonDeleteC_Click);
            // 
            // buttonAll
            // 
            this.buttonAll.Location = new System.Drawing.Point(791, 209);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(103, 31);
            this.buttonAll.TabIndex = 13;
            this.buttonAll.Text = "All";
            this.buttonAll.UseVisualStyleBackColor = true;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // buttonWeekly
            // 
            this.buttonWeekly.Location = new System.Drawing.Point(791, 260);
            this.buttonWeekly.Name = "buttonWeekly";
            this.buttonWeekly.Size = new System.Drawing.Size(103, 31);
            this.buttonWeekly.TabIndex = 14;
            this.buttonWeekly.Text = "Week";
            this.buttonWeekly.UseVisualStyleBackColor = true;
            this.buttonWeekly.Click += new System.EventHandler(this.buttonWeekly_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(791, 60);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(103, 39);
            this.buttonSearch.TabIndex = 15;
            this.buttonSearch.Text = "Search Appointment";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(772, 34);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(147, 20);
            this.textBoxSearch.TabIndex = 16;
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Location = new System.Drawing.Point(23, 28);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.ReadOnly = true;
            this.dataGridViewSearch.Size = new System.Drawing.Size(743, 128);
            this.dataGridViewSearch.TabIndex = 17;
            this.dataGridViewSearch.SelectionChanged += new System.EventHandler(this.dataGridViewSearch_SelectionChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(30, 5);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(173, 20);
            this.labelSearch.TabIndex = 18;
            this.labelSearch.Text = "Appointment Search";
            // 
            // labelx
            // 
            this.labelx.AutoSize = true;
            this.labelx.Location = new System.Drawing.Point(219, 10);
            this.labelx.Name = "labelx";
            this.labelx.Size = new System.Drawing.Size(170, 13);
            this.labelx.TabIndex = 19;
            this.labelx.Text = "(will show upcoming presentations)";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 624);
            this.Controls.Add(this.labelx);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.dataGridViewSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonWeekly);
            this.Controls.Add(this.buttonAll);
            this.Controls.Add(this.buttonDeleteC);
            this.Controls.Add(this.buttonModifyC);
            this.Controls.Add(this.buttonAddC);
            this.Controls.Add(this.buttonDeleteA);
            this.Controls.Add(this.buttonModifyA);
            this.Controls.Add(this.buttonAddA);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonReports);
            this.Controls.Add(this.buttonMonth);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.dgvAppointment);
            this.Controls.Add(this.CustomersLabel);
            this.Controls.Add(this.AppointmentsLabel);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label AppointmentsLabel;
		private System.Windows.Forms.Label CustomersLabel;
		private System.Windows.Forms.Button buttonMonth;
		private System.Windows.Forms.Button buttonReports;
		private System.Windows.Forms.Button buttonLogOut;
		private System.Windows.Forms.Button buttonAddA;
		private System.Windows.Forms.Button buttonModifyA;
		private System.Windows.Forms.Button buttonDeleteA;
		private System.Windows.Forms.Button buttonAddC;
		private System.Windows.Forms.Button buttonModifyC;
		private System.Windows.Forms.Button buttonDeleteC;
        public System.Windows.Forms.DataGridView dgvCustomers;
        public System.Windows.Forms.DataGridView dgvAppointment;
        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.Button buttonWeekly;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridView dataGridViewSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelx;
    }
}

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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.buttonCalender = new System.Windows.Forms.Button();
            this.buttonReports = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonAddA = new System.Windows.Forms.Button();
            this.buttonModifyA = new System.Windows.Forms.Button();
            this.buttonDeleteA = new System.Windows.Forms.Button();
            this.buttonAddC = new System.Windows.Forms.Button();
            this.buttonModifyC = new System.Windows.Forms.Button();
            this.buttonDeleteC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // AppointmentsLabel
            // 
            this.AppointmentsLabel.AutoSize = true;
            this.AppointmentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentsLabel.Location = new System.Drawing.Point(30, 9);
            this.AppointmentsLabel.Name = "AppointmentsLabel";
            this.AppointmentsLabel.Size = new System.Drawing.Size(120, 20);
            this.AppointmentsLabel.TabIndex = 0;
            this.AppointmentsLabel.Text = "Appointments";
            // 
            // CustomersLabel
            // 
            this.CustomersLabel.AutoSize = true;
            this.CustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersLabel.Location = new System.Drawing.Point(30, 251);
            this.CustomersLabel.Name = "CustomersLabel";
            this.CustomersLabel.Size = new System.Drawing.Size(95, 20);
            this.CustomersLabel.TabIndex = 1;
            this.CustomersLabel.Text = "Customers";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(735, 190);
            this.dataGridView1.TabIndex = 2;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(23, 274);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(599, 173);
            this.dgvCustomers.TabIndex = 3;
            // 
            // buttonCalender
            // 
            this.buttonCalender.Location = new System.Drawing.Point(628, 274);
            this.buttonCalender.Name = "buttonCalender";
            this.buttonCalender.Size = new System.Drawing.Size(160, 46);
            this.buttonCalender.TabIndex = 4;
            this.buttonCalender.Text = "Calender";
            this.buttonCalender.UseVisualStyleBackColor = true;
            // 
            // buttonReports
            // 
            this.buttonReports.Location = new System.Drawing.Point(628, 339);
            this.buttonReports.Name = "buttonReports";
            this.buttonReports.Size = new System.Drawing.Size(160, 46);
            this.buttonReports.TabIndex = 5;
            this.buttonReports.Text = "Reports";
            this.buttonReports.UseVisualStyleBackColor = true;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(628, 401);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(160, 46);
            this.buttonLogOut.TabIndex = 6;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonAddA
            // 
            this.buttonAddA.Location = new System.Drawing.Point(244, 228);
            this.buttonAddA.Name = "buttonAddA";
            this.buttonAddA.Size = new System.Drawing.Size(75, 39);
            this.buttonAddA.TabIndex = 7;
            this.buttonAddA.Text = "Add";
            this.buttonAddA.UseVisualStyleBackColor = true;
            // 
            // buttonModifyA
            // 
            this.buttonModifyA.Location = new System.Drawing.Point(335, 228);
            this.buttonModifyA.Name = "buttonModifyA";
            this.buttonModifyA.Size = new System.Drawing.Size(75, 39);
            this.buttonModifyA.TabIndex = 8;
            this.buttonModifyA.Text = "Modify";
            this.buttonModifyA.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteA
            // 
            this.buttonDeleteA.Location = new System.Drawing.Point(428, 228);
            this.buttonDeleteA.Name = "buttonDeleteA";
            this.buttonDeleteA.Size = new System.Drawing.Size(75, 39);
            this.buttonDeleteA.TabIndex = 9;
            this.buttonDeleteA.Text = "Delete";
            this.buttonDeleteA.UseVisualStyleBackColor = true;
            // 
            // buttonAddC
            // 
            this.buttonAddC.Location = new System.Drawing.Point(244, 453);
            this.buttonAddC.Name = "buttonAddC";
            this.buttonAddC.Size = new System.Drawing.Size(75, 39);
            this.buttonAddC.TabIndex = 10;
            this.buttonAddC.Text = "Add";
            this.buttonAddC.UseVisualStyleBackColor = true;
            this.buttonAddC.Click += new System.EventHandler(this.buttonAddC_Click);
            // 
            // buttonModifyC
            // 
            this.buttonModifyC.Location = new System.Drawing.Point(335, 453);
            this.buttonModifyC.Name = "buttonModifyC";
            this.buttonModifyC.Size = new System.Drawing.Size(75, 39);
            this.buttonModifyC.TabIndex = 11;
            this.buttonModifyC.Text = "Modify";
            this.buttonModifyC.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteC
            // 
            this.buttonDeleteC.Location = new System.Drawing.Point(428, 453);
            this.buttonDeleteC.Name = "buttonDeleteC";
            this.buttonDeleteC.Size = new System.Drawing.Size(75, 39);
            this.buttonDeleteC.TabIndex = 12;
            this.buttonDeleteC.Text = "Delete";
            this.buttonDeleteC.UseVisualStyleBackColor = true;
            this.buttonDeleteC.Click += new System.EventHandler(this.buttonDeleteC_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.buttonDeleteC);
            this.Controls.Add(this.buttonModifyC);
            this.Controls.Add(this.buttonAddC);
            this.Controls.Add(this.buttonDeleteA);
            this.Controls.Add(this.buttonModifyA);
            this.Controls.Add(this.buttonAddA);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonReports);
            this.Controls.Add(this.buttonCalender);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CustomersLabel);
            this.Controls.Add(this.AppointmentsLabel);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label AppointmentsLabel;
		private System.Windows.Forms.Label CustomersLabel;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridView dgvCustomers;
		private System.Windows.Forms.Button buttonCalender;
		private System.Windows.Forms.Button buttonReports;
		private System.Windows.Forms.Button buttonLogOut;
		private System.Windows.Forms.Button buttonAddA;
		private System.Windows.Forms.Button buttonModifyA;
		private System.Windows.Forms.Button buttonDeleteA;
		private System.Windows.Forms.Button buttonAddC;
		private System.Windows.Forms.Button buttonModifyC;
		private System.Windows.Forms.Button buttonDeleteC;
	}
}
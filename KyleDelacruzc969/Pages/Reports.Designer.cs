
namespace KyleDelacruzc969.Pages
{
	partial class Reports
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
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.radioButtonType = new System.Windows.Forms.RadioButton();
            this.labelReports = new System.Windows.Forms.Label();
            this.radioButtonSchedule = new System.Windows.Forms.RadioButton();
            this.radioButtonPhone = new System.Windows.Forms.RadioButton();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.labelUserId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReports
            // 
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Location = new System.Drawing.Point(46, 121);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.Size = new System.Drawing.Size(710, 251);
            this.dgvReports.TabIndex = 0;
            // 
            // radioButtonType
            // 
            this.radioButtonType.AutoSize = true;
            this.radioButtonType.Location = new System.Drawing.Point(58, 77);
            this.radioButtonType.Name = "radioButtonType";
            this.radioButtonType.Size = new System.Drawing.Size(96, 17);
            this.radioButtonType.TabIndex = 1;
            this.radioButtonType.TabStop = true;
            this.radioButtonType.Text = "Type by Month";
            this.radioButtonType.UseVisualStyleBackColor = true;
            this.radioButtonType.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // labelReports
            // 
            this.labelReports.AutoSize = true;
            this.labelReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReports.Location = new System.Drawing.Point(42, 32);
            this.labelReports.Name = "labelReports";
            this.labelReports.Size = new System.Drawing.Size(73, 20);
            this.labelReports.TabIndex = 2;
            this.labelReports.Text = "Reports";
            this.labelReports.Click += new System.EventHandler(this.labelReports_Click);
            // 
            // radioButtonSchedule
            // 
            this.radioButtonSchedule.AutoSize = true;
            this.radioButtonSchedule.Location = new System.Drawing.Point(230, 77);
            this.radioButtonSchedule.Name = "radioButtonSchedule";
            this.radioButtonSchedule.Size = new System.Drawing.Size(70, 17);
            this.radioButtonSchedule.TabIndex = 3;
            this.radioButtonSchedule.TabStop = true;
            this.radioButtonSchedule.Text = "Schedule";
            this.radioButtonSchedule.UseVisualStyleBackColor = true;
            this.radioButtonSchedule.CheckedChanged += new System.EventHandler(this.radioButtonSchedule_CheckedChanged);
            // 
            // radioButtonPhone
            // 
            this.radioButtonPhone.AutoSize = true;
            this.radioButtonPhone.Location = new System.Drawing.Point(416, 77);
            this.radioButtonPhone.Name = "radioButtonPhone";
            this.radioButtonPhone.Size = new System.Drawing.Size(103, 17);
            this.radioButtonPhone.TabIndex = 4;
            this.radioButtonPhone.TabStop = true;
            this.radioButtonPhone.Text = "Customer Phone";
            this.radioButtonPhone.UseVisualStyleBackColor = true;
            this.radioButtonPhone.CheckedChanged += new System.EventHandler(this.radioButtonPhone_CheckedChanged);
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(529, 389);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(111, 38);
            this.buttonShow.TabIndex = 5;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(646, 390);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(110, 37);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Consultaion",
            "Review",
            "Final",
            "Presentation",
            "Scrum"});
            this.comboBox1.Location = new System.Drawing.Point(46, 399);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.comboBox2.Location = new System.Drawing.Point(179, 399);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(43, 383);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(31, 13);
            this.labelType.TabIndex = 9;
            this.labelType.Text = "Type";
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Location = new System.Drawing.Point(176, 383);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(37, 13);
            this.labelMonth.TabIndex = 10;
            this.labelMonth.Text = "Month";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox3.Location = new System.Drawing.Point(306, 399);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 11;
            // 
            // labelUserId
            // 
            this.labelUserId.AutoSize = true;
            this.labelUserId.Location = new System.Drawing.Point(303, 383);
            this.labelUserId.Name = "labelUserId";
            this.labelUserId.Size = new System.Drawing.Size(41, 13);
            this.labelUserId.TabIndex = 12;
            this.labelUserId.Text = "User Id";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelUserId);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.radioButtonPhone);
            this.Controls.Add(this.radioButtonSchedule);
            this.Controls.Add(this.labelReports);
            this.Controls.Add(this.radioButtonType);
            this.Controls.Add(this.dgvReports);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvReports;
		private System.Windows.Forms.RadioButton radioButtonType;
		private System.Windows.Forms.Label labelReports;
		private System.Windows.Forms.RadioButton radioButtonSchedule;
		private System.Windows.Forms.RadioButton radioButtonPhone;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label labelUserId;
    }
}
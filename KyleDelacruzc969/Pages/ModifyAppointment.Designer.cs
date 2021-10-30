
namespace KyleDelacruzc969.Pages
{
	partial class ModifyAppointment
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
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.textBoxEnd = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelAppoinmentType = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelModify = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "30 min appointment";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(168, 160);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker2.TabIndex = 33;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(168, 132);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(106, 138);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(30, 13);
            this.labelDate.TabIndex = 31;
            this.labelDate.Text = "Date";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Consultation",
            "Review",
            "Final"});
            this.comboBoxType.Location = new System.Drawing.Point(168, 102);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(100, 21);
            this.comboBoxType.TabIndex = 30;
            // 
            // comboBoxName
            // 
            this.comboBoxName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(168, 66);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(100, 21);
            this.comboBoxName.TabIndex = 29;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(193, 272);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 28;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(108, 272);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(75, 23);
            this.buttonModify.TabIndex = 27;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Location = new System.Drawing.Point(168, 227);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.ReadOnly = true;
            this.textBoxUserID.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserID.TabIndex = 26;
            // 
            // textBoxEnd
            // 
            this.textBoxEnd.Location = new System.Drawing.Point(168, 196);
            this.textBoxEnd.Name = "textBoxEnd";
            this.textBoxEnd.Size = new System.Drawing.Size(100, 20);
            this.textBoxEnd.TabIndex = 25;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(99, 230);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(43, 13);
            this.labelID.TabIndex = 24;
            this.labelID.Text = "User ID";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(105, 199);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(26, 13);
            this.labelEnd.TabIndex = 23;
            this.labelEnd.Text = "End";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(105, 166);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(29, 13);
            this.labelStart.TabIndex = 22;
            this.labelStart.Text = "Start";
            // 
            // labelAppoinmentType
            // 
            this.labelAppoinmentType.AutoSize = true;
            this.labelAppoinmentType.Location = new System.Drawing.Point(105, 105);
            this.labelAppoinmentType.Name = "labelAppoinmentType";
            this.labelAppoinmentType.Size = new System.Drawing.Size(31, 13);
            this.labelAppoinmentType.TabIndex = 21;
            this.labelAppoinmentType.Text = "Type";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(80, 69);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(82, 13);
            this.labelName.TabIndex = 20;
            this.labelName.Text = "Customer Name";
            // 
            // labelModify
            // 
            this.labelModify.AutoSize = true;
            this.labelModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModify.Location = new System.Drawing.Point(39, 26);
            this.labelModify.Name = "labelModify";
            this.labelModify.Size = new System.Drawing.Size(168, 20);
            this.labelModify.TabIndex = 19;
            this.labelModify.Text = "Modify Appointment";
            // 
            // ModifyAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 310);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.comboBoxName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.textBoxUserID);
            this.Controls.Add(this.textBoxEnd);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.labelAppoinmentType);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelModify);
            this.Name = "ModifyAppointment";
            this.Text = "ModifyAppointment";
            this.Load += new System.EventHandler(this.ModifyAppointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.TextBox textBoxEnd;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelAppoinmentType;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelModify;
    }
}
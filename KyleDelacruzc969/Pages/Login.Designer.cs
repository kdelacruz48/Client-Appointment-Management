
namespace KyleDelacruzc969.Pages
{
	partial class Login
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
			this.textBoxUserName = new System.Windows.Forms.TextBox();
			this.labelUserName = new System.Windows.Forms.Label();
			this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
			this.labelPassword = new System.Windows.Forms.Label();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.labelLanguage = new System.Windows.Forms.Label();
			this.labelLogIn = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBoxUserName
			// 
			this.textBoxUserName.Location = new System.Drawing.Point(133, 87);
			this.textBoxUserName.Name = "textBoxUserName";
			this.textBoxUserName.Size = new System.Drawing.Size(100, 20);
			this.textBoxUserName.TabIndex = 0;
			// 
			// labelUserName
			// 
			this.labelUserName.AutoSize = true;
			this.labelUserName.Location = new System.Drawing.Point(60, 90);
			this.labelUserName.Name = "labelUserName";
			this.labelUserName.Size = new System.Drawing.Size(57, 13);
			this.labelUserName.TabIndex = 1;
			this.labelUserName.Text = "UserName";
			// 
			// comboBoxLanguage
			// 
			this.comboBoxLanguage.FormattingEnabled = true;
			this.comboBoxLanguage.Items.AddRange(new object[] {
            "Language 1",
            "Language 2"});
			this.comboBoxLanguage.Location = new System.Drawing.Point(271, 46);
			this.comboBoxLanguage.Name = "comboBoxLanguage";
			this.comboBoxLanguage.Size = new System.Drawing.Size(121, 21);
			this.comboBoxLanguage.TabIndex = 2;
			// 
			// labelPassword
			// 
			this.labelPassword.AutoSize = true;
			this.labelPassword.Location = new System.Drawing.Point(60, 145);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(53, 13);
			this.labelPassword.TabIndex = 3;
			this.labelPassword.Text = "Password";
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Location = new System.Drawing.Point(133, 142);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
			this.textBoxPassword.TabIndex = 4;
			// 
			// labelLanguage
			// 
			this.labelLanguage.AutoSize = true;
			this.labelLanguage.Location = new System.Drawing.Point(308, 20);
			this.labelLanguage.Name = "labelLanguage";
			this.labelLanguage.Size = new System.Drawing.Size(55, 13);
			this.labelLanguage.TabIndex = 5;
			this.labelLanguage.Text = "Language";
			// 
			// labelLogIn
			// 
			this.labelLogIn.AutoSize = true;
			this.labelLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLogIn.Location = new System.Drawing.Point(60, 31);
			this.labelLogIn.Name = "labelLogIn";
			this.labelLogIn.Size = new System.Drawing.Size(53, 20);
			this.labelLogIn.TabIndex = 6;
			this.labelLogIn.Text = "Login";
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(413, 235);
			this.Controls.Add(this.labelLogIn);
			this.Controls.Add(this.labelLanguage);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.labelPassword);
			this.Controls.Add(this.comboBoxLanguage);
			this.Controls.Add(this.labelUserName);
			this.Controls.Add(this.textBoxUserName);
			this.Name = "Login";
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxUserName;
		private System.Windows.Forms.Label labelUserName;
		private System.Windows.Forms.ComboBox comboBoxLanguage;
		private System.Windows.Forms.Label labelPassword;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.Label labelLanguage;
		private System.Windows.Forms.Label labelLogIn;
	}
}
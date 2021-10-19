
namespace KyleDelacruzc969.Pages
{
	partial class labelCalender
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
			this.radioButtonWeek = new System.Windows.Forms.RadioButton();
			this.radioButtonMonth = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// radioButtonWeek
			// 
			this.radioButtonWeek.AutoSize = true;
			this.radioButtonWeek.Location = new System.Drawing.Point(118, 88);
			this.radioButtonWeek.Name = "radioButtonWeek";
			this.radioButtonWeek.Size = new System.Drawing.Size(54, 17);
			this.radioButtonWeek.TabIndex = 0;
			this.radioButtonWeek.TabStop = true;
			this.radioButtonWeek.Text = "Week";
			this.radioButtonWeek.UseVisualStyleBackColor = true;
			// 
			// radioButtonMonth
			// 
			this.radioButtonMonth.AutoSize = true;
			this.radioButtonMonth.Location = new System.Drawing.Point(227, 88);
			this.radioButtonMonth.Name = "radioButtonMonth";
			this.radioButtonMonth.Size = new System.Drawing.Size(55, 17);
			this.radioButtonMonth.TabIndex = 1;
			this.radioButtonMonth.TabStop = true;
			this.radioButtonMonth.Text = "Month";
			this.radioButtonMonth.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(56, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Calender";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(22, 136);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(740, 284);
			this.dataGridView1.TabIndex = 3;
			// 
			// labelCalender
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.radioButtonMonth);
			this.Controls.Add(this.radioButtonWeek);
			this.Name = "labelCalender";
			this.Text = "Calender";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton radioButtonWeek;
		private System.Windows.Forms.RadioButton radioButtonMonth;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}
namespace CMP.Presentation.Forms
{
	partial class Fm_Sportsman
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
			this.btnSave = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtClub = new System.Windows.Forms.TextBox();
			this.udAge = new System.Windows.Forms.NumericUpDown();
			this.lblName = new System.Windows.Forms.Label();
			this.lblLastName = new System.Windows.Forms.Label();
			this.lblClub = new System.Windows.Forms.Label();
			this.lblAge = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.udAge)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(41, 122);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 0;
			this.btnSave.Text = "Сохранить";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(122, 122);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "Закрыть";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(97, 38);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(100, 20);
			this.txtLastName.TabIndex = 2;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(97, 12);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(100, 20);
			this.txtName.TabIndex = 2;
			// 
			// txtClub
			// 
			this.txtClub.Location = new System.Drawing.Point(97, 64);
			this.txtClub.Name = "txtClub";
			this.txtClub.Size = new System.Drawing.Size(100, 20);
			this.txtClub.TabIndex = 3;
			// 
			// udAge
			// 
			this.udAge.Location = new System.Drawing.Point(97, 90);
			this.udAge.Name = "udAge";
			this.udAge.Size = new System.Drawing.Size(41, 20);
			this.udAge.TabIndex = 4;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(13, 15);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(29, 13);
			this.lblName.TabIndex = 5;
			this.lblName.Text = "Имя";
			// 
			// lblLastName
			// 
			this.lblLastName.AutoSize = true;
			this.lblLastName.Location = new System.Drawing.Point(13, 41);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.Size = new System.Drawing.Size(56, 13);
			this.lblLastName.TabIndex = 6;
			this.lblLastName.Text = "Фамилия";
			// 
			// lblClub
			// 
			this.lblClub.AutoSize = true;
			this.lblClub.Location = new System.Drawing.Point(13, 67);
			this.lblClub.Name = "lblClub";
			this.lblClub.Size = new System.Drawing.Size(31, 13);
			this.lblClub.TabIndex = 7;
			this.lblClub.Text = "Клуб";
			// 
			// lblAge
			// 
			this.lblAge.AutoSize = true;
			this.lblAge.Location = new System.Drawing.Point(13, 92);
			this.lblAge.Name = "lblAge";
			this.lblAge.Size = new System.Drawing.Size(49, 13);
			this.lblAge.TabIndex = 8;
			this.lblAge.Text = "Возраст";
			// 
			// Fm_AddSportsman
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(210, 156);
			this.Controls.Add(this.lblAge);
			this.Controls.Add(this.lblClub);
			this.Controls.Add(this.lblLastName);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.udAge);
			this.Controls.Add(this.txtClub);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnSave);
			this.Name = "Fm_AddSportsman";
			this.Text = "Fm_AddSportsman";
			this.Load += new System.EventHandler(this.Fm_AddSportsman_Load);
			((System.ComponentModel.ISupportInitialize)(this.udAge)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtClub;
		private System.Windows.Forms.NumericUpDown udAge;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblLastName;
		private System.Windows.Forms.Label lblClub;
		private System.Windows.Forms.Label lblAge;
	}
}
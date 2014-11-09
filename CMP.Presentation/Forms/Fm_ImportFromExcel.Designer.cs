namespace CMP.Presentation.Forms
{
	partial class Fm_ImportFromExcel
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
			this.btnChooseFile = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.dgvImportSportsmen = new System.Windows.Forms.DataGridView();
			this.btnImport = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.clmLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmClub = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmCategories = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvImportSportsmen)).BeginInit();
			this.SuspendLayout();
			// 
			// btnChooseFile
			// 
			this.btnChooseFile.Location = new System.Drawing.Point(12, 12);
			this.btnChooseFile.Name = "btnChooseFile";
			this.btnChooseFile.Size = new System.Drawing.Size(102, 23);
			this.btnChooseFile.TabIndex = 0;
			this.btnChooseFile.Text = "Выбрать файл...";
			this.btnChooseFile.UseVisualStyleBackColor = true;
			this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog1";
			this.openFileDialog.Filter = "Excel Files|*.xlsx";
			// 
			// dgvImportSportsmen
			// 
			this.dgvImportSportsmen.AllowUserToAddRows = false;
			this.dgvImportSportsmen.AllowUserToDeleteRows = false;
			this.dgvImportSportsmen.AllowUserToResizeColumns = false;
			this.dgvImportSportsmen.AllowUserToResizeRows = false;
			this.dgvImportSportsmen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvImportSportsmen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmLastName,
            this.clmName,
            this.clmAge,
            this.clmClub,
            this.clmCategories});
			this.dgvImportSportsmen.Location = new System.Drawing.Point(12, 41);
			this.dgvImportSportsmen.Name = "dgvImportSportsmen";
			this.dgvImportSportsmen.RowHeadersVisible = false;
			this.dgvImportSportsmen.Size = new System.Drawing.Size(651, 311);
			this.dgvImportSportsmen.TabIndex = 1;
			// 
			// btnImport
			// 
			this.btnImport.Location = new System.Drawing.Point(120, 12);
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new System.Drawing.Size(102, 23);
			this.btnImport.TabIndex = 2;
			this.btnImport.Text = "Импорт";
			this.btnImport.UseVisualStyleBackColor = true;
			this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(561, 358);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(102, 23);
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "Закрыть";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// clmLastName
			// 
			this.clmLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.clmLastName.HeaderText = "Фамилия";
			this.clmLastName.Name = "clmLastName";
			// 
			// clmName
			// 
			this.clmName.HeaderText = "Имя";
			this.clmName.Name = "clmName";
			// 
			// clmAge
			// 
			this.clmAge.HeaderText = "Возраст";
			this.clmAge.Name = "clmAge";
			this.clmAge.Width = 60;
			// 
			// clmClub
			// 
			this.clmClub.HeaderText = "Клуб";
			this.clmClub.Name = "clmClub";
			// 
			// clmCategories
			// 
			this.clmCategories.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.clmCategories.HeaderText = "Категории";
			this.clmCategories.Name = "clmCategories";
			// 
			// Fm_ImportFromExcel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(675, 386);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnImport);
			this.Controls.Add(this.dgvImportSportsmen);
			this.Controls.Add(this.btnChooseFile);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Fm_ImportFromExcel";
			this.Text = "Импорт спортсменов";
			((System.ComponentModel.ISupportInitialize)(this.dgvImportSportsmen)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnChooseFile;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.DataGridView dgvImportSportsmen;
		private System.Windows.Forms.Button btnImport;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmLastName;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmAge;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmClub;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmCategories;
	}
}
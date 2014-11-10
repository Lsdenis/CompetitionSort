namespace CMP.Presentation.Forms
{
	partial class Fm_EditSportsmen
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
			this.dgvSportsmen = new System.Windows.Forms.DataGridView();
			this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmClub = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtSearch = new CMP.Presentation.Controls.TextBoxWithPlaceholder();
			((System.ComponentModel.ISupportInitialize)(this.dgvSportsmen)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvSportsmen
			// 
			this.dgvSportsmen.AllowUserToAddRows = false;
			this.dgvSportsmen.AllowUserToDeleteRows = false;
			this.dgvSportsmen.AllowUserToResizeColumns = false;
			this.dgvSportsmen.AllowUserToResizeRows = false;
			this.dgvSportsmen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSportsmen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmName,
            this.clmAge,
            this.clmClub});
			this.dgvSportsmen.Location = new System.Drawing.Point(12, 67);
			this.dgvSportsmen.Name = "dgvSportsmen";
			this.dgvSportsmen.ReadOnly = true;
			this.dgvSportsmen.RowHeadersVisible = false;
			this.dgvSportsmen.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvSportsmen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSportsmen.Size = new System.Drawing.Size(372, 344);
			this.dgvSportsmen.TabIndex = 0;
			this.dgvSportsmen.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSportsmen_CellDoubleClick);
			// 
			// clmName
			// 
			this.clmName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.clmName.HeaderText = "ФИО";
			this.clmName.Name = "clmName";
			this.clmName.ReadOnly = true;
			// 
			// clmAge
			// 
			this.clmAge.HeaderText = "Возраст";
			this.clmAge.Name = "clmAge";
			this.clmAge.ReadOnly = true;
			this.clmAge.Width = 60;
			// 
			// clmClub
			// 
			this.clmClub.HeaderText = "Клуб";
			this.clmClub.Name = "clmClub";
			this.clmClub.ReadOnly = true;
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(308, 417);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 2;
			this.btnClose.Text = "Закрыть";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(12, 12);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 3;
			this.btnAdd.Text = "Добавить";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(12, 41);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.OnEnterPressed = null;
			this.txtSearch.Placeholder = "Введите фамилию...";
			this.txtSearch.Size = new System.Drawing.Size(372, 20);
			this.txtSearch.TabIndex = 1;
			// 
			// Fm_EditSportsmen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(395, 452);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.dgvSportsmen);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Fm_EditSportsmen";
			this.Text = "Редактирование спортсменов";
			this.Load += new System.EventHandler(this.Fm_EditSportsmen_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvSportsmen)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvSportsmen;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmAge;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmClub;
		private Controls.TextBoxWithPlaceholder txtSearch;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnAdd;
	}
}
namespace CMP.Presentation.Forms
{
	partial class Fm_Sort
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
			this.cbCategories = new System.Windows.Forms.ComboBox();
			this.lvSportsmen = new System.Windows.Forms.ListView();
			this.clmNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clmLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clmAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clmClub = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnSort = new System.Windows.Forms.Button();
			this.btnSwap = new System.Windows.Forms.Button();
			this.btnCircleSystem = new System.Windows.Forms.Button();
			this.btnOlympicSystem = new System.Windows.Forms.Button();
			this.pcLogo = new System.Windows.Forms.PictureBox();
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.IsClubSortIncludedMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.categoriesSettingsMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
			this.sportsmenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editSportsmenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editInCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importSportsmenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.QuitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnOpen = new System.Windows.Forms.Button();
			this.bottonStatusStrip = new System.Windows.Forms.StatusStrip();
			this.txtNumberOfSportsmen = new System.Windows.Forms.ToolStripStatusLabel();
			this.pbCreatePartition = new System.Windows.Forms.ToolStripProgressBar();
			this.txtCompetitionName = new CMP.Presentation.Controls.TextBoxWithPlaceholder();
			((System.ComponentModel.ISupportInitialize)(this.pcLogo)).BeginInit();
			this.mainMenuStrip.SuspendLayout();
			this.bottonStatusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// cbCategories
			// 
			this.cbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCategories.FormattingEnabled = true;
			this.cbCategories.Location = new System.Drawing.Point(12, 53);
			this.cbCategories.Name = "cbCategories";
			this.cbCategories.Size = new System.Drawing.Size(495, 21);
			this.cbCategories.TabIndex = 0;
			this.cbCategories.SelectedIndexChanged += new System.EventHandler(this.cbCategories_SelectedIndexChanged);
			// 
			// lvSportsmen
			// 
			this.lvSportsmen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmNumber,
            this.clmLastName,
            this.clmName,
            this.clmAge,
            this.clmClub});
			this.lvSportsmen.FullRowSelect = true;
			this.lvSportsmen.Location = new System.Drawing.Point(12, 80);
			this.lvSportsmen.Name = "lvSportsmen";
			this.lvSportsmen.Size = new System.Drawing.Size(495, 288);
			this.lvSportsmen.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lvSportsmen.TabIndex = 2;
			this.lvSportsmen.UseCompatibleStateImageBehavior = false;
			this.lvSportsmen.View = System.Windows.Forms.View.Details;
			// 
			// clmNumber
			// 
			this.clmNumber.Text = "№";
			this.clmNumber.Width = 40;
			// 
			// clmLastName
			// 
			this.clmLastName.Text = "Фамилия";
			this.clmLastName.Width = 170;
			// 
			// clmName
			// 
			this.clmName.Text = "Имя";
			this.clmName.Width = 130;
			// 
			// clmAge
			// 
			this.clmAge.Text = "Возраст";
			this.clmAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// clmClub
			// 
			this.clmClub.Text = "Клуб";
			this.clmClub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.clmClub.Width = 90;
			// 
			// btnSort
			// 
			this.btnSort.Enabled = false;
			this.btnSort.Location = new System.Drawing.Point(513, 179);
			this.btnSort.Name = "btnSort";
			this.btnSort.Size = new System.Drawing.Size(100, 40);
			this.btnSort.TabIndex = 3;
			this.btnSort.Text = "Сортировка";
			this.btnSort.UseVisualStyleBackColor = true;
			this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
			// 
			// btnSwap
			// 
			this.btnSwap.Enabled = false;
			this.btnSwap.Location = new System.Drawing.Point(513, 225);
			this.btnSwap.Name = "btnSwap";
			this.btnSwap.Size = new System.Drawing.Size(100, 40);
			this.btnSwap.TabIndex = 4;
			this.btnSwap.Text = "Поменять местами";
			this.btnSwap.UseVisualStyleBackColor = true;
			this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
			// 
			// btnCircleSystem
			// 
			this.btnCircleSystem.Enabled = false;
			this.btnCircleSystem.Location = new System.Drawing.Point(513, 271);
			this.btnCircleSystem.Name = "btnCircleSystem";
			this.btnCircleSystem.Size = new System.Drawing.Size(100, 40);
			this.btnCircleSystem.TabIndex = 5;
			this.btnCircleSystem.Text = "Круговая система";
			this.btnCircleSystem.UseVisualStyleBackColor = true;
			this.btnCircleSystem.Click += new System.EventHandler(this.btnCircleSystem_Click);
			// 
			// btnOlympicSystem
			// 
			this.btnOlympicSystem.Enabled = false;
			this.btnOlympicSystem.Location = new System.Drawing.Point(513, 317);
			this.btnOlympicSystem.Name = "btnOlympicSystem";
			this.btnOlympicSystem.Size = new System.Drawing.Size(100, 40);
			this.btnOlympicSystem.TabIndex = 6;
			this.btnOlympicSystem.Text = "Олимпийская система";
			this.btnOlympicSystem.UseVisualStyleBackColor = true;
			this.btnOlympicSystem.Click += new System.EventHandler(this.btnOlympicSystem_Click);
			// 
			// pcLogo
			// 
			this.pcLogo.Location = new System.Drawing.Point(513, 27);
			this.pcLogo.Name = "pcLogo";
			this.pcLogo.Size = new System.Drawing.Size(100, 100);
			this.pcLogo.TabIndex = 7;
			this.pcLogo.TabStop = false;
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsToolStripMenuItem,
            this.sportsmenToolStripMenuItem,
            this.QuitToolStripMenuItem});
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Size = new System.Drawing.Size(622, 24);
			this.mainMenuStrip.TabIndex = 11;
			this.mainMenuStrip.Text = "menuStrip1";
			// 
			// SettingsToolStripMenuItem
			// 
			this.SettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IsClubSortIncludedMenuStrip,
            this.toolStripSeparator1,
            this.categoriesSettingsMenuStrip});
			this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
			this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
			this.SettingsToolStripMenuItem.Text = "Настройки";
			// 
			// IsClubSortIncludedMenuStrip
			// 
			this.IsClubSortIncludedMenuStrip.CheckOnClick = true;
			this.IsClubSortIncludedMenuStrip.Name = "IsClubSortIncludedMenuStrip";
			this.IsClubSortIncludedMenuStrip.Size = new System.Drawing.Size(192, 22);
			this.IsClubSortIncludedMenuStrip.Text = "Учитывать клуб";
			this.IsClubSortIncludedMenuStrip.Click += new System.EventHandler(this.IsClubSortIncludedMenuStrip_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(189, 6);
			// 
			// categoriesSettingsMenuStrip
			// 
			this.categoriesSettingsMenuStrip.Name = "categoriesSettingsMenuStrip";
			this.categoriesSettingsMenuStrip.Size = new System.Drawing.Size(192, 22);
			this.categoriesSettingsMenuStrip.Text = "Настройка категорий";
			this.categoriesSettingsMenuStrip.Click += new System.EventHandler(this.categoriesSettingsMenuStrip_Click);
			// 
			// sportsmenToolStripMenuItem
			// 
			this.sportsmenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.importSportsmenToolStripMenuItem});
			this.sportsmenToolStripMenuItem.Name = "sportsmenToolStripMenuItem";
			this.sportsmenToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
			this.sportsmenToolStripMenuItem.Text = "Спортсмены";
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editSportsmenToolStripMenuItem,
            this.editInCategoriesToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.editToolStripMenuItem.Text = "Редактирование";
			// 
			// editSportsmenToolStripMenuItem
			// 
			this.editSportsmenToolStripMenuItem.Name = "editSportsmenToolStripMenuItem";
			this.editSportsmenToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
			this.editSportsmenToolStripMenuItem.Text = "Редактирование спортсменов";
			this.editSportsmenToolStripMenuItem.Click += new System.EventHandler(this.editSportsmenToolStripMenuItem_Click);
			// 
			// editInCategoriesToolStripMenuItem
			// 
			this.editInCategoriesToolStripMenuItem.Name = "editInCategoriesToolStripMenuItem";
			this.editInCategoriesToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
			this.editInCategoriesToolStripMenuItem.Text = "Редактирование в категориях";
			// 
			// importSportsmenToolStripMenuItem
			// 
			this.importSportsmenToolStripMenuItem.Name = "importSportsmenToolStripMenuItem";
			this.importSportsmenToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.importSportsmenToolStripMenuItem.Text = "Импорт";
			this.importSportsmenToolStripMenuItem.Click += new System.EventHandler(this.importSportsmenToolStripMenuItem_Click);
			// 
			// QuitToolStripMenuItem
			// 
			this.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem";
			this.QuitToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.QuitToolStripMenuItem.Text = "Выход";
			this.QuitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point(513, 133);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(100, 40);
			this.btnOpen.TabIndex = 12;
			this.btnOpen.Text = "Открыть сетку";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// bottonStatusStrip
			// 
			this.bottonStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtNumberOfSportsmen,
            this.pbCreatePartition});
			this.bottonStatusStrip.Location = new System.Drawing.Point(0, 374);
			this.bottonStatusStrip.Name = "bottonStatusStrip";
			this.bottonStatusStrip.Size = new System.Drawing.Size(622, 22);
			this.bottonStatusStrip.TabIndex = 13;
			this.bottonStatusStrip.Text = "statusStrip1";
			// 
			// txtNumberOfSportsmen
			// 
			this.txtNumberOfSportsmen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.txtNumberOfSportsmen.Name = "txtNumberOfSportsmen";
			this.txtNumberOfSportsmen.Size = new System.Drawing.Size(505, 17);
			this.txtNumberOfSportsmen.Spring = true;
			// 
			// pbCreatePartition
			// 
			this.pbCreatePartition.AutoSize = false;
			this.pbCreatePartition.MarqueeAnimationSpeed = 0;
			this.pbCreatePartition.Name = "pbCreatePartition";
			this.pbCreatePartition.Size = new System.Drawing.Size(100, 16);
			this.pbCreatePartition.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			// 
			// txtCompetitionName
			// 
			this.txtCompetitionName.Location = new System.Drawing.Point(12, 27);
			this.txtCompetitionName.Name = "txtCompetitionName";
			this.txtCompetitionName.OnEnterPressed = null;
			this.txtCompetitionName.Placeholder = "Название соревнования...";
			this.txtCompetitionName.Size = new System.Drawing.Size(495, 20);
			this.txtCompetitionName.TabIndex = 8;
			// 
			// Fm_Sort
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(622, 396);
			this.Controls.Add(this.bottonStatusStrip);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.txtCompetitionName);
			this.Controls.Add(this.pcLogo);
			this.Controls.Add(this.btnOlympicSystem);
			this.Controls.Add(this.btnCircleSystem);
			this.Controls.Add(this.btnSwap);
			this.Controls.Add(this.btnSort);
			this.Controls.Add(this.lvSportsmen);
			this.Controls.Add(this.cbCategories);
			this.Controls.Add(this.mainMenuStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.mainMenuStrip;
			this.MaximizeBox = false;
			this.Name = "Fm_Sort";
			this.Text = "Сортировка";
			this.Load += new System.EventHandler(this.Fm_Sort_Load);
			((System.ComponentModel.ISupportInitialize)(this.pcLogo)).EndInit();
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.bottonStatusStrip.ResumeLayout(false);
			this.bottonStatusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbCategories;
		private System.Windows.Forms.ListView lvSportsmen;
		private System.Windows.Forms.Button btnSort;
		private System.Windows.Forms.Button btnSwap;
		private System.Windows.Forms.Button btnCircleSystem;
		private System.Windows.Forms.Button btnOlympicSystem;
		private System.Windows.Forms.ColumnHeader clmLastName;
		private System.Windows.Forms.ColumnHeader clmName;
		private System.Windows.Forms.ColumnHeader clmClub;
		private System.Windows.Forms.ColumnHeader clmAge;
		private System.Windows.Forms.ColumnHeader clmNumber;
		private System.Windows.Forms.PictureBox pcLogo;
		private Controls.TextBoxWithPlaceholder txtCompetitionName;
		private System.Windows.Forms.MenuStrip mainMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem QuitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem IsClubSortIncludedMenuStrip;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.StatusStrip bottonStatusStrip;
		private System.Windows.Forms.ToolStripProgressBar pbCreatePartition;
		private System.Windows.Forms.ToolStripStatusLabel txtNumberOfSportsmen;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem categoriesSettingsMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem sportsmenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem importSportsmenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editSportsmenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editInCategoriesToolStripMenuItem;
	}
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using CMP.BusinessLogin.DataModel;
using CMP.BusinessLogin.Enums;
using CMP.BusinessLogin.Services;
using CMP.Presentation.DTO;
using CMP.Presentation.Extenstions;
using CMP.Presentation.Helpers;
using CMP.Presentation.Paths;

namespace CMP.Presentation.Forms
{
	public partial class Fm_Sort : Form
	{
		private Dictionary<int, List<Sportsmen>> _sportsmenDictionary;
		private List<Sportsmen> _currentCategory;
		private BackgroundWorker _olympicWorker = new BackgroundWorker();
		private BackgroundWorker _circleWorker = new BackgroundWorker();

		public Fm_Sort()
		{
			StartPosition = FormStartPosition.CenterScreen;

			InitializeComponent();
		}

		private Process GetNewProcess(string path)
		{
			var process = Process.Start(path);
			if (process == null)
			{
				return null;
			}

			process.EnableRaisingEvents = true;
			process.Exited +=
				(sender, args) => Invoke(
					new Action(
						() =>
							btnCircleSystem.Enabled = btnOlympicSystem.Enabled = btnOpen.Enabled = btnSort.Enabled = btnSwap.Enabled = cbCategories.Enabled = true));

			btnCircleSystem.Enabled = btnOlympicSystem.Enabled = btnOpen.Enabled = btnSort.Enabled = btnSwap.Enabled = cbCategories.Enabled = false;

			return process;
		}

		private void Fm_Sort_Load(object sender, EventArgs e)
		{
			LoadData();
			SetBackgroundWorker();
			SetDefaultCategory();
		}

		private void SetBackgroundWorker()
		{
			_olympicWorker.DoWork += OlympicWork;
			_circleWorker.DoWork += CircleWork;

			_olympicWorker.RunWorkerCompleted += WorkComplete;
			_circleWorker.RunWorkerCompleted += WorkComplete;
		}

		private void WorkComplete(object sender, RunWorkerCompletedEventArgs e)
		{
			Invoke(new Action(() =>
			{
				pbCreatePartition.MarqueeAnimationSpeed = 0;
				pbCreatePartition.Value = 0;
			}));
		}

		private void CircleWork(object sender, DoWorkEventArgs e)
		{
			var printDto = (PrintDTO)e.Argument;
			PrintHelper.Print(printDto, SortEnum.CircleSystem);
		}

		private void OlympicWork(object sender, DoWorkEventArgs e)
		{
			var printDto = (PrintDTO)e.Argument;
			PrintHelper.Print(printDto, SortEnum.OlympicSystem);
		}

		private void SetDefaultCategory()
		{
			if (cbCategories.Items.Count > 0)
			{
				cbCategories.SelectedIndex = 0;
			}
		}

		private void LoadData()
		{
			LoadCategoriesData();
			LoadSportsmen();
			LoadSettings();
		}

		private void LoadSettings()
		{
			IsClubSortIncludedMenuStrip.Checked = Properties.Settings.Default.IsClubSortEnabled;
		}

		private void LoadSportsmen()
		{
			_sportsmenDictionary = SportsmenService.LoadSportmenInCategories();
		}

		private void LoadCategoriesData()
		{
			cbCategories.Items.Clear();

			var categories = CategoryService.GetCategories();

			cbCategories.Items.AddRange(categories.ToArray());
		}

		private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
		{
			lvSportsmen.Items.Clear();

			var category = cbCategories.SelectedItem as Category;

			if (category == null)
			{
				SetButtonState(false);
				return;
			}

			SetButtonState(true);

			_currentCategory = new List<Sportsmen>(_sportsmenDictionary[category.Id]);

			SetCategorySportsmen(_currentCategory);

			CheckExistedDocument();

			SetNumberOfSportsmen(_currentCategory.Count);
		}

		private void SetButtonState(bool state)
		{
			btnOlympicSystem.Enabled = btnSort.Enabled = btnSwap.Enabled = btnCircleSystem.Enabled = state;
		}

		private void SetNumberOfSportsmen(int count)
		{
			txtNumberOfSportsmen.Text = @"Количество участников в текущем разделе: " + count;
		}

		private void CheckExistedDocument()
		{
			var category = cbCategories.SelectedItem as Category;

			if (category == null)
			{
				return;
			}

			btnOpen.Enabled = DocumentsHelper.IsPartitionDocumentExisted(category.GetDocumentName());
		}

		private void SetCategorySportsmen(List<Sportsmen> sportsmen)
		{
			lvSportsmen.Items.Clear();

			for (var i = 0; i < sportsmen.Count; i++)
			{
				var sportsman = sportsmen[i];
				string[] @params = { (i + 1).ToString(), sportsman.LastName, sportsman.Name, sportsman.Age.ToString(), sportsman.Club };

				var lvitem = new ListViewItem(@params);

				lvSportsmen.Items.Add(lvitem);
			}
		}

		private void btnSort_Click(object sender, EventArgs e)
		{
			_currentCategory = SortHelper.Sort(_currentCategory, Properties.Settings.Default.IsClubSortEnabled);

			SetCategorySportsmen(_currentCategory);
		}

		private void btnSwap_Click(object sender, EventArgs e)
		{
			if (lvSportsmen.SelectedItems.Count != 2)
			{
				MessageBox.Show(@"Выберите двух сопртсменов", @"Внимание!", MessageBoxButtons.OK);
				return;
			}

			var firstIndex = lvSportsmen.SelectedItems[0].Index;
			var secondIndex = lvSportsmen.SelectedItems[1].Index;

			var first = _currentCategory[firstIndex];
			var second = _currentCategory[secondIndex];

			_currentCategory[firstIndex] = second;
			_currentCategory[secondIndex] = first;

			SetCategorySportsmen(_currentCategory);
		}

		private void btnCircleSystem_Click(object sender, EventArgs e)
		{
			pbCreatePartition.MarqueeAnimationSpeed = 300;
			var printDto = GetCurrentCategoryDto();
			_circleWorker.RunWorkerAsync(printDto);
		}

		private void btnOlympicSystem_Click(object sender, EventArgs e)
		{
			var printDto = GetCurrentCategoryDto();
			PrintHelper.Print(printDto, SortEnum.OlympicSystem);
			CheckExistedDocument();
		}

		private PrintDTO GetCurrentCategoryDto()
		{
			var category = cbCategories.SelectedItem as Category;
			var dto = new PrintDTO(_currentCategory, category.Name, txtCompetitionName.Text);
			return dto;
		}

		private void IsClubSortIncludedMenuStrip_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.IsClubSortEnabled = !Properties.Settings.Default.IsClubSortEnabled;
			Properties.Settings.Default.Save();
		}

		private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			var category = cbCategories.SelectedItem as Category;

			if (category == null)
			{
				return;
			}

			var file = new FileInfo(PathInfo.CategoriesDirectory + category.GetDocumentName());

			try
			{
				GetNewProcess(file.FullName);
			}
			catch (Exception)
			{
				MessageBox.Show("Не найдена сетка. Обновите.", "Внимание!", MessageBoxButtons.OK);
				btnOpen.Enabled = false;
			}
		}

		private void categoriesSettingsMenuStrip_Click(object sender, EventArgs e)
		{
			var form = new Fm_CategoriesEdit();
			form.ShowDialog(this);
		}

		private void editSportsmenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = new Fm_EditSportsmen();
			form.ShowDialog(this);
		}
	}
}

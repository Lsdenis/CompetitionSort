using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CMP.BusinessLogin.Services;
using CMP.Presentation.DTO;
using CMP.Presentation.Helpers;

namespace CMP.Presentation.Forms
{
	public partial class Fm_ImportFromExcel : Form
	{
		private List<ImportSportsmenDTO> _sportsmen;

		public Fm_ImportFromExcel()
		{
			StartPosition = FormStartPosition.CenterParent;
			InitializeComponent();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnChooseFile_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}

			dgvImportSportsmen.Rows.Clear();

			_sportsmen = ExcelParseHelper.GetImportSportsmenDtos(openFileDialog.FileName);

			foreach (var importSportsmenDto in _sportsmen)
			{
				SetSportsmanToDataGridView(importSportsmenDto);
			}
		}

		private void SetSportsmanToDataGridView(ImportSportsmenDTO importSportsmenDto)
		{
			var categories = "";
			for (var index = 0; index < importSportsmenDto.Categories.Count; index++)
			{
				if (index != importSportsmenDto.Categories.Count)
				{
					categories += importSportsmenDto.Categories[index] + ", ";
				}
				else
				{
					categories += importSportsmenDto.Categories[index];
				}
			}

			dgvImportSportsmen.Rows.Add(new object[] { importSportsmenDto.LastName, importSportsmenDto.Name, importSportsmenDto.Age, importSportsmenDto.Club, categories });
		}

		private void btnImport_Click(object sender, EventArgs e)
		{
			if (_sportsmen == null)
			{
				MessageBox.Show("Вы должны выбрать файл!", "Внимание!", MessageBoxButtons.OK);
				return;
			}

			foreach (var sportsman in _sportsmen)
			{
				ExcelParseHelper.SaveSportsman(sportsman);
			}

			MessageBox.Show("Импорт завершен!", "Внимание!", MessageBoxButtons.OK);
		}
	}
}

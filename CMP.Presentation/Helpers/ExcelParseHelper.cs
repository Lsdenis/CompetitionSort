using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using CMP.BusinessLogin.Services;
using CMP.Presentation.DTO;
using OfficeOpenXml;
using CMP.BusinessLogin.DataModel;
using System.Linq;

namespace CMP.Presentation.Helpers
{
	static class ExcelParseHelper
	{
		public static List<ImportSportsmenDTO> GetImportSportsmenDtos(string path)
		{
			var existingFile = new FileInfo(path);
			using (var package = new ExcelPackage(existingFile))
			{
				var worksheet = package.Workbook.Worksheets[1];

				var categories = CategoryService.GetCategories();

				var columnCount = categories.Count + 4;

				var categorieCodes = new string[categories.Count];
				for (var columnIndex = 5; columnIndex < columnCount + 1; columnIndex++)
				{
					categorieCodes[columnIndex - 5] = worksheet.Cells[1, columnIndex].Value.ToString();
				}

				var rowIndex = 2;
				var listDTO = new List<ImportSportsmenDTO>();

				while (worksheet.Cells[rowIndex, 1].Value != null)
				{
					var values = new string[columnCount];
					for (var columnIndex = 1; columnIndex < columnCount + 1; columnIndex++)
					{
						var value = worksheet.Cells[rowIndex, columnIndex].Value;

						if (columnIndex <= 4)
						{
							values[columnIndex - 1] = value.ToString();
						}
						else
						{
							values[columnIndex - 1] = value != null && value.ToString().Equals("+") ? categorieCodes[columnIndex - 5] : "";
						}
					}

					var dto = GetDTO(values, columnCount);
					listDTO.Add(dto);

					rowIndex++;
				}

				return listDTO;
			}
		}

		private static ImportSportsmenDTO GetDTO(string[] values, int columnCount)
		{
			var dto = new ImportSportsmenDTO();

			dto.LastName = values[0];
			dto.Name = values[1];
			dto.Club = values[3];
			dto.Categories = new List<string>();

			int age;
			dto.Age = int.TryParse(values[2], out age) ? age : 0;

			for (var index = 4; index < columnCount; index++)
			{
				if (string.IsNullOrWhiteSpace(values[index]))
				{
					continue;
				}

				dto.Categories.Add(values[index]);
			}

			return dto;
		}

		public static void SaveSportsman(ImportSportsmenDTO importSportsmanDTO)
		{
			var sportsman = new Sportsmen();

			sportsman.Name = importSportsmanDTO.Name;
			sportsman.LastName = importSportsmanDTO.LastName;
			sportsman.Club = importSportsmanDTO.Club;
			sportsman.Age = importSportsmanDTO.Age;

			var sportsmen = SportsmenService.LoadAllSportsmen();

			if (
				sportsmen.Any(
					sp =>
						sp.Name.Equals(sportsman.Name, StringComparison.InvariantCultureIgnoreCase) &&
						sp.LastName.Equals(sportsman.LastName, StringComparison.InvariantCultureIgnoreCase) &&
						sp.Club.Equals(sportsman.Club, StringComparison.InvariantCultureIgnoreCase)))
			{
				var result = MessageBox.Show("Спортсмен с таким именем и фамилией сущестсвует. Вы хотите добавить его?", "Внимание!", MessageBoxButtons.YesNo);

				if (result == DialogResult.No)
				{
					return;
				}
			}
			SportsmenService.SaveOrUpdateSportsman(sportsman);

			var categories = CategoryService.GetCategories();

			foreach (var categoryCode in importSportsmanDTO.Categories)
			{
				var sportsmanInCategory = new SportsmenInCategory();
				var category = categories.FirstOrDefault(ct => ct.Code.Equals(categoryCode));

				if (category == null)
				{
					continue;
				}

				sportsmanInCategory.SportsmenId = sportsman.Id;
				sportsmanInCategory.CategoryId = category.Id;

				SportsmenService.SaveSportsmanInCategory(sportsmanInCategory);
			}
		}
	}
}

﻿using System;
using System.Collections.Generic;
using System.IO;
using CMP.BusinessLogin.Services;
using CMP.Presentation.DTO;
using OfficeOpenXml;

namespace CMP.Presentation.Helpers
{
	static class ExcelParseHelper
	{
		public static List<ImportSportsmenDTO> GetImmImportSportsmenDtos(string path)
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
	}
}

using System;
using System.Linq;
using System.Windows.Forms;
using CMP.BusinessLogin.Enums;
using CMP.Presentation.DTO;
using CMP.Presentation.Paths;
using Word = Microsoft.Office.Interop.Word;

namespace CMP.Presentation.Helpers
{
	public class PrintHelper
	{
		public static void Print(PrintDTO printDto, SortEnum sortType)
		{
			if (sortType == SortEnum.CircleSystem)
			{
				CirclePrint(printDto);
			}
			else
			{
				OlympicPrint(printDto);
			}
		}

		private static void CirclePrint(PrintDTO printDto)
		{
			if (printDto.Sportsmens.Count < 9 && printDto.Sportsmens.Count > 2)
			{
				var word = new Word.Application();     // приложение ворда

				Word.Document document = word.Documents.Open(PathInfo.TemplatesDirectory + "\\table.doc");
				try
				{
					var table = document.Range(0, 0);

					table.InsertBefore(printDto.CompetitionName);
					table.InsertBefore(string.Format("\n"));
					table.InsertBefore(printDto.PartitionName);
					table.InsertBefore(string.Format("\n"));
					table.Font.Name = "Times New Roman";
					table.Font.Size = 14;
					table.InsertParagraphAfter();
					table.SetRange(table.End, table.End);
					table.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

					word.ActiveDocument.Tables.Add(table, printDto.Sportsmens.Count + 1, printDto.Sportsmens.Count + 1);
					var circleTable = word.ActiveDocument.Tables[1];

					object styleName = "Изысканная таблица";
					circleTable.set_Style(ref styleName);

					for (var i = 0; i < printDto.Sportsmens.Count; i++)
					{
						var sportsmen = printDto.Sportsmens[i];
						circleTable.Cell(1, i + 2).Range.Text = string.Format(sportsmen.LastName.ToUpper() + "\n" + sportsmen.Name.ToUpper());
						circleTable.Cell(i + 2, 1).Range.Text = string.Format(sportsmen.LastName.ToUpper() + "\n" + sportsmen.Name.ToUpper());
						circleTable.Cell(i + 2, i + 2).Range.Text = "-----------------"; // заполнение
						circleTable.Cell(i + 2, i + 2).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
					}

					document.SaveAs2(PathInfo.CategoriesDirectory + printDto.PartitionName.Replace(' ', '_') + ".doc");   //для сохранения файла
				}
				catch
				{
				}

				word.Quit();
			}
			else
			{
				MessageBox.Show("Для данного раздела невозможно построить сетку.", "Внимание!", MessageBoxButtons.OK);
			}
		}

		private static void OlympicPrint(PrintDTO printDTO)
		{
			long tmp1 = printDTO.Sportsmens.Count();
			var tmp2 = 1;
			if (tmp1 <= 2 || tmp1 >= 33)
			{
				return;
			}

			while (tmp1 >= 2)
			{
				tmp1 /= 2;
				tmp2++;
			}
			tmp1 = 2;
			tmp1 = (long)Math.Pow(tmp1, tmp2);
			if (tmp1 / 2 == printDTO.Sportsmens.Count())
				tmp1 /= 2;

			var word = new Word.Application();

			object t = true;
			object f = false;

			var document = word.Documents.Open(PathInfo.TemplatesDirectory + tmp1 + "part", Revert: t);

			for (var i = 0; i < printDTO.Sportsmens.Count(); i++)
			{
				var sportsman = printDTO.Sportsmens[i];

				document.Bookmarks["cl" + (i + 1)].Range.Text = sportsman.Club;
				document.Bookmarks["sp" + (i + 1)].Range.Text = sportsman.LastName + " " + sportsman.Name;
			}

			document.Bookmarks["tour"].Range.Text = printDTO.CompetitionName;
			document.Bookmarks["part"].Range.Text = printDTO.PartitionName;

			try
			{
				document.SaveAs2(PathInfo.CategoriesDirectory + printDTO.PartitionName.Replace(' ', '_') + ".doc"); //для сохранения файла
			}
			catch (Exception)
			{

			}
			word.Quit(f);
		}
	}
}

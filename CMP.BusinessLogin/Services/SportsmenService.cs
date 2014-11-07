using System.Collections.Generic;
using System.Linq;
using CMP.BusinessLogin.DataModel;
using System.Data.Entity;

namespace CMP.BusinessLogin.Services
{
	public static class SportsmenService
	{
		public static Dictionary<int, List<Sportsmen>> LoadSportmenInCategories()
		{
			using (var context = new CMPEntities())
			{

				var dict = new Dictionary<int, List<Sportsmen>>();

				var categories = context.Categories.ToList();

				foreach (var category in categories)
				{
					var sportsmen =
						context.Sportsmens.Where(sp => sp.SportsmenInCategories.Any(sc => sc.CategoryId == category.Id))
							.ToList();

					dict.Add(category.Id, sportsmen);
				}

				return dict;
			}
		}
	}
}

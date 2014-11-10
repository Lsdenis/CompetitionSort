using System.Collections.Generic;
using System.Data;
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

		public static void SaveOrUpdateSportsman(Sportsmen sportsmen)
		{
			using (var context = new CMPEntities())
			{
				if (sportsmen.Id == 0)
				{
					context.Sportsmens.Add(sportsmen);
				}
				else
				{
					var existing = context.Sportsmens.Single(sp => sp.Id == sportsmen.Id);

					context.Entry(existing).CurrentValues.SetValues(sportsmen);
					context.Entry(existing).State = EntityState.Modified;
				}

				context.SaveChanges();
			}
		}

		public static List<Sportsmen> LoadAllSportsmen()
		{
			using (var context = new CMPEntities())
			{
				return context.Sportsmens.ToList();
			}
		}

		public static void SaveSportsmanInCategory(SportsmenInCategory sportsmanInCategory)
		{
			using (var context = new CMPEntities())
			{
				context.SportsmenInCategories.Add(sportsmanInCategory);
				context.SaveChanges();
			}
		}
	}
}

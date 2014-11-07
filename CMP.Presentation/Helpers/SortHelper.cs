using System;
using System.Collections.Generic;
using System.Linq;
using CMP.BusinessLogin.DataModel;

namespace CMP.Presentation.Helpers
{
	public static class SortHelper
	{
		public static List<Sportsmen> Sort(List<Sportsmen> sportsmens, bool isClubSortEnaled)
		{
			List<Sportsmen> list = isClubSortEnaled ? SortWithClub(sportsmens) : SortWithoutClub(sportsmens);

			return list;
		}

		private static List<Sportsmen> SortWithoutClub(List<Sportsmen> sportsmens)
		{
			var list = GetRandomSportsman(sportsmens);

			return list;
		}

		private static Random GetNewRandom()
		{
			return new Random(DateTime.Now.Day + DateTime.Now.Millisecond + DateTime.Now.Minute);
		}

		private static List<Sportsmen> SortWithClub(List<Sportsmen> sportsmens)
		{
			var list = new List<Sportsmen>();

			var clubs = sportsmens.Select(sp => sp.Club).Distinct().ToList();

			foreach (var club in clubs)
			{
				var sportsmenInClubs = sportsmens.Where(sp => sp.Club == club).ToList();

				list.AddRange(GetRandomSportsman(sportsmenInClubs));
			}

			return list;
		}

		private static List<Sportsmen> GetRandomSportsman(List<Sportsmen> inputList)
		{
			var random = GetNewRandom();
			var resultList = new List<Sportsmen>();

			while (inputList.Count != 0)
			{
				var index = random.Next(0, inputList.Count);

				var sportsmen = inputList[index];

				inputList.Remove(sportsmen);

				resultList.Add(sportsmen);
			}

			return resultList;
		}
	}
}

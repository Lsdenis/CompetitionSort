using System;
using System.Collections.Generic;
using System.Linq;
using CMP.BusinessLogin.DataModel;

namespace CMP.Presentation.Extenstions
{
	public static class Extensions
	{
		public static string GetDocumentName(this Category category)
		{
			return category.Name.Replace(' ', '_') + ".doc";
		}

		public static IList<T> Clone<T>(this IEnumerable<T> listToClone) where T : ICloneable
		{
			return listToClone.Select(item => (T)item.Clone()).ToList();
		}

		public static bool Contains(this string source, string toCheck, StringComparison comp)
		{
			return source.IndexOf(toCheck, comp) >= 0;
		}
	}
}

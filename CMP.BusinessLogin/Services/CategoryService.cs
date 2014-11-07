using System.Collections.Generic;
using System.Linq;
using CMP.BusinessLogin.DataModel;

namespace CMP.BusinessLogin.Services
{
	public static class CategoryService
	{
		public static List<Category> GetCategories()
		{
			using (var context = new CMPEntities())
			{
				return context.Categories.ToList();
			}
		}
	}
}

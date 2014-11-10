using System;

namespace CMP.Presentation.Paths
{
	public static class PathInfo
	{
		public static string BaseDirectory = AppDomain.CurrentDomain.BaseDirectory;
		public static readonly string TemplatesDirectory = AppDomain.CurrentDomain.BaseDirectory + "\\Templates\\";
		public static readonly string CategoriesDirectory = AppDomain.CurrentDomain.BaseDirectory + "\\Categories\\";
	}
}

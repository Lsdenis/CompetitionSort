using System;
using System.IO;
using CMP.Presentation.Paths;

namespace CMP.Presentation.Helpers
{
	public class DocumentsHelper
	{
		public static bool IsPartitionDocumentExisted(string partitionName)
		{
			return File.Exists(PathInfo.CategoriesDirectory + partitionName);
		}
	}
}

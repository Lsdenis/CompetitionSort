using System.Collections.Generic;

namespace CMP.Presentation.DTO
{
	class ImportSportsmenDTO
	{
		public string Name { get; set; }
		public string LastName { get; set; }
		public string Club { get; set; }
		public int Age { get; set; }

		public List<string> Categories { get; set; }

		public ImportSportsmenDTO()
		{
			
		}
	}
}

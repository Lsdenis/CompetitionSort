using System.Collections;
using System.Collections.Generic;
using CMP.BusinessLogin.DataModel;

namespace CMP.Presentation.DTO
{
	public class PrintDTO
	{
		public List<Sportsmen> Sportsmens { get; set; }
		public string PartitionName { get; set; }
		public string CompetitionName { get; set; }

		public PrintDTO()
		{

		}

		public PrintDTO(List<Sportsmen> sportsmens, string partitionName, string competitionName)
		{
			Sportsmens = sportsmens;
			PartitionName = partitionName;
			CompetitionName = competitionName;
		}
	}
}

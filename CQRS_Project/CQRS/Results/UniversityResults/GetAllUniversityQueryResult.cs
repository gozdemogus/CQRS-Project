using System;
namespace CQRS_Project.CQRS.Results.UniversityResults
{
	public class GetAllUniversityQueryResult
	{
		public GetAllUniversityQueryResult()
		{
		}

        public int UniversityID { get; set; }
        public string Name { get; set; }
        public string Town { get; set; }
    }
}


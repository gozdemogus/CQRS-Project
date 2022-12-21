using System;
namespace CQRS_Project.CQRS.Results.StudentResults
{
	public class GetStudentByIdQueryResult
	{
		public GetStudentByIdQueryResult()
		{
		}

        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
}


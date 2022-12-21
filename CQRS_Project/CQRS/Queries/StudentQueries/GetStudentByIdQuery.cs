using System;
namespace CQRS_Project.CQRS.Queries.StudentQueries
{
	public class GetStudentByIdQuery
	{

        public int id { get; set; }

        public GetStudentByIdQuery(int id)
        {
            this.id = id;
        }
    }
}


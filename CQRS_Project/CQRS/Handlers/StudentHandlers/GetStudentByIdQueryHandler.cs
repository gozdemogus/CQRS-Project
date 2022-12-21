using System;
using CQRS_Project.CQRS.Queries.StudentQueries;
using CQRS_Project.CQRS.Results.StudentResults;
using CQRS_Project.DAL.Context;

namespace CQRS_Project.CQRS.Handlers.StudentHandlers
{
	public class GetStudentByIdQueryHandler
	{
        private readonly ProductContext _context;

        public GetStudentByIdQueryHandler(ProductContext context)
        {
            _context = context;
        }
        public GetStudentByIdQueryResult Handle(GetStudentByIdQuery query)
        {
            var values = _context.Students.Find(query.id);

            return new GetStudentByIdQueryResult
            {
                Age = values.Age,
                City = values.City,
                Name = values.Name,
                Surname = values.Surname,
                StudentID = values.StudentID
            };
        }
    }
}


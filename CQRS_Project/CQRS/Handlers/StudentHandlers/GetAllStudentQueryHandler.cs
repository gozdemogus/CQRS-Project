using System;
using CQRS_Project.CQRS.Results.StudentResults;
using CQRS_Project.DAL.Context;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CQRS_Project.CQRS.Handlers.StudentHandlers
{
	public class GetAllStudentQueryHandler
	{
		public GetAllStudentQueryHandler()
		{
		}
        private readonly ProductContext _Context;

        public GetAllStudentQueryHandler(ProductContext context)
        {
            _Context = context;
        }

        public List<GetAllStudentQueryResult> Handle()
        {
            var values = _Context.Students.Select(x => new GetAllStudentQueryResult
            {
                City = x.City,
                Department = x.Department,
                Name = x.Name,
                StudentID = x.StudentID,
                Surname = x.Surname
            }).AsNoTracking().ToList();

            return values;
        }
    }
}


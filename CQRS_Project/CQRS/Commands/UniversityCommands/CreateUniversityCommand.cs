using System;
using MediatR;

namespace CQRS_Project.CQRS.Commands.UniversityCommands
{
	public class CreateUniversityCommand:IRequest
	{
        public string Name { get; set; }
        public string City { get; set; }
        public string Population { get; set; }
        public int FacultyCount { get; set; }
    }
}


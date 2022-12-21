using System;
using MediatR;

namespace CQRS_Project.CQRS.Commands.UniversityCommands
{
	public class UpdateUniversityCommand:IRequest
	{
		public UpdateUniversityCommand()
		{
		}
        public int UniversityID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Population { get; set; }
    }
}


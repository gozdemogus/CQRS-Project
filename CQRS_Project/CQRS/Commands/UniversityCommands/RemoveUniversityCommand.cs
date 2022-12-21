using System;
using MediatR;

namespace CQRS_Project.CQRS.Commands.UniversityCommands
{
	public class RemoveUniversityCommand:IRequest
	{
      
        public RemoveUniversityCommand(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}


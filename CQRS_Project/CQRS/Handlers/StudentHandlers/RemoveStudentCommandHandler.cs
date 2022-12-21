using System;
using CQRS_Project.CQRS.Commands.StudentCommands;
using CQRS_Project.DAL.Context;

namespace CQRS_Project.CQRS.Handlers.StudentHandlers
{
	public class RemoveStudentCommandHandler
	{
		public RemoveStudentCommandHandler()
		{
		}

        private readonly ProductContext _context;

        public RemoveStudentCommandHandler(ProductContext context)
        {
            _context = context;
        }

        public void Handle(RemoveStudentCommand command)
        {
            var values = _context.Students.Find(command.id);
            _context.Students.Remove(values);
            _context.SaveChanges();
        }
    }
}


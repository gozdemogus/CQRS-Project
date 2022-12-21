using System;
namespace CQRS_Project.CQRS.Commands.StudentCommands
{
	public class CreateStudentCommand
	{
		public CreateStudentCommand()
		{
		}
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Status { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
}


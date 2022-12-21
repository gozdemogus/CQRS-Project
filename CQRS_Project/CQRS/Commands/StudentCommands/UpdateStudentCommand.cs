using System;
namespace CQRS_Project.CQRS.Commands.StudentCommands
{
	public class UpdateStudentCommand
	{
		public UpdateStudentCommand()
		{
		}

        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
}


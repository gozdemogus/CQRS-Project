using System;
using CQRS_Project.CQRS.Commands.StudentCommands;
using CQRS_Project.DAL.Context;
using CQRS_Project.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRS_Project.CQRS.Handlers.StudentHandlers
{
	public class CreateStudentCommandHandler
	{
        private readonly ProductContext _Context;

        public CreateStudentCommandHandler(ProductContext productContext)
        {
            _Context = productContext;
        }

        public void Handle(CreateStudentCommand command)
        {
            var values = _Context.Students.Add(new Student
            {
                Age = command.Age,
                Name = command.Name,
                City = command.City,
                Surname = command.Surname,
                Status = false
            });


            _Context.SaveChanges();
        }

    }
}


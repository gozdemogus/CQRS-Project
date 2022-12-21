using System;
using System.Threading;
using System.Threading.Tasks;
using CQRS_Project.CQRS.Commands.UniversityCommands;
using CQRS_Project.DAL.Context;
using CQRS_Project.DAL.Entities;
using MediatR;

namespace CQRS_Project.CQRS.Handlers.UniversityHandlers
{
	public class CreateUniversityCommandHandler : IRequestHandler<CreateUniversityCommand>
    {
        private readonly ProductContext _context;

        public CreateUniversityCommandHandler(ProductContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateUniversityCommand request, CancellationToken cancellationToken)
        {
            _context.Universities.Add(new University
            {
                City = request.City,
                Name = request.Name,
                Population = request.Population,
                FacultyCount = request.FacultyCount

            });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}


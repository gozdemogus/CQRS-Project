using System;
using CQRS_Project.CQRS.Commands.UniversityCommands;
using CQRS_Project.DAL.Context;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_Project.CQRS.Handlers.UniversityHandlers
{
    public class UpdateUniversityCommandHandler : IRequestHandler<UpdateUniversityCommand>
    {
       
        private readonly ProductContext _context;

        public UpdateUniversityCommandHandler(ProductContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateUniversityCommand request, CancellationToken cancellationToken)
        {
            var values = _context.Universities.Find(request.UniversityID);
            values.Name = request.Name;
            values.City = request.City;
            values.Population = request.Population;
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}


using System;
using System.Threading;
using System.Threading.Tasks;
using CQRS_Project.CQRS.Queries.UniversityQueries;
using CQRS_Project.CQRS.Results.UniversityResults;
using CQRS_Project.DAL.Context;
using MediatR;

namespace CQRS_Project.CQRS.Handlers.UniversityHandlers
{
    public class GetUniversityByIDQueryHandler : IRequestHandler<GetUniversityByIdQuery, GetUniversityByIdQueryResult>
    {
        private readonly ProductContext _context;

        public GetUniversityByIDQueryHandler(ProductContext context)
        {
            _context = context;
        }

        public async Task<GetUniversityByIdQueryResult> Handle(GetUniversityByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Universities.FindAsync(request.id);
              return new GetUniversityByIdQueryResult
            {
                UniversityID = values.UniversityID,

                City = values.City,
                Name = values.Name,
                Population = values.Population
            };
        }
    }
}


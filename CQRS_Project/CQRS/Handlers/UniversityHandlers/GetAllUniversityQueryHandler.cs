using System;
using CQRS_Project.CQRS.Results.UniversityResults;
using System.Collections.Generic;
using CQRS_Project.DAL.Context;
using MediatR;
using System.Threading;
using CQRS_Project.CQRS.Queries.UniversityQueries;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CQRS_Project.CQRS.Handlers.UniversityHandlers
{
    public class GetAllUniversityQueryHandler : IRequestHandler<GetAllUniversityQuery, List<GetAllUniversityQueryResult>> //Bu mediatr'den hazır 
                                                                                                                          //metodları alıp kullanabilmek için içine parametreler için query'i
                                                                                                                          //ve dönecek sonuçları tutmak için Result'ı veririrm.
    {
        private readonly ProductContext _productContext;

        public GetAllUniversityQueryHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }

        public async Task<List<GetAllUniversityQueryResult>> Handle(GetAllUniversityQuery request, CancellationToken cancellationToken)
        {
            return await _productContext.Universities.Select(x =>
            new GetAllUniversityQueryResult
            {
                UniversityID = x.UniversityID,
                Town = x.City,
                Name = x.Name

            }).AsNoTracking().ToListAsync();
        }

    }
}
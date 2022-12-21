using System;
using MediatR;
using System.Collections.Generic;
using CQRS_Project.CQRS.Results.UniversityResults;


namespace CQRS_Project.CQRS.Queries.UniversityQueries
{

    //query sınıfı parametre icin 
    public class GetAllUniversityQuery : IRequest<List<GetAllUniversityQueryResult>>
    {
        //ne türden bi veri almak istiyorsak burada belirtiyoruz
    }
}


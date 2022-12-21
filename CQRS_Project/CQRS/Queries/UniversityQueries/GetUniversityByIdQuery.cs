using System;
using CQRS_Project.CQRS.Results.UniversityResults;
using MediatR;

namespace CQRS_Project.CQRS.Queries.UniversityQueries
{
	public class GetUniversityByIdQuery:IRequest<GetUniversityByIdQueryResult>
	{
        public GetUniversityByIdQuery(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}


using System;
namespace CQRS_Project.CQRS.Queries.ProductQueries
{
	public class GetProductHumanResourceByIDQuery
	{
		public GetProductHumanResourceByIDQuery()
		{
		}

        public GetProductHumanResourceByIDQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}


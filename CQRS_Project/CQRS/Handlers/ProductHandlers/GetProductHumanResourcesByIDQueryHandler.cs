using System;
using CQRS_Project.CQRS.Queries.ProductQueries;
using CQRS_Project.CQRS.Results.ProductResults;
using CQRS_Project.DAL.Context;

namespace CQRS_Project.CQRS.Handlers.ProductHandlers
{
	public class GetProductHumanResourcesByIDQueryHandler
	{
        private readonly ProductContext _productContext;

        public GetProductHumanResourcesByIDQueryHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }
        public GetProductHumanResourceByIDQueryResult Handle(GetProductHumanResourceByIDQuery query)
        {
            var values = _productContext.Products.Find(query.Id);
            return new GetProductHumanResourceByIDQueryResult
            {
                ProductID = values.ProductID,
                Brand = values.Brand,
                Name = values.Name,
                SalePrice = values.SalePrice
            };
        }
    }
}


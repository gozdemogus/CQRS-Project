using System;
using CQRS_Project.CQRS.Queries.ProductQueries;
using CQRS_Project.CQRS.Results.ProductResults;
using CQRS_Project.DAL.Context;

namespace CQRS_Project.CQRS.Handlers.ProductHandlers
{
	public class GetProductAccounterByIDQueryHandler
	{
		public GetProductAccounterByIDQueryHandler()
		{
		}

        private readonly ProductContext _productContext;

        public GetProductAccounterByIDQueryHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }
        public GetProductAccounterByIDQueryResult Handle(GetProductAccounterByIDQuery query)
        {
            var values = _productContext.Products.Find(query.Id);
            return new GetProductAccounterByIDQueryResult
            {
                ProductID = values.ProductID,
                Brand = values.Brand,
                Description = values.Description,
                Name = values.Name,
                PurchasePrice = values.PurchasePrice,
                SalePrice = values.SalePrice,
                Stock = values.Stock,
                Tax = values.Tax
            };

        }

    }
}


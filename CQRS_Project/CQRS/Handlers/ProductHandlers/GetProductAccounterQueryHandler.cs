using System;
using CQRS_Project.CQRS.Results.ProductResults;
using CQRS_Project.DAL.Context;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CQRS_Project.CQRS.Handlers.ProductHandlers
{
	public class GetProductAccounterQueryHandler
	{
     
        private readonly ProductContext _productContext; 

        public GetProductAccounterQueryHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }
      
        public List<GetProductAccounterQueryResult> Handle()
        {
           
            var values = _productContext.Products.Select(x => new GetProductAccounterQueryResult
            {
                ProductID = x.ProductID,
                Name = x.Name,
                Stock = x.Stock,
                Brand = x.Brand,
                SalePrice = x.SalePrice,
                PurchasePrice = x.PurchasePrice

            }).AsNoTracking().ToList();
            //savechanges yapmıyorsam sadece listeleme yapıyorsam performansı artırmak icin
            //AsNoTracking() kullanılır
            return values;
        }


    }
}


using System;
using CQRS_Project.CQRS.Commands.ProductCommands;
using CQRS_Project.DAL.Context;
using CQRS_Project.DAL.Entities;

namespace CQRS_Project.CQRS.Handlers.ProductHandlers
{
	public class CreateProductCommandHandler
	{
		public CreateProductCommandHandler()
		{
		}

        private readonly ProductContext _productContext;

        public CreateProductCommandHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }
        public void Handle(CreateProductCommand command)
        {
            _productContext.Products.Add(new Product
            {
                Brand = command.Brand,
                Cost = command.Cost,
                Stock = command.Stock,
                Tax = command.Tax,
                PurchasePrice = command.PurchasePrice,
                SalePrice = command.SalePrice,
                Name = command.Name,
                Size = command.Size,
                ProduceOfDate = command.ProduceOfDate,
                EndOfDate = command.EndOfDate,
                Status = true
            });

            _productContext.SaveChanges();
        }
    }
}


﻿using System;
namespace CQRS_Project.CQRS.Results.ProductResults
{
	public class GetProductAccounterByIDQueryResult
	{
		public GetProductAccounterByIDQueryResult()
		{
		}

        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Stock { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public int Tax { get; set; }


        public string Description { get; set; }
    }
}


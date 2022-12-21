using System;
namespace CQRS_Project.CQRS.Results.ProductResults
{
	public class GetProductStoragerQueryResult
	{
		public GetProductStoragerQueryResult()
		{
		}

        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Storage { get; set; }
    }
}


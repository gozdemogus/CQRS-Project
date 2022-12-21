using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS_Project.CQRS.Commands.ProductCommands;
using CQRS_Project.CQRS.Handlers.ProductHandlers;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CQRS_Project.Controllers
{
    public class ProductController : Controller
    {
        private readonly GetProductAccounterQueryHandler _getProductAccounterQueryHandler;
        private readonly GetProductStoragerQueryHandler _getProductStoragerQueryHandler;
        private readonly GetProductHumanResourcesByIDQueryHandler _getHumanResourcesByIDQueryHandler;
        private readonly GetProductAccounterByIDQueryHandler _getProductAccounterByIDQueryHandler;
        private readonly CreateProductCommandHandler _createProductCommandHandler;


        public ProductController(GetProductAccounterQueryHandler getProductAccounterQueryHandler, GetProductStoragerQueryHandler getProductStoragerQueryHandler, GetProductHumanResourcesByIDQueryHandler getHumanResourcesByIDQueryHandler, GetProductAccounterByIDQueryHandler getProductAccounterByIDQueryHandler, CreateProductCommandHandler createProductCommandHandler)
        {
            _getProductAccounterQueryHandler = getProductAccounterQueryHandler;
            _getProductStoragerQueryHandler = getProductStoragerQueryHandler;
            _getHumanResourcesByIDQueryHandler = getHumanResourcesByIDQueryHandler;
            _getProductAccounterByIDQueryHandler = getProductAccounterByIDQueryHandler;
            _createProductCommandHandler = createProductCommandHandler;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var values = _getProductAccounterQueryHandler.Handle();
            return View(values);
        }

        public IActionResult StoragerIndex()
        {
            var values = _getProductStoragerQueryHandler.Handle();
            return View(values);
        }

        public IActionResult GetHumanResourcesIndex(int id)
        {
            //idye erisim saglamak icin Queryde constructorda atanması gerekiyor
            var values = _getHumanResourcesByIDQueryHandler.Handle(new CQRS.Queries.ProductQueries.GetProductHumanResourceByIDQuery(id));
            return View(values);
        }

        public IActionResult GetAccounterIndexByID(int id)
        {
            var values = _getProductAccounterByIDQueryHandler.Handle(new CQRS.Queries.ProductQueries.GetProductAccounterByIDQuery(id));
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(CreateProductCommand command)
        {
            _createProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}


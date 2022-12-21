using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS_Project.CQRS.Commands.StudentCommands;
using CQRS_Project.CQRS.Handlers.StudentHandlers;
using CQRS_Project.CQRS.Queries.StudentQueries;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CQRS_Project.Controllers
{
    //result propertyleri tutar
    //command ekleme-silme-güncelleme
    //handle crud islemleri
    //query parametreleri 
    public class StudentController : Controller
    {
        private readonly CreateStudentCommandHandler _createStudentCommandHandler;
        private readonly GetAllStudentQueryHandler _getAllStudentQueryHandler;
        private readonly RemoveStudentCommandHandler _removeStudentCommandHandler;
        private readonly GetStudentByIdQueryHandler _getStudentByIdQueryHandler;
        private readonly UpdateStudentCommandHandler _updateStudentCommandHandler;




        public StudentController(CreateStudentCommandHandler createStudentCommandHandler, GetAllStudentQueryHandler getAllStudentQueryHandler, RemoveStudentCommandHandler removeStudentCommandHandler, GetStudentByIdQueryHandler getStudentByIdQueryHandler, UpdateStudentCommandHandler updateStudentCommandHandler)
        {
            _createStudentCommandHandler = createStudentCommandHandler;
            _getAllStudentQueryHandler = getAllStudentQueryHandler;
            _removeStudentCommandHandler = removeStudentCommandHandler;
            _getStudentByIdQueryHandler = getStudentByIdQueryHandler;
            _updateStudentCommandHandler = updateStudentCommandHandler;
        }


        public IActionResult Index()
        {
            var values = _getAllStudentQueryHandler.Handle();
            return View(values);
        }

        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(CreateStudentCommand command)
        {
            _createStudentCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteStudent(int id)
        {
            _removeStudentCommandHandler.Handle(new RemoveStudentCommand(id));
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdateStudent(int id)
        {
            var values = _getStudentByIdQueryHandler.Handle(new GetStudentByIdQuery(id));
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateStudent(UpdateStudentCommand command)
        {
            _updateStudentCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}


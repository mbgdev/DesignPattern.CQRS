
using DesignPattern.CQRS.Business.CQRS.Commands.StudentCommand;
using DesignPattern.CQRS.Business.CQRS.Queries.StudentQueries;
using DesignPattern.CQRS.Entity.Concrete;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.CQRS.Web.Controllers
{
    public class StudentController : Controller
    {

        private readonly IMediator _mediator;
       

        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
           
        }

        public async Task<IActionResult> GetAllStudent()
        {
            var result = await _mediator.Send(new GetAllStudentQuery());
            
            return View(result);
        }


        public async Task<IActionResult> GetByIdStudent(int id)
        {
            var result = await _mediator.Send(new GetStudentByIdQuery(id));

            return View(result);
        }


        [HttpGet]
        public async Task<IActionResult> AddStudent()
        {
            

            return View();
        }

        public async Task<IActionResult> AddStudent(CreateStudentCommand command)
        {
            var result = await _mediator.Send(command);

            return RedirectToAction("GetAllStudent");
        }




    }
}

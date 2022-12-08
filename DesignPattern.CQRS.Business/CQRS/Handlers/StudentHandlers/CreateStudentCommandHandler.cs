using DesignPattern.CQRS.Business.CQRS.Commands.StudentCommand;
using DesignPattern.CQRS.DAL.Concrete;
using DesignPattern.CQRS.Entity.Concrete;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CQRS.Business.CQRS.Handlers.StudentHandlers
{
    public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand>
    {

        private readonly Context _context;

        public CreateStudentCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
           await _context.Students.AddAsync(new Student
            {
                Name= request.Name,
                Surname= request.Surname,
                Status= request.Status,
            });

            await _context.SaveChangesAsync();

            return Unit.Value;
        }
    }
}

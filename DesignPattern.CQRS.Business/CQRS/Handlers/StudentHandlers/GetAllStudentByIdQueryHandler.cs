using DesignPattern.CQRS.Business.CQRS.Queries.StudentQueries;
using DesignPattern.CQRS.Business.CQRS.Results.StudentResult;
using DesignPattern.CQRS.DAL.Concrete;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CQRS.Business.CQRS.Handlers.StudentHandlers
{
    public class GetAllStudentByIdQueryHandler : IRequestHandler<GetStudentByIdQuery, GetStudentByIdQueryResult>
    {

        private readonly Context _context;

        public GetAllStudentByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetStudentByIdQueryResult> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            var result=await _context.Students.FindAsync(request.Id);

            return new GetStudentByIdQueryResult
            {
                Id = result.Id,
                Name = result.Name,
                Surname = result.Surname,
                Mail = result.Mail
            };
        }
    }
}

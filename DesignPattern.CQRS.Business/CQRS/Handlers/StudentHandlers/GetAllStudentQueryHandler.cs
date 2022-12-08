using DesignPattern.CQRS.Business.CQRS.Queries.StudentQueries;
using DesignPattern.CQRS.Business.CQRS.Results.StudentResult;
using DesignPattern.CQRS.DAL.Concrete;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.CQRS.Business.CQRS.Handlers.StudentHandlers
{
    public class GetAllStudentQueryHandler : IRequestHandler<GetAllStudentQuery,List<GetAllStudentQueryResult>>
    {
        private readonly Context _context;

        public GetAllStudentQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<GetAllStudentQueryResult>> Handle(GetAllStudentQuery request, CancellationToken cancellationToken)
        {
            return await _context.Students.Select(x => new GetAllStudentQueryResult
            {
                City = x.City,
                Id = x.Id,
                Name = x.Name,
                Surname = x.Surname,
            }).AsNoTracking().ToListAsync();
        }
    }
}

using DesignPattern.CQRS.Business.CQRS.Results.StudentResult;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CQRS.Business.CQRS.Queries.StudentQueries
{
    public class GetAllStudentQuery:IRequest<List<GetAllStudentQueryResult>>
    {

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CQRS.Entity.Concrete
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string Mail { get; set; }
        public string Number { get; set; }
        public string Department { get; set; }
        public bool Status { get; set; }
    }
}

using DesignPattern.CQRS.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CQRS.DAL.Concrete
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Student> Students { get; set; }
    }
}

using Sql.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql.DataAccess.Concrete
{
    public class SqlContext : DbContext
    {
        public DbSet<Course> courseses { get; set; }
        public  DbSet<Category> Category { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
    }
}

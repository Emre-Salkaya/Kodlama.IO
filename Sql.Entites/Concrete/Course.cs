using Sql.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql.Entites.Concrete
{
    public class Course:IEntity
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
    }
}

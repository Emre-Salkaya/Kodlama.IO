using Sql.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql.Entites.Concrete
{
    public class Instructor:IEntity
    {
        public int InstructorId { get; set; }
        public string InstructorName { get; set; }
    }
}

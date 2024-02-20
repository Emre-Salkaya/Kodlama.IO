using Sql.DataAccess.Abstract;
using Sql.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql.DataAccess.Concrete
{
    public class CourseDal : EntityRepositoryBase<Course, SqlContext> , ICourseDal
    {
    }
}

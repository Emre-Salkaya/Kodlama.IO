using Sql.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql.DataAccess.Abstract
{
    public interface IInstructorDal : IEntityRepository<Instructor>
    {
    }
}

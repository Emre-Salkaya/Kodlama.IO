using Sql.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql.Business.Abstract
{
    public interface ICourseManager
    {
        List<Course> GetAll();

    }
}

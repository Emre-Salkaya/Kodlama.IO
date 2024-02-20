using Sql.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql.Business.Abstract
{
    public interface ICategoryManager
    {
        List<Category> GetAll();
    }
}

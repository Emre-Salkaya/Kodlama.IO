using Sql.DataAccess.Abstract;
using Sql.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql.DataAccess.Concrete
{
    public class CategoryDal : EntityRepositoryBase<Category,SqlContext> , ICategoryDal
    {
    }
}

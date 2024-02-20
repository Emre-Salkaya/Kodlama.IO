using Sql.Business.Abstract;
using Sql.DataAccess.Abstract;
using Sql.Entites.Abstract;
using Sql.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql.Business.Concrete
{
    public class CategoryManager : ICategoryManager
    {
        private ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }
    }
}

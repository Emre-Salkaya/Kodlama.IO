using Sql.Business.Abstract;
using Sql.DataAccess.Abstract;
using Sql.DataAccess.Concrete;
using Sql.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql.Business.Concrete
{
    public class CourseManager : ICourseManager
    {

        private ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }


    }
}

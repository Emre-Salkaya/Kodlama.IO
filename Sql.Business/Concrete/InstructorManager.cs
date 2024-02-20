using Sql.Business.Abstract;
using Sql.DataAccess.Abstract;
using Sql.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql.Business.Concrete
{
    public class InstructorManager : IInstructorManager
    {
        private IInstructorDal _ınstructorDal;
        public InstructorManager(IInstructorDal ınstructorDal)
        {
            _ınstructorDal = ınstructorDal;
        }
        public List<Instructor> GetAll()
        {
            return _ınstructorDal.GetAll();
        }
    }
}

using Sql.DataAccess.Abstract;
using Sql.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sql.DataAccess.Concrete
{
    public class EntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public List<TEntity> GetAll()
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().ToList();
            }
        }
    }
}

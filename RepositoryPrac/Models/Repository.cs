using Microsoft.EntityFrameworkCore;

namespace RepositoryPrac.Models
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbSet<T> _dbset;
        public Repository(tmDBContext tmDBContext) {
            _dbset = tmDBContext.Set<T>();
        }
        public T Get(System.Linq.Expressions.Expression<Func<T, bool>> entity)
        {
            IQueryable<T> entities= _dbset.Where(entity);
            return entities.FirstOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
           return _dbset.ToList();
        }
    }
}

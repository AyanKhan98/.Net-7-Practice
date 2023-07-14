using System.Linq.Expressions;

namespace RepositoryPrac.Models
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(Expression<Func<T, bool>> entity);
    }
}

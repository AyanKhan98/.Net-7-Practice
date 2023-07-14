using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace RepositoryPrac.Models
{
    public class StatusRepository : Repository<Status>, IStatusRepository
    {
        private tmDBContext _db;
        
        public StatusRepository(tmDBContext tmDBContext):base(tmDBContext)
        {
            _db = tmDBContext;
        }
        
        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Status status)
        {
            _db.Update(status);
        }
    }
}

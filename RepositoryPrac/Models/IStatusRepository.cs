namespace RepositoryPrac.Models
{
    public interface IStatusRepository : IRepository<Status>
    {
        void Update(Status status);
        void Save();
    }
}

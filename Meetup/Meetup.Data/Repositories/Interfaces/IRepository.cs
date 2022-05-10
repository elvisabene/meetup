namespace Meetup.Data.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        Task<T?> GetById(int id);

        Task<IEnumerable<T>> GetAll();

        Task<T> Create(T entity);

        Task Update(T entity);

        Task<bool> Delete(int id);
    }
}

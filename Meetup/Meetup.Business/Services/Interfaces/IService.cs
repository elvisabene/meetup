namespace Meetup.Business.Services.Interfaces
{
    public interface IService<T>
    {
        Task<T?> GetById(int id);

        Task<IEnumerable<T>> GetAll();

        Task<T> Create(T entity);

        Task<T> Update(T entity);

        Task<bool> Delete(int id);
    }
}

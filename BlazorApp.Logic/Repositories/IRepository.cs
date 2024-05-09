namespace BlazorApp.Logic.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        bool DeleteById(int id);
        T Create(T newEmployee);
        bool Update(int id, T employee);
    }
}

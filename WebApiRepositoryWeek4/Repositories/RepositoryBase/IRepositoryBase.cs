namespace WebApiRepositoryWeek4.Repositories.RepositoryBase
{
    public interface IRepositoryBase<T> where T : class
    {   
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(T obj);
        void Delete(int id);
        void Save();
    }
}

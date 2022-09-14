using Microsoft.EntityFrameworkCore;
using WebApiRepositoryWeek4.Data;

namespace WebApiRepositoryWeek4.Repositories.RepositoryBase
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected Context _context { get; } 
        public RepositoryBase(Context context)
        {
            _context = context;
        }

        public void Delete(T obj)
        {
            _context.Set<T>().Remove(obj);  // delete with obj parameter
        }

        public void Delete(int id)
        {
            var obj = _context.Set<T>().Find(id);   // delete with id parameter 
            _context.Set<T>().Remove(obj);
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Insert(T obj)
        {
            _context.Set<T>().Add(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T obj)
        {
            _context.Set<T>().Update(obj);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

    }
}

using AdminUser.EntityFramework;

namespace AdminUser.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        UserContext db = new UserContext();
        public void Add(T entity)
        {
            db.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
           var T = db.Set<T>().Find(id);
            db.Remove(T);
            db.SaveChanges();
        }

        public List<T> GetAll()
        {
            return db.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return db.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            db.Update(entity);
            db.SaveChanges();
        }
    }
}

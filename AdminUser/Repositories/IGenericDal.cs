namespace AdminUser.Repositories
{
    public interface IGenericDal<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        List<T> GetAll(); 
        T GetById(int id);
    }
}

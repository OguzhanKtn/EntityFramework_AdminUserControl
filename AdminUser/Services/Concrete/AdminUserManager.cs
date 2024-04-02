using AdminUser.Models;
using AdminUser.Repositories;
using AdminUser.Services.Abstract;

namespace AdminUser.Services.Concrete
{
    public class AdminUserManager : IAdminUserService
    {
        GenericRepository<Admin> repository;
        
        public AdminUserManager()
        {
            repository = new GenericRepository<Admin>();
        }

        public void AdminAdd(Admin admin)
        {
            repository.Add(admin);
        }

        public void AdminDelete(int id)
        {
            repository?.Delete(id);
        }

        public void AdminUpdate(Admin admin)
        {
            repository.Update(admin);
        }

        public Admin GetById(int id)
        {
          return repository.GetById(id);
        }

        public List<Admin> GetList()
        {
            return repository.GetAll();
        }
    }
}

using AdminUser.DataAccess.Abstract;
using AdminUser.Models;
using AdminUser.Repositories;
using AdminUser.Services.Abstract;

namespace AdminUser.Services.Concrete
{
    public class AdminUserManager : IAdminUserService
    {
        IAdminUserDal _adminUserDal;
        
        public AdminUserManager(IAdminUserDal adminUserDal)
        {
            _adminUserDal=adminUserDal;
        }

        public void AdminAdd(Admin admin)
        {
            _adminUserDal.Add(admin);
        }

        public void AdminDelete(int id)
        {
            _adminUserDal?.Delete(id);
        }

        public void AdminUpdate(Admin admin)
        {
            _adminUserDal.Update(admin);
        }

        public Admin GetById(int id)
        {
          return _adminUserDal.GetById(id);
        }

        public List<Admin> GetList()
        {
            return _adminUserDal.GetAll();
        }
    }
}

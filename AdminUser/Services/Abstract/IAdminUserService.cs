using AdminUser.Models;

namespace AdminUser.Services.Abstract
{
    public interface IAdminUserService
    {
        void AdminAdd(Admin admin);
        void AdminDelete(int id);
        void AdminUpdate(Admin admin);
        List<Admin> GetList();
        Admin GetById(int id);
    }
}

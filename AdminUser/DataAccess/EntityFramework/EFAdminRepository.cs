using AdminUser.DataAccess.Abstract;
using AdminUser.Models;
using AdminUser.Repositories;

namespace AdminUser.DataAccess.EntityFramework
{
    public class EFAdminRepository : GenericRepository<Admin>,IAdminUserDal
    {
        public override List<Admin> GetAll()
        {
          return db.AdminUsers.Where(x=>x.IsDeleted == false).ToList();
        }

        public override Admin GetById(int id)
        {
            Admin admin = db.AdminUsers.Find(id);

            if(admin != null && admin.IsDeleted == false) 
            { 
                return admin;
            }
            else
            {
                return null;
            }        
        }
    }
}

using AdminUser.DataAccess.Abstract;
using AdminUser.DataAccess.EntityFramework;
using AdminUser.Models;
using AdminUser.Services.Abstract;
using AdminUser.Services.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdminUser.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        AdminUserManager AdminUserService = new AdminUserManager( new EFAdminRepository() );

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Admin> admins = AdminUserService.GetList();
            return Ok(admins);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Admin admin = AdminUserService.GetById(id);
            if (admin == null || admin.IsDeleted==false)
            {
                return NotFound("Admin cannot found !");
            }
            else
            {
                return Ok(admin);
            }
        }

        [HttpPost]
        public IActionResult Create(Admin admin)
        {
            AdminUserService.AdminAdd(admin);
            return Ok(admin);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            AdminUserService.AdminDelete(id);
            return Ok("Admin deleted succesfully!");
        }

        [HttpPut]
        public IActionResult Put(Admin admin)
        {
            AdminUserService.AdminUpdate(admin);
            return Ok(admin);
        }
    }
}

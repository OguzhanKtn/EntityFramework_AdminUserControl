using AdminUser.DataAccess.Abstract;
using AdminUser.DataAccess.EntityFramework;
using AdminUser.Dto.Response;
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
        AdminUserManager AdminUserService;

        public AdminController()
        {
            AdminUserService = new AdminUserManager(new EFAdminRepository());
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<GetAllAdminResponse> response = AdminUserService.GetList().Select(q=>new GetAllAdminResponse
            {
                Id = q.Id,     
                FirstName = q.FirstName,
                Surname = q.Surname,
                Email = q.Email
            }).ToList(); 

            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Admin admin = AdminUserService.GetById(id);

            if (admin == null)
            {
                return NotFound("Admin cannot found !");
            }
            else
            {
                GetUserByIdResponse response = new GetUserByIdResponse();
                response.Id = admin.Id;
                response.FirstName = admin.FirstName;
                response.Surname = admin.Surname;
                response.Email = admin.Email;

                return Ok(response);
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

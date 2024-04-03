using AdminUser.Models;
using Microsoft.EntityFrameworkCore;

namespace AdminUser.DataAccess.EntityFramework
{
    public class UserContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-S5STNHF;Database=AdminUserDB;Trusted_Connection=True;TrustServerCertificate=True");
        }

        public DbSet<Admin> AdminUsers { get; set; }
    }
}

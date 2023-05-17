using Microsoft.EntityFrameworkCore;
using UserAPI.Data.Map;
using UserAPI.Models;

namespace UserAPI.Data
{
    public class UserDBContext : DbContext
    {
        public UserDBContext(DbContextOptions<UserDBContext> options) : base(options) 
        { 
        }

        public DbSet<UserModel> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap()); 

            base.OnModelCreating(modelBuilder);
        }
    }
}

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using my_new_app.Models;

namespace my_new_app.Data
{
 public class ApplicationDbContext : IdentityDbContext<ApplicationUser, Role, int, IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //========================================================================
            // Tên bảng cho các bảng identity
            builder.Entity<ApplicationUser>().ToTable("Users");
            builder.Entity<Role>().ToTable("Roles");
            builder.Entity<IdentityUserToken<int>>().ToTable("UserTokens");
            builder.Entity<IdentityRoleClaim<int>>().ToTable("RoleClaims");
            builder.Entity<UserRole>().ToTable("UserRoles");
            builder.Entity<IdentityUserClaim<int>>().ToTable("UserClaims");
            builder.Entity<IdentityUserLogin<int>>().ToTable("UserLogins");

            //========================================================================
            // 
            // builder.Entity<Bank>()
            //     .HasMany(c => c.Spending_Details)
            //     .WithOne(e => e.Bank);
        }

        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<Spending> Spendings { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Spending_Detail> Spending_Details { get; set; }
        
    }
}
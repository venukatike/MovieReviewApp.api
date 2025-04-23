using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieReviewApp.api.Models;

namespace MovieReviewApp.api.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<int>, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>().ToTable("Users");
            builder.Entity<IdentityRole>().ToTable("Roles");
            builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");
            builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");

            builder.Entity<ApplicationUser>().Property(u => u.UserName).HasColumnName("UserName");
            builder.Entity<ApplicationUser>().Property(u => u.Email).HasColumnName("Email");
            builder.Entity<ApplicationUser>().Property(u => u.PasswordHash).HasColumnName("PasswordHash");
            builder.Entity<ApplicationUser>().Property(u => u.NormalizedUserName).HasColumnName("UserName");

            builder.Entity<ApplicationUser>().Ignore(u => u.PhoneNumber );
            builder.Entity<ApplicationUser>().Ignore(u => u.TwoFactorEnabled);
            builder.Entity<ApplicationUser>().Ignore(u => u.LockoutEnabled);
            builder.Entity<ApplicationUser>().Ignore(u => u.AccessFailedCount);
            builder.Entity<ApplicationUser>().Ignore(u => u.LockoutEnd);
            builder.Entity<ApplicationUser>().Ignore(u => u.EmailConfirmed);
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}

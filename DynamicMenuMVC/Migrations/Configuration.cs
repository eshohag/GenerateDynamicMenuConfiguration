namespace DynamicMenuMVC.Migrations
{
    using DynamicMenuMvc.AuthConfig;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Microsoft.AspNetCore.Identity;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<DynamicMenuMVC.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DynamicMenuMVC.Models.ApplicationDbContext context)
        {
            var hasher = new PasswordHasher<IdentityUser>();

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Roles.AddOrUpdate(
            p => p.Name,
            new IdentityRole { Id = "f3db4018-d024-4bf4-a750-c3fa8d18a9f5", Name = "Admin" },
            new IdentityRole { Id = "1f648edf-ad0e-42df-9667-a093e5d53d89", Name = "Manager" },
            new IdentityRole { Id = "bbc378b1-e0b3-4bbb-ad6a-14a8acbea2da", Name = "Customer" }
          );

            context.Users.AddOrUpdate(
              p => p.UserName,
              new AppUser { Id = "3fc7aee1-21e1-44fb-a0c5-b99257acdbdf", Email = "eshohag@outlook.com", UserName = "eshohag", PhoneNumber = "01926029000", PasswordHash = hasher.HashPassword(null, "123456") },
              new AppUser { Id = "ed73d7b5-08d5-4ba0-aa8e-4d609d611157", Email = "sayed@outlook.com", UserName = "esayed", PhoneNumber = "01926029001", PasswordHash = hasher.HashPassword(null, "123456") },
              new AppUser { Id = "e4aac9c7-0f38-4f25-b198-7a82beaabfc3", Email = "raju@outlook.com", UserName = "eraju", PhoneNumber = "01926029002", PasswordHash = hasher.HashPassword(null, "123456") }
            );

            context.UserRoles.AddOrUpdate(
            new IdentityUserRole { UserId = "3fc7aee1-21e1-44fb-a0c5-b99257acdbdf", RoleId = "f3db4018-d024-4bf4-a750-c3fa8d18a9f5" },
            new IdentityUserRole { UserId = "ed73d7b5-08d5-4ba0-aa8e-4d609d611157", RoleId = "1f648edf-ad0e-42df-9667-a093e5d53d89" },
            new IdentityUserRole { UserId = "e4aac9c7-0f38-4f25-b198-7a82beaabfc3", RoleId = "bbc378b1-e0b3-4bbb-ad6a-14a8acbea2da" }
            );
        }
    }
}

namespace DynamicMenuInMvc.Migrations
{
    using DynamicMenuInMvc.AuthConfig;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DynamicMenuInMvc.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DynamicMenuInMvc.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Roles.AddOrUpdate(
             p => p.Name,
             new Role { Id = "f3db4018-d024-4bf4-a750-c3fa8d18a9f5", Name = "Admin", IsActive = true },
             new Role { Id = "1f648edf-ad0e-42df-9667-a093e5d53d89", Name = "Manager", IsActive = true },
             new Role { Id = "bbc378b1-e0b3-4bbb-ad6a-14a8acbea2da", Name = "Customer", IsActive = true }
           );

          context.Users.AddOrUpdate(
            p => p.UserName,
            new AppUser { Id = "3fc7aee1-21e1-44fb-a0c5-b99257acdbdf", FullName = "Md Shohag Mia", Email = "eshohag@outlook.com", UserName = "eshohag", PhoneNumber = "01926029000", IsActive = true },
            new AppUser { Id = "ed73d7b5-08d5-4ba0-aa8e-4d609d611157", FullName = "Sayed Islam", Email = "sayed@outlook.com", UserName = "esayed", PhoneNumber = "01926029001", IsActive = true },
            new AppUser { Id = "e4aac9c7-0f38-4f25-b198-7a82beaabfc3", FullName = "Raju Ahmed", Email = "raju@outlook.com", UserName = "eraju", PhoneNumber = "01926029002", IsActive = true }
          );


        }
    }
}

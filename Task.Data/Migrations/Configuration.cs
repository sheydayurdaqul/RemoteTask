namespace Task.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Task.Data.Model;

    internal sealed class Configuration : DbMigrationsConfiguration<Task.Data.EFBlogContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Task.Data.EFBlogContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            //var user = new User
            //{
            //    FirstName = "admin@admin.net",
            //    LastName = "admin@admin.net",

            //};
            //user.Roles.Add(new Role { Type = "admin" });
            //context.Users.AddOrUpdate(user);


        }
    }
}

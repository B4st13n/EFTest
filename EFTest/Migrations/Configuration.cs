namespace EFTest.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EFTest.TestContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EFTest.TestContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Items.AddOrUpdate(x => x.Id,
                new Item() { Id = Guid.Parse("b0ab5519-e634-4325-a081-f9d1e946959f"), Name = "Pound Cake" },
                new Item() { Id = Guid.Parse("fc1b5836-68c9-489b-9f10-ac15de4ac165"), Name = "Egg" },
                new Item() { Id = Guid.Parse("b212bbd9-3d25-46e9-95e7-46e945e18d98"), Name = "Flour" },
                new Item() { Id = Guid.Parse("ec0b4c22-ee36-48d0-991b-0cd2079f7161"), Name = "Butter" },
                new Item() { Id = Guid.Parse("3aa9aa4e-7d82-40a5-811d-7011eb795324"), Name = "Sugar" }
                );

            context.Compositions.AddOrUpdate(x => x.Id,
                new Composition() { Id = Guid.Parse("7a171902-7e00-49ba-9271-cdcc409102fa"), ParentId = Guid.Parse("b0ab5519-e634-4325-a081-f9d1e946959f"), ChildId = Guid.Parse("fc1b5836-68c9-489b-9f10-ac15de4ac165"), Ratio = 1 },
                new Composition() { Id = Guid.Parse("6ee949fc-d2a7-4c49-8767-f786882d36e0"), ParentId = Guid.Parse("b0ab5519-e634-4325-a081-f9d1e946959f"), ChildId = Guid.Parse("b212bbd9-3d25-46e9-95e7-46e945e18d98"), Ratio = 1 },
                new Composition() { Id = Guid.Parse("4de59b26-3a37-4e49-9296-9b643a041b6a"), ParentId = Guid.Parse("b0ab5519-e634-4325-a081-f9d1e946959f"), ChildId = Guid.Parse("ec0b4c22-ee36-48d0-991b-0cd2079f7161"), Ratio = 1 },
                new Composition() { Id = Guid.Parse("69bff9a3-a919-4f4f-9608-4c10df810142"), ParentId = Guid.Parse("b0ab5519-e634-4325-a081-f9d1e946959f"), ChildId = Guid.Parse("3aa9aa4e-7d82-40a5-811d-7011eb795324"), Ratio = 1 }
                );
        }
    }
}

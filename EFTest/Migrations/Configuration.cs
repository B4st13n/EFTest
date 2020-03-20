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
                new Item() { Id = Guid.Parse("798cd9f1-2cbf-470f-814f-e639629a2bba"), Name = "Pancakes" },
                new Item() { Id = Guid.Parse("fc1b5836-68c9-489b-9f10-ac15de4ac165"), Name = "Egg" },
                new Item() { Id = Guid.Parse("b212bbd9-3d25-46e9-95e7-46e945e18d98"), Name = "Flour" },
                new Item() { Id = Guid.Parse("ec0b4c22-ee36-48d0-991b-0cd2079f7161"), Name = "Butter" },
                new Item() { Id = Guid.Parse("3aa9aa4e-7d82-40a5-811d-7011eb795324"), Name = "Sugar" },
                new Item() { Id = Guid.Parse("beefdd35-2ffb-4476-b555-a879b2fd9ae9"), Name = "Milk" },
                new Item() { Id = Guid.Parse("87dace4c-3c61-4627-a0de-74ff1c3924e2"), Name = "Oil" }
                );

            context.Compositions.AddOrUpdate(x => x.Id,
                new Composition() { Id = Guid.Parse("7a171902-7e00-49ba-9271-cdcc409102fa"), ParentId = Guid.Parse("b0ab5519-e634-4325-a081-f9d1e946959f"), ChildId = Guid.Parse("fc1b5836-68c9-489b-9f10-ac15de4ac165"), Ratio = 1 },
                new Composition() { Id = Guid.Parse("6ee949fc-d2a7-4c49-8767-f786882d36e0"), ParentId = Guid.Parse("b0ab5519-e634-4325-a081-f9d1e946959f"), ChildId = Guid.Parse("b212bbd9-3d25-46e9-95e7-46e945e18d98"), Ratio = 1 },
                new Composition() { Id = Guid.Parse("4de59b26-3a37-4e49-9296-9b643a041b6a"), ParentId = Guid.Parse("b0ab5519-e634-4325-a081-f9d1e946959f"), ChildId = Guid.Parse("ec0b4c22-ee36-48d0-991b-0cd2079f7161"), Ratio = 1 },
                new Composition() { Id = Guid.Parse("69bff9a3-a919-4f4f-9608-4c10df810142"), ParentId = Guid.Parse("b0ab5519-e634-4325-a081-f9d1e946959f"), ChildId = Guid.Parse("3aa9aa4e-7d82-40a5-811d-7011eb795324"), Ratio = 1 },
                new Composition() { Id = Guid.Parse("4d0287f8-7cdc-4af3-9955-1ae9d3bd4d18"), ParentId = Guid.Parse("798cd9f1-2cbf-470f-814f-e639629a2bba"), ChildId = Guid.Parse("fc1b5836-68c9-489b-9f10-ac15de4ac165"), Ratio = 1 },
                new Composition() { Id = Guid.Parse("4143536b-ed02-48e4-98e5-52ca37b65c9a"), ParentId = Guid.Parse("798cd9f1-2cbf-470f-814f-e639629a2bba"), ChildId = Guid.Parse("b212bbd9-3d25-46e9-95e7-46e945e18d98"), Ratio = 4 },
                new Composition() { Id = Guid.Parse("c0e3a77d-2367-4171-a861-9071732a6083"), ParentId = Guid.Parse("798cd9f1-2cbf-470f-814f-e639629a2bba"), ChildId = Guid.Parse("beefdd35-2ffb-4476-b555-a879b2fd9ae9"), Ratio = 2 }
                );
        }
    }
}

namespace EFTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Compositions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ParentId = c.Guid(nullable: false),
                        ChildId = c.Guid(nullable: false),
                        Ratio = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.ChildId)
                .ForeignKey("dbo.Items", t => t.ParentId)
                .Index(t => t.ParentId)
                .Index(t => t.ChildId);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Compositions", "ParentId", "dbo.Items");
            DropForeignKey("dbo.Compositions", "ChildId", "dbo.Items");
            DropIndex("dbo.Compositions", new[] { "ChildId" });
            DropIndex("dbo.Compositions", new[] { "ParentId" });
            DropTable("dbo.Items");
            DropTable("dbo.Compositions");
        }
    }
}

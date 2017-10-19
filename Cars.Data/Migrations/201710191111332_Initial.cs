namespace Cars.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OwnerId = c.Int(),
                        ModelId = c.Int(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CarModels", t => t.ModelId)
                .ForeignKey("dbo.Owners", t => t.OwnerId)
                .Index(t => t.OwnerId)
                .Index(t => t.ModelId);
            
            CreateTable(
                "dbo.Owners",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "OwnerId", "dbo.Owners");
            DropForeignKey("dbo.Cars", "ModelId", "dbo.CarModels");
            DropIndex("dbo.Cars", new[] { "ModelId" });
            DropIndex("dbo.Cars", new[] { "OwnerId" });
            DropTable("dbo.Owners");
            DropTable("dbo.Cars");
            DropTable("dbo.CarModels");
        }
    }
}

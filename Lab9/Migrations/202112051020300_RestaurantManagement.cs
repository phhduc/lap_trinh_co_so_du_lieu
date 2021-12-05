namespace Lab9.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RestaurantManagement : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Food",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                        Unit = c.String(),
                        FoodCategoryId = c.Int(nullable: false),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Category", t => t.FoodCategoryId, cascadeDelete: true)
                .Index(t => t.FoodCategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Food", "FoodCategoryId", "dbo.Category");
            DropIndex("dbo.Food", new[] { "FoodCategoryId" });
            DropTable("dbo.Food");
            DropTable("dbo.Category");
        }
    }
}

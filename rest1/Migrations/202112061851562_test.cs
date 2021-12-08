namespace rest1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.departments",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        curator = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.products",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        name = c.String(),
                        price = c.String(),
                        department = c.Int(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.productdepartments",
                c => new
                    {
                        product_id = c.String(nullable: false, maxLength: 128),
                        department_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.product_id, t.department_id })
                .ForeignKey("dbo.products", t => t.product_id, cascadeDelete: true)
                .ForeignKey("dbo.departments", t => t.department_id, cascadeDelete: true)
                .Index(t => t.product_id)
                .Index(t => t.department_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.productdepartments", "department_id", "dbo.departments");
            DropForeignKey("dbo.productdepartments", "product_id", "dbo.products");
            DropIndex("dbo.productdepartments", new[] { "department_id" });
            DropIndex("dbo.productdepartments", new[] { "product_id" });
            DropTable("dbo.productdepartments");
            DropTable("dbo.products");
            DropTable("dbo.departments");
        }
    }
}

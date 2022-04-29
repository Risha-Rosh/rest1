namespace rest1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            AddColumn("products", "departments", x => x.String());
            CreateTable(
                  "dbo.department",
                  c => new
                  {
                      id = c.Int(nullable: false, identity: true),
                      name = c.String(),
                      curator = c.String(),
                  })
                  .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.product",
                c => new
                {
                    id = c.String(nullable: false, maxLength: 128),
                    name = c.String(),
                    price = c.String(),
                    department = c.Int(),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.productdepartment",
                c => new
                {
                    product_id = c.String(nullable: false, maxLength: 128),
                    department_id = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.product_id, t.department_id })
                .ForeignKey("dbo.product", t => t.product_id, cascadeDelete: true)
                .ForeignKey("dbo.department", t => t.department_id, cascadeDelete: true)
                .Index(t => t.product_id)
                .Index(t => t.department_id);

        }

        public override void Down()
        {
            DropColumn("products", "departments");
            DropForeignKey("dbo.productdepartment", "department_id", "dbo.department");
            DropForeignKey("dbo.productdepartment", "product_id", "dbo.product");
            DropIndex("dbo.productdepartment", new[] { "department_id" });
            DropIndex("dbo.productdepartment", new[] { "product_id" });
            DropTable("dbo.productdepartment");
            DropTable("dbo.product");
            DropTable("dbo.department");
        }
    }
}

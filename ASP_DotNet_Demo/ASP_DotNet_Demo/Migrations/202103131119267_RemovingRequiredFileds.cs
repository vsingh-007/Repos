namespace ASP_DotNet_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovingRequiredFileds : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Gender", c => c.String());
            AlterColumn("dbo.Customers", "Address", c => c.String());
            AlterColumn("dbo.Customers", "Email", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Gender", c => c.String(nullable: false));
        }
    }
}

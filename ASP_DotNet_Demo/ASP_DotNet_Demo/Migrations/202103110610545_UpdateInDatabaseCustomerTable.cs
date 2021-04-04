namespace ASP_DotNet_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateInDatabaseCustomerTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "DOB", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 20));
            DropColumn("dbo.Customers", "DOB");
        }
    }
}

namespace HotelManagementApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenderFixed : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Gender", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Gender");
        }
    }
}

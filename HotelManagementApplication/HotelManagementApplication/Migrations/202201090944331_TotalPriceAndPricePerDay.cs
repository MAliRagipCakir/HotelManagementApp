namespace HotelManagementApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TotalPriceAndPricePerDay : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rooms", "PricePerDay", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Rooms", "Price");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rooms", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Rooms", "PricePerDay");
        }
    }
}

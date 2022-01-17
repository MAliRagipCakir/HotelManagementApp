namespace HotelManagementApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false, maxLength: 30),
                        IdentityNumber = c.String(nullable: false, maxLength: 11),
                        PhoneNumber = c.String(),
                        BirthDate = c.DateTime(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CheckInDate = c.DateTime(nullable: false),
                        CheckOutDate = c.DateTime(nullable: false),
                        CheckInTime = c.DateTime(),
                        CheckOutTime = c.DateTime(),
                        RoomId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .Index(t => t.RoomId);
            
            CreateTable(
                "dbo.ReservationServices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ServiceName = c.String(),
                        ServiceTotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ServiceId = c.Int(nullable: false),
                        ReservationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Reservations", t => t.ReservationId, cascadeDelete: true)
                .ForeignKey("dbo.Services", t => t.ServiceId, cascadeDelete: true)
                .Index(t => t.ServiceId)
                .Index(t => t.ReservationId);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ServiceName = c.String(),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoomName = c.String(nullable: false, maxLength: 15),
                        Capacity = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Features",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FeatureName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ReservationCustomers",
                c => new
                    {
                        Reservation_Id = c.Int(nullable: false),
                        Customer_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Reservation_Id, t.Customer_Id })
                .ForeignKey("dbo.Reservations", t => t.Reservation_Id, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.Customer_Id, cascadeDelete: true)
                .Index(t => t.Reservation_Id)
                .Index(t => t.Customer_Id);
            
            CreateTable(
                "dbo.FeatureRooms",
                c => new
                    {
                        Feature_Id = c.Int(nullable: false),
                        Room_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Feature_Id, t.Room_Id })
                .ForeignKey("dbo.Features", t => t.Feature_Id, cascadeDelete: true)
                .ForeignKey("dbo.Rooms", t => t.Room_Id, cascadeDelete: true)
                .Index(t => t.Feature_Id)
                .Index(t => t.Room_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.FeatureRooms", "Room_Id", "dbo.Rooms");
            DropForeignKey("dbo.FeatureRooms", "Feature_Id", "dbo.Features");
            DropForeignKey("dbo.ReservationServices", "ServiceId", "dbo.Services");
            DropForeignKey("dbo.ReservationServices", "ReservationId", "dbo.Reservations");
            DropForeignKey("dbo.ReservationCustomers", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.ReservationCustomers", "Reservation_Id", "dbo.Reservations");
            DropIndex("dbo.FeatureRooms", new[] { "Room_Id" });
            DropIndex("dbo.FeatureRooms", new[] { "Feature_Id" });
            DropIndex("dbo.ReservationCustomers", new[] { "Customer_Id" });
            DropIndex("dbo.ReservationCustomers", new[] { "Reservation_Id" });
            DropIndex("dbo.ReservationServices", new[] { "ReservationId" });
            DropIndex("dbo.ReservationServices", new[] { "ServiceId" });
            DropIndex("dbo.Reservations", new[] { "RoomId" });
            DropTable("dbo.FeatureRooms");
            DropTable("dbo.ReservationCustomers");
            DropTable("dbo.Features");
            DropTable("dbo.Rooms");
            DropTable("dbo.Services");
            DropTable("dbo.ReservationServices");
            DropTable("dbo.Reservations");
            DropTable("dbo.Customers");
        }
    }
}

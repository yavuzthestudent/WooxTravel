namespace Project2WooxTravel_New.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Admins",
                c => new
                    {
                        AdminID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        Name = c.String(),
                        Surname = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.AdminID);
            
            CreateTable(
                "public.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(maxLength: 100),
                        CategoryStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "public.Contacts",
                c => new
                    {
                        ContactId = c.Int(nullable: false, identity: true),
                        Phone = c.Int(nullable: false),
                        Email = c.String(),
                        Address = c.String(),
                        MapLocation = c.String(),
                    })
                .PrimaryKey(t => t.ContactId);
            
            CreateTable(
                "public.Destinations",
                c => new
                    {
                        DestinationId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Country = c.String(),
                        City = c.String(),
                        DayNight = c.Int(nullable: false),
                        ImageUrl = c.String(),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Capacity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DestinationId);
            
            CreateTable(
                "public.Messages",
                c => new
                    {
                        MessageID = c.Int(nullable: false, identity: true),
                        SenderMail = c.String(),
                        ReceiverMail = c.String(),
                        Subject = c.String(),
                        Content = c.String(),
                        SendDate = c.DateTime(nullable: false),
                        IsRead = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MessageID);
            
            CreateTable(
                "public.Reservations",
                c => new
                    {
                        ReservationId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Phone = c.String(),
                        PersonCount = c.Int(nullable: false),
                        ReservationDate = c.DateTime(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ReservationId);
            
        }
        
        public override void Down()
        {
            DropTable("public.Reservations");
            DropTable("public.Messages");
            DropTable("public.Destinations");
            DropTable("public.Contacts");
            DropTable("public.Categories");
            DropTable("public.Admins");
        }
    }
}

namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRoomsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roooms",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Room_id = c.Int(nullable: false),
                        place_in = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            DropTable("dbo.Rooms");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        room_id = c.Int(nullable: false, identity: true),
                        place_in = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.room_id);
            
            DropTable("dbo.Roooms");
        }
    }
}

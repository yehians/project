namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableeTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tables",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Table_name = c.String(),
                        Char_number = c.Int(nullable: false),
                        Avilibality = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tables");
        }
    }
}

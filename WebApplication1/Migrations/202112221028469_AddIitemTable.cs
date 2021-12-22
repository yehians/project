namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIitemTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Iitems",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name_Item = c.String(),
                        price = c.Int(nullable: false),
                        Is_aviliblity = c.Boolean(nullable: false),
                        Image = c.String(),
                        Description = c.String(),
                        age_limitiation = c.Int(nullable: false),
                        Dish_of_the_day = c.Boolean(nullable: false),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Iitems");
        }
    }
}

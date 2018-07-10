namespace WpfApp2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class elo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        image = c.String(),
                        name = c.String(nullable: false),
                        surname = c.String(nullable: false),
                        street = c.String(nullable: false),
                        house = c.String(nullable: false),
                        zip = c.String(nullable: false),
                        height = c.Double(nullable: false),
                        weight = c.Double(nullable: false),
                        sex = c.Int(nullable: false),
                        additional = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
        }
    }
}

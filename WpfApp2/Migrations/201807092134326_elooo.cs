namespace WpfApp2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class elooo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "city", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "city");
        }
    }
}

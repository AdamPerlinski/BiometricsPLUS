namespace WpfApp2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eloo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "number", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "number");
        }
    }
}

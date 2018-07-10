namespace WpfApp2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eloooo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "sex", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "sex", c => c.Int(nullable: false));
        }
    }
}

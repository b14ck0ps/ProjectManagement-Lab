namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class statusTypeChanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Projects", "Status", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Projects", "Status", c => c.Boolean(nullable: false));
        }
    }
}

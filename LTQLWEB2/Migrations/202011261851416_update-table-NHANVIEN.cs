namespace LTQLWEB2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetableNHANVIEN : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.NHANVIENs", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NHANVIENs", "Email", c => c.String());
        }
    }
}

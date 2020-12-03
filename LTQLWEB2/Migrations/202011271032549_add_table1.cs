namespace LTQLWEB2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_table1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.KHACHHANGs", "Email", c => c.String(nullable: false));
            AddColumn("dbo.KHACHHANGs", "PassWord", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.KHACHHANGs", "PassWord");
            DropColumn("dbo.KHACHHANGs", "Email");
        }
    }
}

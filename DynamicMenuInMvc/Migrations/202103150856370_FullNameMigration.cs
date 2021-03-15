namespace DynamicMenuInMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FullNameMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "FullName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "FullName");
        }
    }
}

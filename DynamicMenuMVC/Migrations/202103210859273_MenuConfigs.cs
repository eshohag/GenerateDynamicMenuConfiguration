namespace DynamicMenuMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MenuConfigs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MenuConfigs", "DisplayText", c => c.String());
            AddColumn("dbo.MenuConfigs", "Icon", c => c.String());
            AddColumn("dbo.MenuConfigs", "IsActive", c => c.Boolean(nullable: false));
            DropColumn("dbo.MenuConfigs", "nameOption");
            DropColumn("dbo.MenuConfigs", "imageClass");
            DropColumn("dbo.MenuConfigs", "activeli");
            DropColumn("dbo.MenuConfigs", "estatus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MenuConfigs", "estatus", c => c.Boolean(nullable: false));
            AddColumn("dbo.MenuConfigs", "activeli", c => c.String());
            AddColumn("dbo.MenuConfigs", "imageClass", c => c.String());
            AddColumn("dbo.MenuConfigs", "nameOption", c => c.String());
            DropColumn("dbo.MenuConfigs", "IsActive");
            DropColumn("dbo.MenuConfigs", "Icon");
            DropColumn("dbo.MenuConfigs", "DisplayText");
        }
    }
}

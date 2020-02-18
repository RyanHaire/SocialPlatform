namespace SocialPlatform.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedConfirmpPassword : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Password", c => c.String(nullable: false));
            AddColumn("dbo.Users", "ConfirmPassword", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "ConfirmPassword");
            DropColumn("dbo.Users", "Password");
        }
    }
}

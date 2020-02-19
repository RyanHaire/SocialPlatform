namespace SocialPlatform.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedForeignKeyToSessionToken : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comments", "PostId", "dbo.Posts");
            DropForeignKey("dbo.Posts", "UserId", "dbo.Users");
            DropForeignKey("dbo.Messages", "UserId", "dbo.Users");
            DropIndex("dbo.Comments", new[] { "PostId" });
            DropIndex("dbo.Posts", new[] { "UserId" });
            DropIndex("dbo.Messages", new[] { "UserId" });
            RenameColumn(table: "dbo.Comments", name: "PostId", newName: "Post_Id");
            RenameColumn(table: "dbo.Posts", name: "UserId", newName: "User_Id");
            RenameColumn(table: "dbo.Messages", name: "UserId", newName: "User_Id");
            AddColumn("dbo.Users", "SessionTokenId", c => c.Int(nullable: false));
            AlterColumn("dbo.Comments", "Post_Id", c => c.Int());
            AlterColumn("dbo.Posts", "User_Id", c => c.Int());
            AlterColumn("dbo.Messages", "User_Id", c => c.Int());
            CreateIndex("dbo.Comments", "Post_Id");
            CreateIndex("dbo.Posts", "User_Id");
            CreateIndex("dbo.Messages", "User_Id");
            AddForeignKey("dbo.Comments", "Post_Id", "dbo.Posts", "Id");
            AddForeignKey("dbo.Posts", "User_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Messages", "User_Id", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Messages", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Posts", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Comments", "Post_Id", "dbo.Posts");
            DropIndex("dbo.Messages", new[] { "User_Id" });
            DropIndex("dbo.Posts", new[] { "User_Id" });
            DropIndex("dbo.Comments", new[] { "Post_Id" });
            AlterColumn("dbo.Messages", "User_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Posts", "User_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Comments", "Post_Id", c => c.Int(nullable: false));
            DropColumn("dbo.Users", "SessionTokenId");
            RenameColumn(table: "dbo.Messages", name: "User_Id", newName: "UserId");
            RenameColumn(table: "dbo.Posts", name: "User_Id", newName: "UserId");
            RenameColumn(table: "dbo.Comments", name: "Post_Id", newName: "PostId");
            CreateIndex("dbo.Messages", "UserId");
            CreateIndex("dbo.Posts", "UserId");
            CreateIndex("dbo.Comments", "PostId");
            AddForeignKey("dbo.Messages", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Posts", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Comments", "PostId", "dbo.Posts", "Id", cascadeDelete: true);
        }
    }
}

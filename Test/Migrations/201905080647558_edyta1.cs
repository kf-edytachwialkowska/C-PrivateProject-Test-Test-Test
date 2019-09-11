namespace Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edyta1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.ProductViewModels");
            AddColumn("dbo.ProductViewModels", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.ProductViewModels", "Name", c => c.String(nullable: false));
            AddPrimaryKey("dbo.ProductViewModels", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.ProductViewModels");
            AlterColumn("dbo.ProductViewModels", "Name", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.ProductViewModels", "Id");
            AddPrimaryKey("dbo.ProductViewModels", "Name");
        }
    }
}

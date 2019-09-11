namespace Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edyta : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.ProductViewModels");
            AlterColumn("dbo.ProductViewModels", "Name", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.ProductViewModels", "Name");
            DropColumn("dbo.ProductViewModels", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductViewModels", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.ProductViewModels");
            AlterColumn("dbo.ProductViewModels", "Name", c => c.String());
            AddPrimaryKey("dbo.ProductViewModels", "Id");
        }
    }
}

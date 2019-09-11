namespace Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial4 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.ProductViewModels");
            AlterColumn("dbo.ProductViewModels", "Name", c => c.String());
            AlterColumn("dbo.ProductViewModels", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.ProductViewModels", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.ProductViewModels");
            AlterColumn("dbo.ProductViewModels", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.ProductViewModels", "Name", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.ProductViewModels", "Name");
        }
    }
}

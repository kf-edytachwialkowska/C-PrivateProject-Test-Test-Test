namespace Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edyta2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductViewModels", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProductViewModels", "Description");
        }
    }
}

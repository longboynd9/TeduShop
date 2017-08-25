namespace TeduShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialDB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PostTags", "ABC", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PostTags", "ABC");
        }
    }
}

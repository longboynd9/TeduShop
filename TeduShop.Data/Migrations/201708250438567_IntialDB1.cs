namespace TeduShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialDB1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.PostTags", "ABC");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PostTags", "ABC", c => c.String());
        }
    }
}

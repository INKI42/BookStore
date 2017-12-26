namespace BookStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelsUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "FullName", c => c.String());
            AddColumn("dbo.Books", "Genre", c => c.String());
            DropColumn("dbo.Authors", "FirstName");
            DropColumn("dbo.Authors", "LastName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Authors", "LastName", c => c.String());
            AddColumn("dbo.Authors", "FirstName", c => c.String());
            DropColumn("dbo.Books", "Genre");
            DropColumn("dbo.Authors", "FullName");
        }
    }
}

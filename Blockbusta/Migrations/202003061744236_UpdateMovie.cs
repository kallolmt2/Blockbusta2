namespace Blockbusta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "GenreName", c => c.Byte(nullable: false));
            DropColumn("dbo.Movies", "GenreId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "GenreId", c => c.Byte(nullable: false));
            DropColumn("dbo.Movies", "GenreName");
        }
    }
}

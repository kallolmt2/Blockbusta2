namespace Blockbusta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NamedMembershipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}

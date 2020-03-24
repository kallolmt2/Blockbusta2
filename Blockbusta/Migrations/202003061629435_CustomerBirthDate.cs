namespace Blockbusta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerBirthDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BirthDate", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "BirthDate");
        }
    }
}

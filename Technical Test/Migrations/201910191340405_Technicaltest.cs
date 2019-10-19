namespace Technical_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Technicaltest : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Labours", "Cost", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Labours", "Cost", c => c.Int(nullable: false));
        }
    }
}

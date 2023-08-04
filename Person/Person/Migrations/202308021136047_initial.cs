namespace Person.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EntryMobilities", "Kod", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EntryMobilities", "Kod", c => c.Int(nullable: false));
        }
    }
}

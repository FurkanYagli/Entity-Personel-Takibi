namespace Person.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authorities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Aktif = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Aktif = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EntryMobilities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KullaniciId = c.Int(nullable: false),
                        Tarih = c.DateTime(nullable: false),
                        Kod = c.Int(nullable: false),
                        Ad = c.String(),
                        Aktif = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Aktif = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Logs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KullaniciId = c.Int(nullable: false),
                        SayfaId = c.Int(nullable: false),
                        IslemId = c.Int(nullable: false),
                        Tarih = c.DateTime(nullable: false),
                        Ad = c.String(),
                        Aktif = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Aktif = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Persons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Soyad = c.String(),
                        SehirId = c.Int(nullable: false),
                        MeslekId = c.Int(nullable: false),
                        Maas = c.Int(nullable: false),
                        Ad = c.String(),
                        Aktif = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Processes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Aktif = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StaffMobilities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KullaniciId = c.Int(nullable: false),
                        PersonelId = c.Int(nullable: false),
                        IslemId = c.Int(nullable: false),
                        Tarih = c.DateTime(nullable: false),
                        Ad = c.String(),
                        Aktif = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Soyad = c.String(),
                        TC = c.String(),
                        Tel = c.String(),
                        YetkiId = c.Int(nullable: false),
                        Ad = c.String(),
                        Aktif = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.StaffMobilities");
            DropTable("dbo.Processes");
            DropTable("dbo.Persons");
            DropTable("dbo.Pages");
            DropTable("dbo.Logs");
            DropTable("dbo.Jobs");
            DropTable("dbo.EntryMobilities");
            DropTable("dbo.Cities");
            DropTable("dbo.Authorities");
        }
    }
}

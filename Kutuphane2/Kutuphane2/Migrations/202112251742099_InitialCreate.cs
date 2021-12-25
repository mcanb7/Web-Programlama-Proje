namespace Kutuphane2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategori",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KategoriAdi = c.String(nullable: false, maxLength: 15, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Kitap",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KitapAdi = c.String(nullable: false, maxLength: 30, unicode: false),
                        StokAdet = c.Int(nullable: false),
                        EklenmeTarihi = c.DateTime(nullable: false),
                        YazarId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Yazar", t => t.YazarId, cascadeDelete: true)
                .Index(t => t.YazarId);
            
            CreateTable(
                "dbo.Yazar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        YazarAdi = c.String(nullable: false, maxLength: 15, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OduncAl",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KitapId = c.Int(nullable: false),
                        UyeId = c.Int(nullable: false),
                        AlisTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Uye", t => t.UyeId, cascadeDelete: true)
                .Index(t => t.UyeId);
            
            CreateTable(
                "dbo.Uye",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UyeAdi = c.String(nullable: false, maxLength: 15, unicode: false),
                        UyeSoyadi = c.String(nullable: false, maxLength: 15, unicode: false),
                        Mail = c.String(nullable: false, maxLength: 8000, unicode: false),
                        Sifre = c.String(nullable: false, maxLength: 32, fixedLength: true, unicode: false),
                        KayitTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.KitapKategori",
                c => new
                    {
                        Kitap_Id = c.Int(nullable: false),
                        Kategori_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Kitap_Id, t.Kategori_Id })
                .ForeignKey("dbo.Kitap", t => t.Kitap_Id, cascadeDelete: true)
                .ForeignKey("dbo.Kategori", t => t.Kategori_Id, cascadeDelete: true)
                .Index(t => t.Kitap_Id)
                .Index(t => t.Kategori_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OduncAl", "UyeId", "dbo.Uye");
            DropForeignKey("dbo.Kitap", "YazarId", "dbo.Yazar");
            DropForeignKey("dbo.KitapKategori", "Kategori_Id", "dbo.Kategori");
            DropForeignKey("dbo.KitapKategori", "Kitap_Id", "dbo.Kitap");
            DropIndex("dbo.KitapKategori", new[] { "Kategori_Id" });
            DropIndex("dbo.KitapKategori", new[] { "Kitap_Id" });
            DropIndex("dbo.OduncAl", new[] { "UyeId" });
            DropIndex("dbo.Kitap", new[] { "YazarId" });
            DropTable("dbo.KitapKategori");
            DropTable("dbo.Uye");
            DropTable("dbo.OduncAl");
            DropTable("dbo.Yazar");
            DropTable("dbo.Kitap");
            DropTable("dbo.Kategori");
        }
    }
}

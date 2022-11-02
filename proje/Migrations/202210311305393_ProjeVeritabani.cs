namespace proje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProjeVeritabani : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.birims",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Birim = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.harekets",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Hareket = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.kisis",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ad = c.String(),
                        soyad = c.String(),
                        email = c.String(),
                        modid = c.Int(nullable: false),
                        hareketid = c.Int(nullable: false),
                        teslimatid = c.Int(nullable: false),
                        paketid = c.Int(nullable: false),
                        birimid = c.Int(nullable: false),
                        uniteid = c.Int(nullable: false),
                        paraid = c.Int(nullable: false),
                        sehirid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.birims", t => t.birimid, cascadeDelete: true)
                .ForeignKey("dbo.harekets", t => t.hareketid, cascadeDelete: true)
                .ForeignKey("dbo.mods", t => t.modid, cascadeDelete: true)
                .ForeignKey("dbo.pakets", t => t.paketid, cascadeDelete: true)
                .ForeignKey("dbo.paras", t => t.paraid, cascadeDelete: true)
                .ForeignKey("dbo.sehirs", t => t.sehirid, cascadeDelete: true)
                .ForeignKey("dbo.teslimats", t => t.teslimatid, cascadeDelete: true)
                .ForeignKey("dbo.unites", t => t.uniteid, cascadeDelete: true)
                .Index(t => t.modid)
                .Index(t => t.hareketid)
                .Index(t => t.teslimatid)
                .Index(t => t.paketid)
                .Index(t => t.birimid)
                .Index(t => t.uniteid)
                .Index(t => t.paraid)
                .Index(t => t.sehirid);
            
            CreateTable(
                "dbo.mods",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Mod = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.pakets",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Paket = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.paras",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Para = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.sehirs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Sehiradi = c.String(),
                        Ulke = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.teslimats",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Teslimat = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.unites",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Unite = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.kisis", "uniteid", "dbo.unites");
            DropForeignKey("dbo.kisis", "teslimatid", "dbo.teslimats");
            DropForeignKey("dbo.kisis", "sehirid", "dbo.sehirs");
            DropForeignKey("dbo.kisis", "paraid", "dbo.paras");
            DropForeignKey("dbo.kisis", "paketid", "dbo.pakets");
            DropForeignKey("dbo.kisis", "modid", "dbo.mods");
            DropForeignKey("dbo.kisis", "hareketid", "dbo.harekets");
            DropForeignKey("dbo.kisis", "birimid", "dbo.birims");
            DropIndex("dbo.kisis", new[] { "sehirid" });
            DropIndex("dbo.kisis", new[] { "paraid" });
            DropIndex("dbo.kisis", new[] { "uniteid" });
            DropIndex("dbo.kisis", new[] { "birimid" });
            DropIndex("dbo.kisis", new[] { "paketid" });
            DropIndex("dbo.kisis", new[] { "teslimatid" });
            DropIndex("dbo.kisis", new[] { "hareketid" });
            DropIndex("dbo.kisis", new[] { "modid" });
            DropTable("dbo.unites");
            DropTable("dbo.teslimats");
            DropTable("dbo.sehirs");
            DropTable("dbo.paras");
            DropTable("dbo.pakets");
            DropTable("dbo.mods");
            DropTable("dbo.kisis");
            DropTable("dbo.harekets");
            DropTable("dbo.birims");
        }
    }
}

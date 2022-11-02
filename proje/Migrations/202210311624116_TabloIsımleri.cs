namespace proje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TabloIsımleri : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.birims", newName: "birimler");
            RenameTable(name: "dbo.harekets", newName: "hareketler");
            RenameTable(name: "dbo.kisis", newName: "kisiler");
            RenameTable(name: "dbo.mods", newName: "modlar");
            RenameTable(name: "dbo.pakets", newName: "paketler");
            RenameTable(name: "dbo.paras", newName: "paralar");
            RenameTable(name: "dbo.sehirs", newName: "sehirler");
            RenameTable(name: "dbo.teslimats", newName: "teslimatlar");
            RenameTable(name: "dbo.unites", newName: "uniteler");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.uniteler", newName: "unites");
            RenameTable(name: "dbo.teslimatlar", newName: "teslimats");
            RenameTable(name: "dbo.sehirler", newName: "sehirs");
            RenameTable(name: "dbo.paralar", newName: "paras");
            RenameTable(name: "dbo.paketler", newName: "pakets");
            RenameTable(name: "dbo.modlar", newName: "mods");
            RenameTable(name: "dbo.kisiler", newName: "kisis");
            RenameTable(name: "dbo.hareketler", newName: "harekets");
            RenameTable(name: "dbo.birimler", newName: "birims");
        }
    }
}

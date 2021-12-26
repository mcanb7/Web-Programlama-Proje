namespace Kutuphane2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUye : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Uye", "Durum");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Uye", "Durum", c => c.Int(nullable: false));
        }
    }
}

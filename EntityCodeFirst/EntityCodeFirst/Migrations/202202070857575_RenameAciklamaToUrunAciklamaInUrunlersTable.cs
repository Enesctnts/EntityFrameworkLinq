namespace EntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameAciklamaToUrunAciklamaInUrunlersTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Urunlers", "UrunAciklama", c => c.String());
            Sql("Update Urunlers Set UrunAciklama=Aciklama");
            DropColumn("dbo.Urunlers", "Aciklama");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Urunlers", "Aciklama", c => c.String());
            Sql("Update Urunlers Set Aciklama=UrunAciklama");
            DropColumn("dbo.Urunlers", "UrunAciklama");
        }
    }
}

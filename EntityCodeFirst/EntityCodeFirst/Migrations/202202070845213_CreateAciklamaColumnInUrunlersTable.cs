namespace EntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAciklamaColumnInUrunlersTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Urunlers", "Aciklama", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Urunlers", "Aciklama");
        }
    }
}

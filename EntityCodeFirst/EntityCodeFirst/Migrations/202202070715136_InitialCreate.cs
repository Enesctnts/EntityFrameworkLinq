namespace EntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Urunlers",
                c => new
                    {
                        UrunId = c.Int(nullable: false, identity: true),
                        UrunAd = c.String(),
                        UrunMarka = c.String(),
                        UrunKategori = c.String(),
                        UrunStok = c.Int(nullable: false),
                        Aciklama = c.String(),
                    })
                .PrimaryKey(t => t.UrunId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Urunlers");
        }
    }
}

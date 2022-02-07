namespace EntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMusteriSehirColumnInMusterisTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Musteris", "MusteriSehir", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Musteris", "MusteriSehir");
        }
    }
}

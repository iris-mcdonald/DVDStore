namespace DVDStore.db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FName = c.String(),
                        LName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.DVDs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Genre = c.String(),
                        Price = c.String(),
                        YearReleased = c.Int(nullable: false),
                        RunTime = c.Int(nullable: false),
                        TotalSalesCount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Summary = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.DVDActors",
                c => new
                    {
                        DVD_ID = c.Int(nullable: false),
                        Actor_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.DVD_ID, t.Actor_ID })
                .ForeignKey("dbo.DVDs", t => t.DVD_ID, cascadeDelete: true)
                .ForeignKey("dbo.Actors", t => t.Actor_ID, cascadeDelete: true)
                .Index(t => t.DVD_ID)
                .Index(t => t.Actor_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DVDActors", "Actor_ID", "dbo.Actors");
            DropForeignKey("dbo.DVDActors", "DVD_ID", "dbo.DVDs");
            DropIndex("dbo.DVDActors", new[] { "Actor_ID" });
            DropIndex("dbo.DVDActors", new[] { "DVD_ID" });
            DropTable("dbo.DVDActors");
            DropTable("dbo.DVDs");
            DropTable("dbo.Actors");
        }
    }
}

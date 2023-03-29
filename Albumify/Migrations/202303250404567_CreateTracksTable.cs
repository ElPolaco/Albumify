namespace Albumify.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTracksTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tracks",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Title = c.String(nullable: false),
                    AlbumId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id);
            AddForeignKey("dbo.Tracks", "AlbumId", "dbo.Albums");
        }
        
        public override void Down()
        {
            DropTable("dbo.Tracks");
        }
    }
}

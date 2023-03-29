namespace Albumify.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAlbumsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Author = c.String(nullable: false),
                        ReleaseDate = c.DateTime(nullable: false),
                        CoverImage = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Albums");
        }
    }
}

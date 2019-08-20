namespace Vidly.Migrations
{
		using System;
		using System.Data.Entity.Migrations;
		
		public partial class AddMovie : DbMigration
		{
				public override void Up()
				{
			DropTable("Movies");

			CreateTable(
						"dbo.Movies",
						c => new
						{
							Id = c.Int(nullable: false, identity: true),
							Name = c.String(),
							DateAdded = c.DateTime(nullable: false),
							ReleaseDate = c.DateTime(nullable: false),
							NumberInStock = c.Int(nullable: false),
							GenreId = c.Byte(nullable: false),
						})
						.PrimaryKey(t => t.Id);

			AddForeignKey("dbo.Movies", "GenreId", "dbo.Genres", "Id");
		}
				
				public override void Down()
				{
			
				}
		}
}

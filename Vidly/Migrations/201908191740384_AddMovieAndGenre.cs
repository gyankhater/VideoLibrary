namespace Vidly.Migrations
{
		using System;
		using System.Data.Entity.Migrations;
		
		public partial class AddMovieAndGenre : DbMigration
		{
				public override void Up()
				{
					CreateTable(
					"dbo.Genres",
					c => new
					{
						Id = c.Int(nullable: false, identity: true),
						Name = c.String(),
					})
					.PrimaryKey(t => t.Id);

					CreateTable(
					"dbo.Movies",
					c => new
					{
						Id = c.Int(nullable: false, identity: true),
						Name = c.String(),
						DateAdded = c.DateTime(nullable: false),
						ReleaseDate = c.DateTime(nullable: false),
						Qty = c.Int(nullable: false),
						GenreId = c.Int(nullable: false),
					})
					.PrimaryKey(t => t.Id);

					AddForeignKey("dbo.Movies", "GenreId", "dbo.Genres", "Id");
				}
				
				public override void Down()
				{
				}
		}
}

namespace Vidly.Migrations
{
		using System;
		using System.Data.Entity.Migrations;
		
		public partial class AddMovieData : DbMigration
		{
				public override void Up()
				{
					Sql("insert into Movies(Name,GenreId) values('Hangover',1)");
					Sql("insert into Movies(Name,GenreId) values('Die Hard',2)");
					Sql("insert into Movies(Name,GenreId) values('The Terminator',2)");
					Sql("insert into Movies(Name,GenreId) values('Toy Story',3)");
					Sql("insert into Movies(Name,GenreId) values('Titanic',4)");
		}
				
				public override void Down()
				{
				}
		}
}

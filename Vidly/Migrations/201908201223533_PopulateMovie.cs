namespace Vidly.Migrations
{
		using System;
		using System.Data.Entity.Migrations;
		
		public partial class PopulateMovie : DbMigration
		{
				public override void Up()
				{
					Sql("insert into Movies(Name,GenreId,ReleaseDate,DateAdded,NumberInStock) values('Hangover',1,'2019-01-10','2019-01-05',18)");
					Sql("insert into Movies(Name,GenreId,ReleaseDate,DateAdded,NumberInStock) values('Die Hard',2,'2019-02-15','2019-02-08',20)");
					Sql("insert into Movies(Name,GenreId,ReleaseDate,DateAdded,NumberInStock) values('The Terminator',2,'2019-03-20','2019-03-09',30)");
					Sql("insert into Movies(Name,GenreId,ReleaseDate,DateAdded,NumberInStock) values('Toy Story',3,'2019-04-20','2019-04-10',40)");
					Sql("insert into Movies(Name,GenreId,ReleaseDate,DateAdded,NumberInStock) values('Titanic',4,'2019-05-23','2019-05-12',40)");
				}
				
				public override void Down()
				{
				}
		}
}

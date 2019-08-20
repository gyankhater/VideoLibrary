namespace Vidly.Migrations
{
		using System;
		using System.Data.Entity.Migrations;
		
		public partial class PopulateGenreAndMovie : DbMigration
		{
				public override void Up()
				{
					Sql("insert into Genres(Name,ReleaseDate,DateAdded,Qty) values('Comedy','2019-01-10','2019-01-05',18)");
					Sql("insert into Genres(Name,ReleaseDate,DateAdded,Qty) values('Action','2019-02-15','2019-02-08',20)");
					Sql("insert into Genres(Name,ReleaseDate,DateAdded,Qty) values('Comedy','2019-03-20','2019-03-09',30)");
					Sql("insert into Genres(Name,ReleaseDate,DateAdded,Qty) values('Comedy','2019-04-20','2019-04-10',40)");
		}
				
				public override void Down()
				{
				}
		}
}

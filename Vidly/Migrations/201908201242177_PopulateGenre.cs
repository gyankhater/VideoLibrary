namespace Vidly.Migrations
{
		using System;
		using System.Data.Entity.Migrations;
		
		public partial class PopulateGenre : DbMigration
		{
				public override void Up()
				{
					Sql("insert into Genres(Name) values('Comedy')");
					Sql("insert into Genres(Name) values('Action')");
					Sql("insert into Genres(Name) values('Comedy')");
					Sql("insert into Genres(Name) values('Comedy')");
		}
				
				public override void Down()
				{
				}
		}
}

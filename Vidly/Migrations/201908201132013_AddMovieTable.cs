namespace Vidly.Migrations
{
		using System;
		using System.Data.Entity.Migrations;
		
		public partial class AddMovieTable : DbMigration
		{
				public override void Up()
				{
			Sql("drop table Movies");
				}
				
				public override void Down()
				{
				}
		}
}

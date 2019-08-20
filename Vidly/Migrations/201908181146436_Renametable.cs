namespace Vidly.Migrations
{
		using System;
		using System.Data.Entity.Migrations;
		
		public partial class Renametable : DbMigration
		{
				public override void Up()
				{
					Sql("update Customers set Birthdate='1985-12-11' where Id=1 ");
					Sql("update Customers set Birthdate=NULL where Id=2 ");
		}
				
				public override void Down()
				{
				}
		}
}

namespace Vidly.Migrations
{
		using System;
		using System.Data.Entity.Migrations;
		
		public partial class AddBirthDateToCustomer : DbMigration
		{
				public override void Up()
				{
						AddColumn("dbo.Customers", "Birthdate", c => c.DateTime(nullable: false));
						Sql("update Customers set Birthdate='1985-12-11' where Id=1 ");
				}
				
				public override void Down()
				{
						DropColumn("dbo.Customers", "Birthdate");
				}
		}
}

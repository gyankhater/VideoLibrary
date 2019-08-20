namespace Vidly.Migrations
{
		using System;
		using System.Data.Entity.Migrations;
		
		public partial class UpdateMembershipName : DbMigration
		{
				public override void Up()
				{
					Sql("Update MembershipTypes set Name=case when Id=1 then 'Pay as You Go' when Id=2 then 'Monthly' when Id=3 then 'Quartley' else 'Yearly' end");
				}
				
				public override void Down()
				{
				}
		}
}

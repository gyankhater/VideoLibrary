namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'67843df3-cd22-43f7-9b67-03bfe4f49ed8', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'03ac2cf2-c853-46e0-ab36-0773f82066ed', N'guest@vidly.com', 0, N'AHtoA8DtyZunMaq4R20lhLFNa2axlr9fIfjOaMaF0URvGhn7PINXzQCCaJBCiyCJGw==', N'f4f9cb69-92b7-4321-b518-5c85b6b84ed2', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c5d7341a-8cf6-4df6-973f-d83d4aba2907', N'admin@vidly.com', 0, N'ACPbiWtAJGt4KbHP/27oNDdmev/VxDMXpgRijUVQ31XtWTGnHMWOKKtZgPldVP3h1g==', N'1f130a13-b654-457f-babd-40a1f8e60f0a', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c5d7341a-8cf6-4df6-973f-d83d4aba2907', N'67843df3-cd22-43f7-9b67-03bfe4f49ed8')");
        }
        
        public override void Down()
        {
            
        }
    }
}

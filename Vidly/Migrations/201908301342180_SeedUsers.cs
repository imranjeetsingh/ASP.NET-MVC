namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'63b128db-577c-4f18-9977-84186f876375', N'guest@videorentalstore.com', 0, N'ANQNgaV7ep561agJ7CFosaNR5P3q8+2kJ/O5MQJMSI1p8A5Hx1hVsuJ1M6mgRbDhYQ==', N'56d53230-6ae4-46f5-9404-086ec15bc2f8', NULL, 0, 0, NULL, 1, 0, N'guest@videorentalstore.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd26106d9-1cbc-421e-95ce-580f9e260d2f', N'admin@videorentalstore.com', 0, N'APo7+zLK6MPZvtoy56XWPwLGaytY2xN0qlVz/nRzhBb73+Lrx26Yd8dE4gc+ZnhMcQ==', N'96b72573-4586-4859-a6af-edf82027c127', NULL, 0, 0, NULL, 1, 0, N'admin@videorentalstore.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'634100b1-1572-4279-adbf-6e16c03efee7', N'CanManageMovies')               
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd26106d9-1cbc-421e-95ce-580f9e260d2f', N'634100b1-1572-4279-adbf-6e16c03efee7')
                            
");
        }
        
        public override void Down()
        {
        }
    }
}

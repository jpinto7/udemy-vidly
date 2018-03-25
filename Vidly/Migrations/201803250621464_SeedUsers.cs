namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'880b993b-29ef-4eb5-b229-95f1f95c2c75', N'admin@vidly.com', 0, N'AC6FYL/RsJaNxbD8n1ceDl9imdUwRJHs/45Xie+ZM2Lyn9yy+yBHAgLRmBMMNEtNfA==', N'a0db0d29-54f0-4d79-ba54-fd11e6ad52e2', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'efa5efee-d0d1-4516-8cc7-320594d45e2e', N'guest@vidly.com', 0, N'AJQ7NbZdpOGx7GOx3PpskWlIpc+rt6wb1UMeJWpVKEuwSlXzmw+H3otjscz+Ejb2Tg==', N'a9a18ef4-f658-4af2-8686-bccbf1829d2b', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'e9620499-9bbc-4b66-b4cb-5f6d6feeb017', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'880b993b-29ef-4eb5-b229-95f1f95c2c75', N'e9620499-9bbc-4b66-b4cb-5f6d6feeb017')
            ");
        }
        
        public override void Down()
        {
        }
    }
}

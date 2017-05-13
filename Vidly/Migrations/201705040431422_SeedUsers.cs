namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'18b83999-f7bd-47ce-b8f6-ec567576a27a', N'guest@vidly.com', 0, N'AM6JHpyGorRDnynlgb6vCQFNkpR9Cdw1lHZHKAD8KZRDMMfDnm1C/Y5ago6iWDkVGQ==', N'349cff34-159b-4a25-9bfd-00be8df1c4d9', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e2383005-2534-475c-8b23-359b791c6dfa', N'admin@vidly.com', 0, N'ACoaJYEpJHj0T06gPSQLL+A07JiL7QIkOVtka+NveBnhckCcSOMskegx6oLqCna2sw==', N'bc5cb31c-228a-40ae-acb2-78f98f4faee0', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'7ebde721-ec25-4521-8cd6-ed18b2bf96fd', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e2383005-2534-475c-8b23-359b791c6dfa', N'7ebde721-ec25-4521-8cd6-ed18b2bf96fd')

");
        }
        
        public override void Down()
        {
        }
    }
}

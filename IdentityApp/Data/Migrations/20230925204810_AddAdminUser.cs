using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdentityApp.Data.Migrations
{
    public partial class AddAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [Security].[Users] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName], [ProfilePicture]) VALUES (N'3a69fdf9-9502-49a2-96b4-28968bfe92d2', N'admin', N'ADMIN', N'admin@test.com', N'ADMIN@TEST.COM', 0, N'AQAAAAEAACcQAAAAENVIFt3kk/CRuJDiDZZiIqKRVanGVeOmjIaFHWk0T6NhkcNWFrwqjdx6UYmDpnJNMw==', N'H2RYODZX3EA3SP7DUEMVQJPEQ3KIOVTH', N'8eca5689-fbd1-48ea-ac80-3aba62fc00bd', NULL, 0, 0, NULL, 1, 0, N'Khaldoun', N'AlHelaly', NULL)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("REMOVE FROM [Security].[Users] WHERE [Id] = '3a69fdf9-9502-49a2-96b4-28968bfe92d2'");
        }
    }
}

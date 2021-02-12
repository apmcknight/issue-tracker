using Microsoft.EntityFrameworkCore.Migrations;

namespace issue_tracker_crud.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Issue",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IssueTitle = table.Column<string>(nullable: true),
                    IssueDescription = table.Column<string>(nullable: true),
                    IssueLevel = table.Column<string>(nullable: true),
                    IssueAssigned = table.Column<bool>(nullable: false),
                    IsIssueOpen = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Issue", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Issue");
        }
    }
}

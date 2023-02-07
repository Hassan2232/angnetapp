using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstappMvc.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClientMessage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    userName = table.Column<string>(type: "TEXT", nullable: true),
                    userEmaile = table.Column<string>(type: "TEXT", nullable: true),
                    userPhone = table.Column<string>(type: "TEXT", nullable: true),
                    userTheme = table.Column<string>(type: "TEXT", nullable: true),
                    userMessage = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientMessage", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientMessage");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;
#nullable disable
namespace Social_Network.Migrations
{
    public partial class ClassPerformer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Performers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Performer", x => x.Id);
                });
            migrationBuilder.AddColumn<int>(
                name: "PerformerId",
                table: "Musics",
                type: "INTEGER",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.DropTable(
                name: "Performers");
            migrationBuilder.DropColumn("Musics", "PerformerId");
        }
    }
}

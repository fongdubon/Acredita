using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acredita.API.Migrations
{
    /// <inheritdoc />
    public partial class Manuel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classrooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Teacher = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Student = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Blackboard = table.Column<int>(type: "int", nullable: false),
                    Projector = table.Column<int>(type: "int", nullable: false),
                    Tv = table.Column<int>(type: "int", nullable: false),
                    Pc = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classrooms", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Classrooms");
        }
    }
}

using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API_CETtst.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "varchar(80) CHARACTER SET utf8mb4", maxLength: 80, nullable: true),
                    preco = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    estoque = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "id", "estoque", "nome", "preco" },
                values: new object[] { 1, 10, "Caderno", 7.95m });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "id", "estoque", "nome", "preco" },
                values: new object[] { 2, 30, "Borracha", 2.45m });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "id", "estoque", "nome", "preco" },
                values: new object[] { 3, 15, "Estojo", 6.25m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}

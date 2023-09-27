using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cp2_enterprise.Migrations
{
    /// <inheritdoc />
    public partial class Carrossel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funcionarios");

            migrationBuilder.AddColumn<int>(
                name: "AutoEscolaId",
                table: "Alunos",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_AutoEscolaId",
                table: "Alunos",
                column: "AutoEscolaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_AutoEscolas_AutoEscolaId",
                table: "Alunos",
                column: "AutoEscolaId",
                principalTable: "AutoEscolas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_AutoEscolas_AutoEscolaId",
                table: "Alunos");

            migrationBuilder.DropIndex(
                name: "IX_Alunos_AutoEscolaId",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "AutoEscolaId",
                table: "Alunos");

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Cargo = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Cpf = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Nome = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.Id);
                });
        }
    }
}

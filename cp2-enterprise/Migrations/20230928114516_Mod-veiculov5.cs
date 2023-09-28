using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cp2_enterprise.Migrations
{
    /// <inheritdoc />
    public partial class Modveiculov5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}

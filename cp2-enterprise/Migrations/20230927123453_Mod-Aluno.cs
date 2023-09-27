using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cp2_enterprise.Migrations
{
    /// <inheritdoc />
    public partial class ModAluno : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataNascimento",
                table: "Alunos",
                type: "TIMESTAMP(7)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DataNascimento",
                table: "Alunos",
                type: "NUMBER(10)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)");
        }
    }
}

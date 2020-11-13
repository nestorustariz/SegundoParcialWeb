using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "personas",
                columns: table => new
                {
                    Identificacion = table.Column<string>(nullable: false),
                    TipoDocumento = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    NombreInstitucion = table.Column<string>(nullable: true),
                    NombreAcudiente = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personas", x => x.Identificacion);
                });

            migrationBuilder.CreateTable(
                name: "vacunas",
                columns: table => new
                {
                    Identificacion = table.Column<string>(nullable: false),
                    TipoDocumento = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    NombreInstitucion = table.Column<string>(nullable: true),
                    NombreAcudiente = table.Column<string>(nullable: true),
                    TipoVacuna = table.Column<string>(nullable: true),
                    FechaVacuna = table.Column<DateTime>(nullable: false),
                    EdadPersonaAplicacion = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vacunas", x => x.Identificacion);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "personas");

            migrationBuilder.DropTable(
                name: "vacunas");
        }
    }
}

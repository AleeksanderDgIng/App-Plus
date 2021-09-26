using Microsoft.EntityFrameworkCore.Migrations;

namespace VisitasDomiciliarias.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Propietarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Identificacion = table.Column<int>(type: "int", nullable: false),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propietarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Veterinarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TarjProfesional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Identificacion = table.Column<int>(type: "int", nullable: false),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veterinarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mascotas",
                columns: table => new
                {
                    MascotaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Raza = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    OwnerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mascotas", x => x.MascotaId);
                    table.ForeignKey(
                        name: "FK_Mascotas_Propietarios_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Propietarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Historias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Temperatura = table.Column<double>(type: "float", nullable: false),
                    Peso = table.Column<double>(type: "float", nullable: false),
                    FrecRespiratoria = table.Column<int>(type: "int", nullable: false),
                    FrecCardiaca = table.Column<int>(type: "int", nullable: false),
                    EstadoAnimo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaVisita = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Recomendaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LePerteneceMascotaId = table.Column<int>(type: "int", nullable: true),
                    EsRegistradaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Historias_Mascotas_LePerteneceMascotaId",
                        column: x => x.LePerteneceMascotaId,
                        principalTable: "Mascotas",
                        principalColumn: "MascotaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Historias_Veterinarios_EsRegistradaId",
                        column: x => x.EsRegistradaId,
                        principalTable: "Veterinarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Historias_EsRegistradaId",
                table: "Historias",
                column: "EsRegistradaId");

            migrationBuilder.CreateIndex(
                name: "IX_Historias_LePerteneceMascotaId",
                table: "Historias",
                column: "LePerteneceMascotaId");

            migrationBuilder.CreateIndex(
                name: "IX_Mascotas_OwnerId",
                table: "Mascotas",
                column: "OwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Historias");

            migrationBuilder.DropTable(
                name: "Mascotas");

            migrationBuilder.DropTable(
                name: "Veterinarios");

            migrationBuilder.DropTable(
                name: "Propietarios");
        }
    }
}

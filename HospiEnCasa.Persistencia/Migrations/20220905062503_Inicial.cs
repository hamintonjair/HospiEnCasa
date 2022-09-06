using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospiEnCasa.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NivelEstudios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    estudio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NivelEstudios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Repuestos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    n_Repuesto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cantidad = table.Column<int>(type: "int", nullable: false),
                    valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipo_repuesto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fecha_compra = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repuestos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SeguroImpresoras",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipo_seguro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    fecha_activacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_vencimiento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeguroImpresoras", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cedula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fecha_nacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nivelEstudioid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Personas_NivelEstudios_nivelEstudioid",
                        column: x => x.nivelEstudioid,
                        principalTable: "NivelEstudios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipo_Rol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    personaid = table.Column<int>(type: "int", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rolid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.id);
                    table.ForeignKey(
                        name: "FK_Roles_Personas_personaid",
                        column: x => x.personaid,
                        principalTable: "Personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Roles_Roles_rolid",
                        column: x => x.rolid,
                        principalTable: "Roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TipoImpresoras",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_impresora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    placa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ano_modelo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    velocidad_imp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    volumen_imp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pais_origen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fecha_mantenimiento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    detalles = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    otros_caracteristicas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seguroid = table.Column<int>(type: "int", nullable: true),
                    cliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo_impresion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cantidad = table.Column<int>(type: "int", nullable: true),
                    precio = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    valor = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    fecha_revision = table.Column<DateTime>(type: "datetime2", nullable: true),
                    personaid = table.Column<int>(type: "int", nullable: true),
                    compraid = table.Column<int>(type: "int", nullable: true),
                    estado = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoImpresoras", x => x.id);
                    table.ForeignKey(
                        name: "FK_TipoImpresoras_Personas_personaid",
                        column: x => x.personaid,
                        principalTable: "Personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TipoImpresoras_Repuestos_compraid",
                        column: x => x.compraid,
                        principalTable: "Repuestos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TipoImpresoras_SeguroImpresoras_seguroid",
                        column: x => x.seguroid,
                        principalTable: "SeguroImpresoras",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personas_nivelEstudioid",
                table: "Personas",
                column: "nivelEstudioid");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_personaid",
                table: "Roles",
                column: "personaid");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_rolid",
                table: "Roles",
                column: "rolid");

            migrationBuilder.CreateIndex(
                name: "IX_TipoImpresoras_compraid",
                table: "TipoImpresoras",
                column: "compraid");

            migrationBuilder.CreateIndex(
                name: "IX_TipoImpresoras_personaid",
                table: "TipoImpresoras",
                column: "personaid");

            migrationBuilder.CreateIndex(
                name: "IX_TipoImpresoras_seguroid",
                table: "TipoImpresoras",
                column: "seguroid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "TipoImpresoras");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Repuestos");

            migrationBuilder.DropTable(
                name: "SeguroImpresoras");

            migrationBuilder.DropTable(
                name: "NivelEstudios");
        }
    }
}

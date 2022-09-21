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
                    cantidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    valor = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repuestos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TipoImpresoras",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_impresora = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoImpresoras", x => x.id);
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
                    fecha_nacimiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nivelEstudioid = table.Column<int>(type: "int", nullable: true),
                    socio = table.Column<int>(type: "int", nullable: false)
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
                name: "Impresoras",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    placa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ano_modelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    velocidad_imp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    volumen_imp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pais_origen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fecha_mantenimiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    detalles = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    otros_caracteristicas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipoImpresoraid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Impresoras", x => x.id);
                    table.ForeignKey(
                        name: "FK_Impresoras_TipoImpresoras_tipoImpresoraid",
                        column: x => x.tipoImpresoraid,
                        principalTable: "TipoImpresoras",
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
                    personaid = table.Column<int>(type: "int", nullable: true)
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
                });

            migrationBuilder.CreateTable(
                name: "Impresion3D",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo_impresion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cantidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    precio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    impresoraid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Impresion3D", x => x.id);
                    table.ForeignKey(
                        name: "FK_Impresion3D_Impresoras_impresoraid",
                        column: x => x.impresoraid,
                        principalTable: "Impresoras",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Revisiones",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    valor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    detalles = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fecha_revision = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    personaid = table.Column<int>(type: "int", nullable: true),
                    impresoraid = table.Column<int>(type: "int", nullable: true),
                    repuestoid = table.Column<int>(type: "int", nullable: true),
                    revision = table.Column<int>(type: "int", nullable: false),
                    estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Revisiones", x => x.id);
                    table.ForeignKey(
                        name: "FK_Revisiones_Impresoras_impresoraid",
                        column: x => x.impresoraid,
                        principalTable: "Impresoras",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Revisiones_Personas_personaid",
                        column: x => x.personaid,
                        principalTable: "Personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Revisiones_Repuestos_repuestoid",
                        column: x => x.repuestoid,
                        principalTable: "Repuestos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SeguroImpresoras",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipo_seguro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    precio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fecha_activacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fecha_vencimiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    impresoraid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeguroImpresoras", x => x.id);
                    table.ForeignKey(
                        name: "FK_SeguroImpresoras_Impresoras_impresoraid",
                        column: x => x.impresoraid,
                        principalTable: "Impresoras",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Loggin",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rolid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loggin", x => x.id);
                    table.ForeignKey(
                        name: "FK_Loggin_Roles_rolid",
                        column: x => x.rolid,
                        principalTable: "Roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Modulos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    repuestos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seguro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    impresora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    impresion3d = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    revision = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    finalizado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rolid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modulos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Modulos_Roles_rolid",
                        column: x => x.rolid,
                        principalTable: "Roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Impresion3D_impresoraid",
                table: "Impresion3D",
                column: "impresoraid");

            migrationBuilder.CreateIndex(
                name: "IX_Impresoras_tipoImpresoraid",
                table: "Impresoras",
                column: "tipoImpresoraid");

            migrationBuilder.CreateIndex(
                name: "IX_Loggin_rolid",
                table: "Loggin",
                column: "rolid");

            migrationBuilder.CreateIndex(
                name: "IX_Modulos_rolid",
                table: "Modulos",
                column: "rolid");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_nivelEstudioid",
                table: "Personas",
                column: "nivelEstudioid");

            migrationBuilder.CreateIndex(
                name: "IX_Revisiones_impresoraid",
                table: "Revisiones",
                column: "impresoraid");

            migrationBuilder.CreateIndex(
                name: "IX_Revisiones_personaid",
                table: "Revisiones",
                column: "personaid");

            migrationBuilder.CreateIndex(
                name: "IX_Revisiones_repuestoid",
                table: "Revisiones",
                column: "repuestoid");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_personaid",
                table: "Roles",
                column: "personaid");

            migrationBuilder.CreateIndex(
                name: "IX_SeguroImpresoras_impresoraid",
                table: "SeguroImpresoras",
                column: "impresoraid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Impresion3D");

            migrationBuilder.DropTable(
                name: "Loggin");

            migrationBuilder.DropTable(
                name: "Modulos");

            migrationBuilder.DropTable(
                name: "Revisiones");

            migrationBuilder.DropTable(
                name: "SeguroImpresoras");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Repuestos");

            migrationBuilder.DropTable(
                name: "Impresoras");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "TipoImpresoras");

            migrationBuilder.DropTable(
                name: "NivelEstudios");
        }
    }
}

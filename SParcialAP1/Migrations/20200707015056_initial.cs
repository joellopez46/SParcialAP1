using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SParcialAP1.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Proyectos",
                columns: table => new
                {
                    ProyectoId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    TiempoTotal = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proyectos", x => x.ProyectoId);
                });

            migrationBuilder.CreateTable(
                name: "Tareas",
                columns: table => new
                {
                    TareaId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TipoTarea = table.Column<string>(nullable: true),
                    Requerimiento = table.Column<string>(nullable: true),
                    Tiempo = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tareas", x => x.TareaId);
                });

            migrationBuilder.CreateTable(
                name: "ProyectoDetalle",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProyectoId = table.Column<int>(nullable: false),
                    TareaId = table.Column<int>(nullable: false),
                    TipoTarea = table.Column<string>(nullable: true),
                    Requerimiento = table.Column<string>(nullable: true),
                    Tiempo = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProyectoDetalle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProyectoDetalle_Proyectos_ProyectoId",
                        column: x => x.ProyectoId,
                        principalTable: "Proyectos",
                        principalColumn: "ProyectoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProyectoDetalle_Tareas_TareaId",
                        column: x => x.TareaId,
                        principalTable: "Tareas",
                        principalColumn: "TareaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Tareas",
                columns: new[] { "TareaId", "Requerimiento", "Tiempo", "TipoTarea" },
                values: new object[] { 1, "", 0.0, "Analisis" });

            migrationBuilder.InsertData(
                table: "Tareas",
                columns: new[] { "TareaId", "Requerimiento", "Tiempo", "TipoTarea" },
                values: new object[] { 2, "", 0.0, "Diseño" });

            migrationBuilder.InsertData(
                table: "Tareas",
                columns: new[] { "TareaId", "Requerimiento", "Tiempo", "TipoTarea" },
                values: new object[] { 3, "", 0.0, "Programacion" });

            migrationBuilder.InsertData(
                table: "Tareas",
                columns: new[] { "TareaId", "Requerimiento", "Tiempo", "TipoTarea" },
                values: new object[] { 4, "", 0.0, "Prueba" });

            migrationBuilder.CreateIndex(
                name: "IX_ProyectoDetalle_ProyectoId",
                table: "ProyectoDetalle",
                column: "ProyectoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProyectoDetalle_TareaId",
                table: "ProyectoDetalle",
                column: "TareaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProyectoDetalle");

            migrationBuilder.DropTable(
                name: "Proyectos");

            migrationBuilder.DropTable(
                name: "Tareas");
        }
    }
}

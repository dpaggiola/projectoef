using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectoef.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tarea",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "CategoriaId", "Descripcion", "Nombre", "Peso" },
                values: new object[] { new Guid("8dcfba8b-3422-4302-a1ea-bf73ce84e402"), null, "Actividades personales", 50 });

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "CategoriaId", "Descripcion", "Nombre", "Peso" },
                values: new object[] { new Guid("8dcfba8b-3422-4302-a1ea-bf73ce84e4ac"), null, "Actividades pendientes", 20 });

            migrationBuilder.InsertData(
                table: "Tarea",
                columns: new[] { "TareaId", "CategoriaId", "Descripcion", "FechaCreacion", "PesoT", "PrioridadTarea", "Titulo" },
                values: new object[] { new Guid("8dcfba8b-3422-4302-a1ea-bf73ce84e410"), new Guid("8dcfba8b-3422-4302-a1ea-bf73ce84e4ac"), null, new DateTime(2022, 9, 1, 21, 53, 23, 93, DateTimeKind.Local).AddTicks(3363), 0, 1, "Pago de servicios públicos" });

            migrationBuilder.InsertData(
                table: "Tarea",
                columns: new[] { "TareaId", "CategoriaId", "Descripcion", "FechaCreacion", "PesoT", "PrioridadTarea", "Titulo" },
                values: new object[] { new Guid("8dcfba8b-3422-4302-a1ea-bf73ce84e411"), new Guid("8dcfba8b-3422-4302-a1ea-bf73ce84e402"), null, new DateTime(2022, 9, 1, 21, 53, 23, 93, DateTimeKind.Local).AddTicks(3385), 0, 0, "Terminar de ver pelicula en Netflix" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("8dcfba8b-3422-4302-a1ea-bf73ce84e410"));

            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("8dcfba8b-3422-4302-a1ea-bf73ce84e411"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("8dcfba8b-3422-4302-a1ea-bf73ce84e402"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("8dcfba8b-3422-4302-a1ea-bf73ce84e4ac"));

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tarea",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}

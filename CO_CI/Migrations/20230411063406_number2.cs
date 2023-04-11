using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CO_CI.Migrations
{
    public partial class number2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContractorId",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 11, 9, 34, 5, 311, DateTimeKind.Local).AddTicks(195), new DateTime(2023, 4, 11, 9, 34, 5, 311, DateTimeKind.Local).AddTicks(205) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 11, 9, 34, 5, 311, DateTimeKind.Local).AddTicks(208), new DateTime(2023, 4, 11, 9, 34, 5, 311, DateTimeKind.Local).AddTicks(208) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 11, 9, 34, 5, 311, DateTimeKind.Local).AddTicks(209), new DateTime(2023, 4, 11, 9, 34, 5, 311, DateTimeKind.Local).AddTicks(210) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 11, 9, 34, 5, 311, DateTimeKind.Local).AddTicks(266), new DateTime(2023, 4, 11, 9, 34, 5, 311, DateTimeKind.Local).AddTicks(267) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 11, 9, 34, 5, 311, DateTimeKind.Local).AddTicks(269), new DateTime(2023, 4, 11, 9, 34, 5, 311, DateTimeKind.Local).AddTicks(270) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 11, 9, 34, 5, 311, DateTimeKind.Local).AddTicks(271), new DateTime(2023, 4, 11, 9, 34, 5, 311, DateTimeKind.Local).AddTicks(271) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 11, 9, 34, 5, 311, DateTimeKind.Local).AddTicks(272), new DateTime(2023, 4, 11, 9, 34, 5, 311, DateTimeKind.Local).AddTicks(273) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 11, 9, 34, 5, 311, DateTimeKind.Local).AddTicks(274), new DateTime(2023, 4, 11, 9, 34, 5, 311, DateTimeKind.Local).AddTicks(275) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 11, 9, 34, 5, 311, DateTimeKind.Local).AddTicks(276), new DateTime(2023, 4, 11, 9, 34, 5, 311, DateTimeKind.Local).AddTicks(276) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContractorId",
                table: "Invoices");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 3, 14, 19, 3, 6, 405, DateTimeKind.Local).AddTicks(5054), new DateTime(2023, 3, 14, 19, 3, 6, 405, DateTimeKind.Local).AddTicks(5065) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 3, 14, 19, 3, 6, 405, DateTimeKind.Local).AddTicks(5068), new DateTime(2023, 3, 14, 19, 3, 6, 405, DateTimeKind.Local).AddTicks(5069) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 3, 14, 19, 3, 6, 405, DateTimeKind.Local).AddTicks(5070), new DateTime(2023, 3, 14, 19, 3, 6, 405, DateTimeKind.Local).AddTicks(5070) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 3, 14, 19, 3, 6, 405, DateTimeKind.Local).AddTicks(5127), new DateTime(2023, 3, 14, 19, 3, 6, 405, DateTimeKind.Local).AddTicks(5128) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 3, 14, 19, 3, 6, 405, DateTimeKind.Local).AddTicks(5130), new DateTime(2023, 3, 14, 19, 3, 6, 405, DateTimeKind.Local).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 3, 14, 19, 3, 6, 405, DateTimeKind.Local).AddTicks(5132), new DateTime(2023, 3, 14, 19, 3, 6, 405, DateTimeKind.Local).AddTicks(5132) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 3, 14, 19, 3, 6, 405, DateTimeKind.Local).AddTicks(5134), new DateTime(2023, 3, 14, 19, 3, 6, 405, DateTimeKind.Local).AddTicks(5134) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 3, 14, 19, 3, 6, 405, DateTimeKind.Local).AddTicks(5136), new DateTime(2023, 3, 14, 19, 3, 6, 405, DateTimeKind.Local).AddTicks(5136) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 3, 14, 19, 3, 6, 405, DateTimeKind.Local).AddTicks(5137), new DateTime(2023, 3, 14, 19, 3, 6, 405, DateTimeKind.Local).AddTicks(5138) });
        }
    }
}

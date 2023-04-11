using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CO_CI.Migrations
{
    public partial class number5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ContractorName",
                table: "Orders",
                newName: "ContractorFullName");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 11, 12, 59, 44, 907, DateTimeKind.Local).AddTicks(536), new DateTime(2023, 4, 11, 12, 59, 44, 907, DateTimeKind.Local).AddTicks(547) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 11, 12, 59, 44, 907, DateTimeKind.Local).AddTicks(550), new DateTime(2023, 4, 11, 12, 59, 44, 907, DateTimeKind.Local).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 11, 12, 59, 44, 907, DateTimeKind.Local).AddTicks(552), new DateTime(2023, 4, 11, 12, 59, 44, 907, DateTimeKind.Local).AddTicks(552) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 11, 12, 59, 44, 907, DateTimeKind.Local).AddTicks(602), new DateTime(2023, 4, 11, 12, 59, 44, 907, DateTimeKind.Local).AddTicks(603) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 11, 12, 59, 44, 907, DateTimeKind.Local).AddTicks(607), new DateTime(2023, 4, 11, 12, 59, 44, 907, DateTimeKind.Local).AddTicks(607) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 11, 12, 59, 44, 907, DateTimeKind.Local).AddTicks(609), new DateTime(2023, 4, 11, 12, 59, 44, 907, DateTimeKind.Local).AddTicks(610) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 11, 12, 59, 44, 907, DateTimeKind.Local).AddTicks(612), new DateTime(2023, 4, 11, 12, 59, 44, 907, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 11, 12, 59, 44, 907, DateTimeKind.Local).AddTicks(617), new DateTime(2023, 4, 11, 12, 59, 44, 907, DateTimeKind.Local).AddTicks(618) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 11, 12, 59, 44, 907, DateTimeKind.Local).AddTicks(621), new DateTime(2023, 4, 11, 12, 59, 44, 907, DateTimeKind.Local).AddTicks(621) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ContractorFullName",
                table: "Orders",
                newName: "ContractorName");

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
    }
}

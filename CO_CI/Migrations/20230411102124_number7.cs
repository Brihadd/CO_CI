using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CO_CI.Migrations
{
    public partial class number7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Employees");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 11, 13, 21, 23, 355, DateTimeKind.Local).AddTicks(3314), new DateTime(2023, 4, 11, 13, 21, 23, 355, DateTimeKind.Local).AddTicks(3322) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 11, 13, 21, 23, 355, DateTimeKind.Local).AddTicks(3325), new DateTime(2023, 4, 11, 13, 21, 23, 355, DateTimeKind.Local).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 11, 13, 21, 23, 355, DateTimeKind.Local).AddTicks(3327), new DateTime(2023, 4, 11, 13, 21, 23, 355, DateTimeKind.Local).AddTicks(3327) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 11, 13, 21, 23, 355, DateTimeKind.Local).AddTicks(3375), new DateTime(2023, 4, 11, 13, 21, 23, 355, DateTimeKind.Local).AddTicks(3376) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 11, 13, 21, 23, 355, DateTimeKind.Local).AddTicks(3378), new DateTime(2023, 4, 11, 13, 21, 23, 355, DateTimeKind.Local).AddTicks(3378) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 11, 13, 21, 23, 355, DateTimeKind.Local).AddTicks(3379), new DateTime(2023, 4, 11, 13, 21, 23, 355, DateTimeKind.Local).AddTicks(3380) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 11, 13, 21, 23, 355, DateTimeKind.Local).AddTicks(3381), new DateTime(2023, 4, 11, 13, 21, 23, 355, DateTimeKind.Local).AddTicks(3381) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 11, 13, 21, 23, 355, DateTimeKind.Local).AddTicks(3383), new DateTime(2023, 4, 11, 13, 21, 23, 355, DateTimeKind.Local).AddTicks(3383) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 11, 13, 21, 23, 355, DateTimeKind.Local).AddTicks(3386), new DateTime(2023, 4, 11, 13, 21, 23, 355, DateTimeKind.Local).AddTicks(3386) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Employees",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
    }
}

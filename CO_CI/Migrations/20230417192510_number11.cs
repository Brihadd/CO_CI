using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CO_CI.Migrations
{
    public partial class number11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Employees",
                newName: "EmployeeId");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 17, 22, 25, 9, 848, DateTimeKind.Local).AddTicks(39), new DateTime(2023, 4, 17, 22, 25, 9, 848, DateTimeKind.Local).AddTicks(50) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 17, 22, 25, 9, 848, DateTimeKind.Local).AddTicks(53), new DateTime(2023, 4, 17, 22, 25, 9, 848, DateTimeKind.Local).AddTicks(53) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 17, 22, 25, 9, 848, DateTimeKind.Local).AddTicks(55), new DateTime(2023, 4, 17, 22, 25, 9, 848, DateTimeKind.Local).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 17, 22, 25, 9, 848, DateTimeKind.Local).AddTicks(104), new DateTime(2023, 4, 17, 22, 25, 9, 848, DateTimeKind.Local).AddTicks(105) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 17, 22, 25, 9, 848, DateTimeKind.Local).AddTicks(108), new DateTime(2023, 4, 17, 22, 25, 9, 848, DateTimeKind.Local).AddTicks(109) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 17, 22, 25, 9, 848, DateTimeKind.Local).AddTicks(110), new DateTime(2023, 4, 17, 22, 25, 9, 848, DateTimeKind.Local).AddTicks(111) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 17, 22, 25, 9, 848, DateTimeKind.Local).AddTicks(113), new DateTime(2023, 4, 17, 22, 25, 9, 848, DateTimeKind.Local).AddTicks(114) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 17, 22, 25, 9, 848, DateTimeKind.Local).AddTicks(115), new DateTime(2023, 4, 17, 22, 25, 9, 848, DateTimeKind.Local).AddTicks(116) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 17, 22, 25, 9, 848, DateTimeKind.Local).AddTicks(117), new DateTime(2023, 4, 17, 22, 25, 9, 848, DateTimeKind.Local).AddTicks(118) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Employees",
                newName: "Id");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 17, 22, 20, 0, 968, DateTimeKind.Local).AddTicks(5450), new DateTime(2023, 4, 17, 22, 20, 0, 968, DateTimeKind.Local).AddTicks(5461) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 17, 22, 20, 0, 968, DateTimeKind.Local).AddTicks(5464), new DateTime(2023, 4, 17, 22, 20, 0, 968, DateTimeKind.Local).AddTicks(5464) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 17, 22, 20, 0, 968, DateTimeKind.Local).AddTicks(5465), new DateTime(2023, 4, 17, 22, 20, 0, 968, DateTimeKind.Local).AddTicks(5466) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 17, 22, 20, 0, 968, DateTimeKind.Local).AddTicks(5581), new DateTime(2023, 4, 17, 22, 20, 0, 968, DateTimeKind.Local).AddTicks(5582) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 17, 22, 20, 0, 968, DateTimeKind.Local).AddTicks(5584), new DateTime(2023, 4, 17, 22, 20, 0, 968, DateTimeKind.Local).AddTicks(5585) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 17, 22, 20, 0, 968, DateTimeKind.Local).AddTicks(5586), new DateTime(2023, 4, 17, 22, 20, 0, 968, DateTimeKind.Local).AddTicks(5586) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 17, 22, 20, 0, 968, DateTimeKind.Local).AddTicks(5588), new DateTime(2023, 4, 17, 22, 20, 0, 968, DateTimeKind.Local).AddTicks(5588) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 17, 22, 20, 0, 968, DateTimeKind.Local).AddTicks(5589), new DateTime(2023, 4, 17, 22, 20, 0, 968, DateTimeKind.Local).AddTicks(5589) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 4, 17, 22, 20, 0, 968, DateTimeKind.Local).AddTicks(5591), new DateTime(2023, 4, 17, 22, 20, 0, 968, DateTimeKind.Local).AddTicks(5591) });
        }
    }
}

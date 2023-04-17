using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CO_CI.Migrations
{
    public partial class number6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContractorFullName",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ContractorId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DepartmentName",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ContractorEmail",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "ContractorName",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "ContractorOrder",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "ContractorPhoneNumber",
                table: "Invoices");

            migrationBuilder.RenameColumn(
                name: "ContractorId",
                table: "Invoices",
                newName: "EmployeeId");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DepartmentId",
                table: "Orders",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_EmployeeId",
                table: "Orders",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_EmployeeId",
                table: "Invoices",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Employees_EmployeeId",
                table: "Invoices",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Departments_DepartmentId",
                table: "Orders",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Employees_EmployeeId",
                table: "Orders",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Employees_EmployeeId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Departments_DepartmentId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Employees_EmployeeId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_DepartmentId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_EmployeeId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_EmployeeId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Invoices",
                newName: "ContractorId");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "ContractorFullName",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ContractorId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DepartmentName",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContractorEmail",
                table: "Invoices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContractorName",
                table: "Invoices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContractorOrder",
                table: "Invoices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContractorPhoneNumber",
                table: "Invoices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
    }
}

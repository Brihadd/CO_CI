using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CO_CI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManagerId = table.Column<int>(type: "int", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserStatus = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    InvoiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContractorEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContractorPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContractorOrder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VatPayer = table.Column<bool>(type: "bit", nullable: false),
                    BankAccountNumber = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Period = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentDeadline = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Сurrency = table.Column<int>(type: "int", nullable: false),
                    InvoiceState = table.Column<int>(type: "int", nullable: false),
                    HoursCount = table.Column<double>(type: "float", nullable: false),
                    HourRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxRate = table.Column<double>(type: "float", nullable: false),
                    ExpensesAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VATAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.InvoiceId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContractorId = table.Column<int>(type: "int", nullable: true),
                    ContractorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HourRate = table.Column<double>(type: "float", nullable: false),
                    MDRate = table.Column<double>(type: "float", nullable: false),
                    OrderState = table.Column<int>(type: "int", nullable: false),
                    Info = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceId = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Expenses_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "InvoiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Created", "ManagerId", "Name", "Updated" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 14, 19, 3, 6, 405, DateTimeKind.Local).AddTicks(5054), 1, "FirstDepartment", new DateTime(2023, 3, 14, 19, 3, 6, 405, DateTimeKind.Local).AddTicks(5065) },
                    { 2, new DateTime(2023, 3, 14, 19, 3, 6, 405, DateTimeKind.Local).AddTicks(5068), 2, "SecondDepartment", new DateTime(2023, 3, 14, 19, 3, 6, 405, DateTimeKind.Local).AddTicks(5069) },
                    { 3, new DateTime(2023, 3, 14, 19, 3, 6, 405, DateTimeKind.Local).AddTicks(5070), 3, "ThirdDepartment", new DateTime(2023, 3, 14, 19, 3, 6, 405, DateTimeKind.Local).AddTicks(5070) }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "BirthDate", "Created", "Deleted", "Email", "Name", "PhoneNumber", "Surname", "Updated", "UserStatus" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 14, 19, 3, 6, 405, DateTimeKind.Local).AddTicks(5127), false, "firstmanager@gmail.com", "Ivan", "+7 (900) 100-00-01", "Ivanov", new DateTime(2023, 3, 14, 19, 3, 6, 405, DateTimeKind.Local).AddTicks(5128), 3 },
                    { 2, new DateTime(1990, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 14, 19, 3, 6, 405, DateTimeKind.Local).AddTicks(5130), false, "secondmanager@gmail.com", "Maxim", "+7 (900) 100-00-02", "Maximov", new DateTime(2023, 3, 14, 19, 3, 6, 405, DateTimeKind.Local).AddTicks(5130), 3 },
                    { 3, new DateTime(1990, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 14, 19, 3, 6, 405, DateTimeKind.Local).AddTicks(5132), false, "thirdmanager@gmail.com", "Gleb", "+7 (900) 100-00-03", "Glebov", new DateTime(2023, 3, 14, 19, 3, 6, 405, DateTimeKind.Local).AddTicks(5132), 3 },
                    { 4, new DateTime(1990, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 14, 19, 3, 6, 405, DateTimeKind.Local).AddTicks(5134), false, "accountant@gmail.com", "Grigoriy", "+7 (900) 100-00-05", "Grigorov", new DateTime(2023, 3, 14, 19, 3, 6, 405, DateTimeKind.Local).AddTicks(5134), 0 },
                    { 5, new DateTime(1990, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 14, 19, 3, 6, 405, DateTimeKind.Local).AddTicks(5136), false, "backofficet@gmail.com", "Vasiliy", "+7 (900) 100-00-06", "Vasiliev", new DateTime(2023, 3, 14, 19, 3, 6, 405, DateTimeKind.Local).AddTicks(5136), 1 },
                    { 6, new DateTime(1990, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 14, 19, 3, 6, 405, DateTimeKind.Local).AddTicks(5137), false, "contractor@gmail.com", "Mihail", "+7 (900) 100-00-07", "Mihailov", new DateTime(2023, 3, 14, 19, 3, 6, 405, DateTimeKind.Local).AddTicks(5138), 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_InvoiceId",
                table: "Expenses",
                column: "InvoiceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Invoices");
        }
    }
}

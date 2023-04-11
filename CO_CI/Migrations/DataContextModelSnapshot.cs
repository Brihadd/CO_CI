﻿// <auto-generated />
using System;
using CO_CI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CO_CI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CO_CI.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ManagerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2023, 4, 11, 13, 21, 23, 355, DateTimeKind.Local).AddTicks(3314),
                            ManagerId = 1,
                            Name = "FirstDepartment",
                            Updated = new DateTime(2023, 4, 11, 13, 21, 23, 355, DateTimeKind.Local).AddTicks(3322)
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2023, 4, 11, 13, 21, 23, 355, DateTimeKind.Local).AddTicks(3325),
                            ManagerId = 2,
                            Name = "SecondDepartment",
                            Updated = new DateTime(2023, 4, 11, 13, 21, 23, 355, DateTimeKind.Local).AddTicks(3326)
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2023, 4, 11, 13, 21, 23, 355, DateTimeKind.Local).AddTicks(3327),
                            ManagerId = 3,
                            Name = "ThirdDepartment",
                            Updated = new DateTime(2023, 4, 11, 13, 21, 23, 355, DateTimeKind.Local).AddTicks(3327)
                        });
                });

            modelBuilder.Entity("CO_CI.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserStatus")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1990, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTime(2023, 4, 11, 13, 21, 23, 355, DateTimeKind.Local).AddTicks(3375),
                            Email = "firstmanager@gmail.com",
                            Name = "Ivan",
                            PhoneNumber = "+7 (900) 100-00-01",
                            Surname = "Ivanov",
                            Updated = new DateTime(2023, 4, 11, 13, 21, 23, 355, DateTimeKind.Local).AddTicks(3376),
                            UserStatus = 3
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(1990, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTime(2023, 4, 11, 13, 21, 23, 355, DateTimeKind.Local).AddTicks(3378),
                            Email = "secondmanager@gmail.com",
                            Name = "Maxim",
                            PhoneNumber = "+7 (900) 100-00-02",
                            Surname = "Maximov",
                            Updated = new DateTime(2023, 4, 11, 13, 21, 23, 355, DateTimeKind.Local).AddTicks(3378),
                            UserStatus = 3
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(1990, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTime(2023, 4, 11, 13, 21, 23, 355, DateTimeKind.Local).AddTicks(3379),
                            Email = "thirdmanager@gmail.com",
                            Name = "Gleb",
                            PhoneNumber = "+7 (900) 100-00-03",
                            Surname = "Glebov",
                            Updated = new DateTime(2023, 4, 11, 13, 21, 23, 355, DateTimeKind.Local).AddTicks(3380),
                            UserStatus = 3
                        },
                        new
                        {
                            Id = 4,
                            BirthDate = new DateTime(1990, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTime(2023, 4, 11, 13, 21, 23, 355, DateTimeKind.Local).AddTicks(3381),
                            Email = "accountant@gmail.com",
                            Name = "Grigoriy",
                            PhoneNumber = "+7 (900) 100-00-05",
                            Surname = "Grigorov",
                            Updated = new DateTime(2023, 4, 11, 13, 21, 23, 355, DateTimeKind.Local).AddTicks(3381),
                            UserStatus = 0
                        },
                        new
                        {
                            Id = 5,
                            BirthDate = new DateTime(1990, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTime(2023, 4, 11, 13, 21, 23, 355, DateTimeKind.Local).AddTicks(3383),
                            Email = "backofficet@gmail.com",
                            Name = "Vasiliy",
                            PhoneNumber = "+7 (900) 100-00-06",
                            Surname = "Vasiliev",
                            Updated = new DateTime(2023, 4, 11, 13, 21, 23, 355, DateTimeKind.Local).AddTicks(3383),
                            UserStatus = 1
                        },
                        new
                        {
                            Id = 6,
                            BirthDate = new DateTime(1990, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTime(2023, 4, 11, 13, 21, 23, 355, DateTimeKind.Local).AddTicks(3386),
                            Email = "contractor@gmail.com",
                            Name = "Mihail",
                            PhoneNumber = "+7 (900) 100-00-07",
                            Surname = "Mihailov",
                            Updated = new DateTime(2023, 4, 11, 13, 21, 23, 355, DateTimeKind.Local).AddTicks(3386),
                            UserStatus = 2
                        });
                });

            modelBuilder.Entity("CO_CI.Models.Expense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceId");

                    b.ToTable("Expenses");
                });

            modelBuilder.Entity("CO_CI.Models.Invoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvoiceId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("BankAccountNumber")
                        .HasColumnType("int");

                    b.Property<string>("ContractorEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContractorId")
                        .HasColumnType("int");

                    b.Property<string>("ContractorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContractorOrder")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContractorPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("ExpensesAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("HourRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<double>("HoursCount")
                        .HasColumnType("float");

                    b.Property<int>("InvoiceState")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDeadline")
                        .HasColumnType("datetime2");

                    b.Property<string>("Period")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TaxRate")
                        .HasColumnType("float");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("VATAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("VatPayer")
                        .HasColumnType("bit");

                    b.Property<int>("Сurrency")
                        .HasColumnType("int");

                    b.HasKey("InvoiceId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("CO_CI.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ContractorFullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ContractorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("HourRate")
                        .HasColumnType("float");

                    b.Property<string>("Info")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("MDRate")
                        .HasColumnType("float");

                    b.Property<string>("OrderCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderState")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("CO_CI.Models.Expense", b =>
                {
                    b.HasOne("CO_CI.Models.Invoice", null)
                        .WithMany("Expenses")
                        .HasForeignKey("InvoiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CO_CI.Models.Invoice", b =>
                {
                    b.Navigation("Expenses");
                });
#pragma warning restore 612, 618
        }
    }
}

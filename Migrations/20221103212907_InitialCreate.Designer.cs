﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;
using ctds_webapi;

#nullable disable

namespace ctds_webapi.Migrations
{
    [DbContext(typeof(OracleDBContext))]
    [Migration("20221103212907_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ctds_webapi.Models.Bill", b =>
                {
                    b.Property<Guid>("BillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("RAW(16)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("RAW(16)");

                    b.Property<Guid>("TableId")
                        .HasColumnType("RAW(16)");

                    b.Property<Guid>("WaiterId")
                        .HasColumnType("RAW(16)");

                    b.HasKey("BillId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("TableId");

                    b.HasIndex("WaiterId");

                    b.ToTable("Bill", (string)null);

                    b.HasData(
                        new
                        {
                            BillId = new Guid("ef91c997-d758-44c6-8b9f-a66d7027e21c"),
                            CreatedAt = new DateTime(2022, 11, 3, 16, 29, 6, 832, DateTimeKind.Local).AddTicks(9293),
                            CustomerId = new Guid("80bb2ae8-d779-4247-a8d3-2270b4ec68d1"),
                            TableId = new Guid("b80c2655-5a22-4ba2-94a1-688a85d6d91b"),
                            WaiterId = new Guid("133e9d8d-7bbc-4e23-93c4-cb8de085919f")
                        },
                        new
                        {
                            BillId = new Guid("ef91c997-d758-44c6-8b9f-a66d7027e22c"),
                            CreatedAt = new DateTime(2022, 11, 3, 16, 29, 6, 832, DateTimeKind.Local).AddTicks(9349),
                            CustomerId = new Guid("80bb2ae8-d779-4247-a8d3-2270b4ec68d1"),
                            TableId = new Guid("b80c2655-5a22-4ba2-94a1-688a85d6d92b"),
                            WaiterId = new Guid("233e9d8d-7bbc-4e23-93c4-cb8de085919f")
                        },
                        new
                        {
                            BillId = new Guid("ef91c997-d758-44c6-8b9f-a66d7027e23c"),
                            CreatedAt = new DateTime(2022, 11, 3, 16, 29, 6, 832, DateTimeKind.Local).AddTicks(9353),
                            CustomerId = new Guid("80bb2ae8-d779-4247-a8d3-2270b4ec68d1"),
                            TableId = new Guid("b80c2655-5a22-4ba2-94a1-688a85d6d93b"),
                            WaiterId = new Guid("333e9d8d-7bbc-4e23-93c4-cb8de085919f")
                        },
                        new
                        {
                            BillId = new Guid("ef91c997-d758-44c6-8b9f-a66d7027e24c"),
                            CreatedAt = new DateTime(2022, 11, 3, 16, 29, 6, 832, DateTimeKind.Local).AddTicks(9356),
                            CustomerId = new Guid("80bb2ae8-d779-4247-a8d3-2270b4ec68d2"),
                            TableId = new Guid("b80c2655-5a22-4ba2-94a1-688a85d6d91b"),
                            WaiterId = new Guid("133e9d8d-7bbc-4e23-93c4-cb8de085919f")
                        },
                        new
                        {
                            BillId = new Guid("ef91c997-d758-44c6-8b9f-a66d7027e25c"),
                            CreatedAt = new DateTime(2022, 11, 3, 16, 29, 6, 832, DateTimeKind.Local).AddTicks(9359),
                            CustomerId = new Guid("80bb2ae8-d779-4247-a8d3-2270b4ec68d3"),
                            TableId = new Guid("b80c2655-5a22-4ba2-94a1-688a85d6d93b"),
                            WaiterId = new Guid("133e9d8d-7bbc-4e23-93c4-cb8de085919f")
                        });
                });

            modelBuilder.Entity("ctds_webapi.Models.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("RAW(16)");

                    b.Property<string>("Address")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<long>("Cellphone")
                        .HasColumnType("NUMBER(19)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.ToTable("Customer", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("80bb2ae8-d779-4247-a8d3-2270b4ec68d1"),
                            Address = "8th street",
                            Cellphone = 3224657628L,
                            LastName = "Danger",
                            Name = "Ron"
                        },
                        new
                        {
                            Id = new Guid("80bb2ae8-d779-4247-a8d3-2270b4ec68d2"),
                            Address = "7th street",
                            Cellphone = 3224657628L,
                            LastName = "Doe",
                            Name = "John"
                        },
                        new
                        {
                            Id = new Guid("80bb2ae8-d779-4247-a8d3-2270b4ec68d3"),
                            Address = "6th street",
                            Cellphone = 3224657628L,
                            LastName = "bar",
                            Name = "Foo"
                        });
                });

            modelBuilder.Entity("ctds_webapi.Models.Detail_Bill", b =>
                {
                    b.Property<Guid>("DetailBilId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("RAW(16)");

                    b.Property<Guid>("BillId")
                        .HasColumnType("RAW(16)");

                    b.Property<int>("Dish")
                        .HasColumnType("NUMBER(10)");

                    b.Property<Guid>("ManagerId")
                        .HasColumnType("RAW(16)");

                    b.Property<double>("Value")
                        .HasColumnType("BINARY_DOUBLE");

                    b.HasKey("DetailBilId");

                    b.HasIndex("BillId");

                    b.HasIndex("ManagerId");

                    b.ToTable("Detail_Bill", (string)null);

                    b.HasData(
                        new
                        {
                            DetailBilId = new Guid("d1d42909-a120-44b8-9fe0-ecc99d643161"),
                            BillId = new Guid("ef91c997-d758-44c6-8b9f-a66d7027e21c"),
                            Dish = 1,
                            ManagerId = new Guid("1cfe8617-8d05-46bd-8ad5-974488f1fe3c"),
                            Value = 4.4000000000000004
                        },
                        new
                        {
                            DetailBilId = new Guid("d1d42909-a120-44b8-9fe0-ecc99d643162"),
                            BillId = new Guid("ef91c997-d758-44c6-8b9f-a66d7027e22c"),
                            Dish = 4,
                            ManagerId = new Guid("1cfe8617-8d05-46bd-8ad5-974488f1fe3c"),
                            Value = 4.4000000000000004
                        },
                        new
                        {
                            DetailBilId = new Guid("d1d42909-a120-44b8-9fe0-ecc99d643164"),
                            BillId = new Guid("ef91c997-d758-44c6-8b9f-a66d7027e24c"),
                            Dish = 4,
                            ManagerId = new Guid("3cfe8617-8d05-46bd-8ad5-974488f1fe3c"),
                            Value = 4.4000000000000004
                        },
                        new
                        {
                            DetailBilId = new Guid("d1d42909-a120-44b8-9fe0-ecc99d643165"),
                            BillId = new Guid("ef91c997-d758-44c6-8b9f-a66d7027e24c"),
                            Dish = 4,
                            ManagerId = new Guid("1cfe8617-8d05-46bd-8ad5-974488f1fe3c"),
                            Value = 4.4000000000000004
                        },
                        new
                        {
                            DetailBilId = new Guid("d1d42909-a120-44b8-9fe0-ecc99d643166"),
                            BillId = new Guid("ef91c997-d758-44c6-8b9f-a66d7027e22c"),
                            Dish = 0,
                            ManagerId = new Guid("2cfe8617-8d05-46bd-8ad5-974488f1fe3c"),
                            Value = 4.4000000000000004
                        },
                        new
                        {
                            DetailBilId = new Guid("d1d42909-a120-44b8-9fe0-ecc99d643167"),
                            BillId = new Guid("ef91c997-d758-44c6-8b9f-a66d7027e21c"),
                            Dish = 2,
                            ManagerId = new Guid("3cfe8617-8d05-46bd-8ad5-974488f1fe3c"),
                            Value = 4.4000000000000004
                        },
                        new
                        {
                            DetailBilId = new Guid("d1d42909-a120-44b8-9fe0-ecc99d643168"),
                            BillId = new Guid("ef91c997-d758-44c6-8b9f-a66d7027e24c"),
                            Dish = 2,
                            ManagerId = new Guid("2cfe8617-8d05-46bd-8ad5-974488f1fe3c"),
                            Value = 4.4000000000000004
                        },
                        new
                        {
                            DetailBilId = new Guid("d1d42909-a120-44b8-9fe0-ecc99d643169"),
                            BillId = new Guid("ef91c997-d758-44c6-8b9f-a66d7027e25c"),
                            Dish = 3,
                            ManagerId = new Guid("1cfe8617-8d05-46bd-8ad5-974488f1fe3c"),
                            Value = 4.4000000000000004
                        });
                });

            modelBuilder.Entity("ctds_webapi.Models.Manager", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("RAW(16)");

                    b.Property<int>("Age")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("Seniority")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.ToTable("Manager", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("1cfe8617-8d05-46bd-8ad5-974488f1fe3c"),
                            Age = 20,
                            LastName = "Quiñones",
                            Name = "Juan",
                            Seniority = 0
                        },
                        new
                        {
                            Id = new Guid("2cfe8617-8d05-46bd-8ad5-974488f1fe3c"),
                            Age = 20,
                            LastName = "Brando",
                            Name = "Mike",
                            Seniority = 0
                        },
                        new
                        {
                            Id = new Guid("3cfe8617-8d05-46bd-8ad5-974488f1fe3c"),
                            Age = 20,
                            LastName = "Corleone",
                            Name = "Vito",
                            Seniority = 0
                        });
                });

            modelBuilder.Entity("ctds_webapi.Models.Table", b =>
                {
                    b.Property<Guid>("TableId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("RAW(16)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<bool>("Reserved")
                        .HasColumnType("NUMBER(1)");

                    b.Property<int>("Stalls")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("TableId");

                    b.ToTable("Table", (string)null);

                    b.HasData(
                        new
                        {
                            TableId = new Guid("b80c2655-5a22-4ba2-94a1-688a85d6d91b"),
                            Name = "1",
                            Reserved = true,
                            Stalls = 4
                        },
                        new
                        {
                            TableId = new Guid("b80c2655-5a22-4ba2-94a1-688a85d6d92b"),
                            Name = "2",
                            Reserved = true,
                            Stalls = 6
                        },
                        new
                        {
                            TableId = new Guid("b80c2655-5a22-4ba2-94a1-688a85d6d93b"),
                            Name = "3",
                            Reserved = true,
                            Stalls = 4
                        });
                });

            modelBuilder.Entity("ctds_webapi.Models.Waiter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("RAW(16)");

                    b.Property<int>("Age")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("Seniority")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.ToTable("Waiter", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("133e9d8d-7bbc-4e23-93c4-cb8de085919f"),
                            Age = 28,
                            LastName = "Mikella",
                            Name = "Michael",
                            Seniority = 1
                        },
                        new
                        {
                            Id = new Guid("233e9d8d-7bbc-4e23-93c4-cb8de085919f"),
                            Age = 28,
                            LastName = "Warrior",
                            Name = "Hoarahlux",
                            Seniority = 0
                        },
                        new
                        {
                            Id = new Guid("333e9d8d-7bbc-4e23-93c4-cb8de085919f"),
                            Age = 28,
                            LastName = "Guerrero",
                            Name = "Rex",
                            Seniority = 2
                        });
                });

            modelBuilder.Entity("ctds_webapi.Models.Bill", b =>
                {
                    b.HasOne("ctds_webapi.Models.Customer", "Customer")
                        .WithMany("Bills")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ctds_webapi.Models.Table", "Table")
                        .WithMany("Bills")
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ctds_webapi.Models.Waiter", "Waiter")
                        .WithMany("Bills")
                        .HasForeignKey("WaiterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Table");

                    b.Navigation("Waiter");
                });

            modelBuilder.Entity("ctds_webapi.Models.Detail_Bill", b =>
                {
                    b.HasOne("ctds_webapi.Models.Bill", "Bill")
                        .WithMany("Detail_Bills")
                        .HasForeignKey("BillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ctds_webapi.Models.Manager", "Manager")
                        .WithMany("Detail_Bills")
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bill");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("ctds_webapi.Models.Bill", b =>
                {
                    b.Navigation("Detail_Bills");
                });

            modelBuilder.Entity("ctds_webapi.Models.Customer", b =>
                {
                    b.Navigation("Bills");
                });

            modelBuilder.Entity("ctds_webapi.Models.Manager", b =>
                {
                    b.Navigation("Detail_Bills");
                });

            modelBuilder.Entity("ctds_webapi.Models.Table", b =>
                {
                    b.Navigation("Bills");
                });

            modelBuilder.Entity("ctds_webapi.Models.Waiter", b =>
                {
                    b.Navigation("Bills");
                });
#pragma warning restore 612, 618
        }
    }
}

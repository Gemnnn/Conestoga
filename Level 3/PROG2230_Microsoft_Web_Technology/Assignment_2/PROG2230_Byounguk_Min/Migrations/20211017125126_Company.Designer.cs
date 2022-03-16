﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PROG2230_Byounguk_Min.Models;

namespace PROG2230_Byounguk_Min.Migrations
{
    [DbContext(typeof(AssignmentContext))]
    [Migration("20211017125126_Company")]
    partial class Company
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PROG2230_Byounguk_Min.Models.CompanyModel", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ticker")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyId");

                    b.ToTable("CompanyModels");

                    b.HasData(
                        new
                        {
                            CompanyId = 1,
                            CompanyAddress = "453 bill Gates Drive",
                            CompanyName = "Micorsoft",
                            Ticker = "MSFT"
                        },
                        new
                        {
                            CompanyId = 2,
                            CompanyAddress = "123 Google Way",
                            CompanyName = "Google",
                            Ticker = "GOOG"
                        },
                        new
                        {
                            CompanyId = 3,
                            CompanyAddress = "234 Walmart Street",
                            CompanyName = "Walmart",
                            Ticker = "WMT"
                        });
                });

            modelBuilder.Entity("PROG2230_Byounguk_Min.Models.TransactionRecord", b =>
                {
                    b.Property<int>("TransactionRecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int?>("Quantity")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<double?>("SharePrice")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<int>("TransactionTypeId")
                        .HasColumnType("int");

                    b.HasKey("TransactionRecordId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("TransactionTypeId");

                    b.ToTable("TransactionRecords");

                    b.HasData(
                        new
                        {
                            TransactionRecordId = 1,
                            CompanyId = 1,
                            Quantity = 100,
                            SharePrice = 123.45,
                            TransactionTypeId = 1
                        },
                        new
                        {
                            TransactionRecordId = 2,
                            CompanyId = 2,
                            Quantity = 100,
                            SharePrice = 2701.7600000000002,
                            TransactionTypeId = 2
                        },
                        new
                        {
                            TransactionRecordId = 3,
                            CompanyId = 3,
                            Quantity = 200,
                            SharePrice = 140.97999999999999,
                            TransactionTypeId = 1
                        });
                });

            modelBuilder.Entity("PROG2230_Byounguk_Min.Models.TransactionType", b =>
                {
                    b.Property<int>("TransactionTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double?>("Commission")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TransactionTypeId");

                    b.ToTable("TransactionTypes");

                    b.HasData(
                        new
                        {
                            TransactionTypeId = 1,
                            Commission = 5.9900000000000002,
                            Name = "Buy"
                        },
                        new
                        {
                            TransactionTypeId = 2,
                            Commission = 5.4000000000000004,
                            Name = "Sell"
                        });
                });

            modelBuilder.Entity("PROG2230_Byounguk_Min.Models.TransactionRecord", b =>
                {
                    b.HasOne("PROG2230_Byounguk_Min.Models.CompanyModel", "CompanyModel")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PROG2230_Byounguk_Min.Models.TransactionType", "TransactionType")
                        .WithMany()
                        .HasForeignKey("TransactionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CompanyModel");

                    b.Navigation("TransactionType");
                });
#pragma warning restore 612, 618
        }
    }
}
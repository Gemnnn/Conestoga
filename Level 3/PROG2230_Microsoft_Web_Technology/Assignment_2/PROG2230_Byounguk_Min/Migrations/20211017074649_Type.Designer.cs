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
    [Migration("20211017074649_Type")]
    partial class Type
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PROG2230_Byounguk_Min.Models.TransactionRecord", b =>
                {
                    b.Property<int>("TransactionRecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Quantity")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<double?>("SharePrice")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<string>("TickerSymbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TransactionTypeId")
                        .HasColumnType("int");

                    b.HasKey("TransactionRecordId");

                    b.HasIndex("TransactionTypeId");

                    b.ToTable("TransactionRecords");

                    b.HasData(
                        new
                        {
                            TransactionRecordId = 1,
                            CompanyName = "Microsoft",
                            Quantity = 100,
                            SharePrice = 123.45,
                            TickerSymbol = "MSFT",
                            TransactionTypeId = 1
                        },
                        new
                        {
                            TransactionRecordId = 2,
                            CompanyName = "Google",
                            Quantity = 100,
                            SharePrice = 2701.7600000000002,
                            TickerSymbol = "GOOG",
                            TransactionTypeId = 2
                        },
                        new
                        {
                            TransactionRecordId = 3,
                            CompanyName = "Walmart",
                            Quantity = 200,
                            SharePrice = 140.97999999999999,
                            TickerSymbol = "WMT",
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
                    b.HasOne("PROG2230_Byounguk_Min.Models.TransactionType", "TransactionType")
                        .WithMany()
                        .HasForeignKey("TransactionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TransactionType");
                });
#pragma warning restore 612, 618
        }
    }
}

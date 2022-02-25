﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PROG2230_AS1_BMin.Models;

namespace PROG2230_AS1_BMin.Migrations
{
    [DbContext(typeof(AssignmentContext))]
    partial class AssignmentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PROG2230_AS1_BMin.Models.TransactionRecord", b =>
                {
                    b.Property<int>("TransactionRecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("SharePrice")
                        .HasColumnType("float");

                    b.Property<string>("TickerSymbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransactionTypeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

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
                            TransactionTypeId = "B"
                        },
                        new
                        {
                            TransactionRecordId = 2,
                            CompanyName = "Google",
                            Quantity = 100,
                            SharePrice = 2701.7600000000002,
                            TickerSymbol = "GOOG",
                            TransactionTypeId = "S"
                        },
                        new
                        {
                            TransactionRecordId = 3,
                            CompanyName = "Walmart",
                            Quantity = 200,
                            SharePrice = 140.97999999999999,
                            TickerSymbol = "WMT",
                            TransactionTypeId = "B"
                        });
                });

            modelBuilder.Entity("PROG2230_AS1_BMin.Models.TransactionType", b =>
                {
                    b.Property<string>("TransactionTypeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Commission")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TransactionTypeId");

                    b.ToTable("TransactionTypes");

                    b.HasData(
                        new
                        {
                            TransactionTypeId = "B",
                            Commission = 5.9900000000000002,
                            Name = "Buy"
                        },
                        new
                        {
                            TransactionTypeId = "S",
                            Commission = 5.4000000000000004,
                            Name = "Sell"
                        });
                });

            modelBuilder.Entity("PROG2230_AS1_BMin.Models.TransactionRecord", b =>
                {
                    b.HasOne("PROG2230_AS1_BMin.Models.TransactionType", "TransactionType")
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PROG2230_Byounguk_Min.Models
{
    public class AssignmentContext : DbContext
    {

        // Add the default constructor
        public AssignmentContext(DbContextOptions<AssignmentContext> options)
            : base(options)
        { }

        // Add the transaction records
        public DbSet<TransactionRecord> TransactionRecords { get; set; }

        // Add the transaction types
        public DbSet<TransactionType> TransactionTypes { get; set; }

        // Add the company models
        public DbSet<CompanyModel> CompanyModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Company Model 
            modelBuilder.Entity<CompanyModel>().HasData(
                new CompanyModel
                {
                    CompanyId = 1,
                    CompanyName = "Micorsoft",
                    CompanyAddress = "453 bill Gates Drive",
                    Ticker = "MSFT"
                },
                new CompanyModel
                {
                    CompanyId = 2,
                    CompanyName = "Google",
                    CompanyAddress = "123 Google Way",
                    Ticker = "GOOG"
                },
                new CompanyModel
                {
                    CompanyId = 3,
                    CompanyName = "Walmart",
                    CompanyAddress = "234 Walmart Street",
                    Ticker = "WMT"
                }
            );

            // Transaction Type
            modelBuilder.Entity<TransactionType>().HasData(
                new TransactionType
                {
                    TransactionTypeId = 1,
                    Name = "Buy",
                    Commission = 5.99
                },
                new TransactionType
                {
                    TransactionTypeId = 2,
                    Name = "Sell",
                    Commission = 5.40
                }
            );

            // Seed the TransactionRecord table
            modelBuilder.Entity<TransactionRecord>().HasData(
                new TransactionRecord
                {
                    TransactionRecordId = 1,
                    TransactionTypeId = 1,
                    Quantity = 100,
                    SharePrice = 123.45,
                    CompanyId = 1
                },
                new TransactionRecord
                {
                    TransactionRecordId = 2,
                    TransactionTypeId = 2,
                    Quantity = 100,
                    SharePrice = 2701.76,
                    CompanyId = 2
                },
                new TransactionRecord
                {
                    TransactionRecordId = 3,
                    TransactionTypeId = 1,
                    Quantity = 200,
                    SharePrice = 140.98,
                    CompanyId = 3
                }
            );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PROG2230_AS1_BMin.Models
{
    public class AssignmentContext :DbContext
    {
        // Add the default constructor
        public AssignmentContext(DbContextOptions<AssignmentContext> options)
            : base(options)
        { }

        // Add the transaction records
        public DbSet<TransactionRecord> TransactionRecords { get; set; }

        // Add the transaction types
        public DbSet<TransactionType> TransactionTypes { get; set; }

        /// <summary>
        /// The default seed function
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TransactionType>().HasData(
                new TransactionType
                {
                    TransactionTypeId = "B",
                    Name = "Buy",
                    Commission = 5.99
                },
                new TransactionType
                {
                    TransactionTypeId = "S",
                    Name = "Sell",
                    Commission = 5.40
                }
            );

            // Seed the TransactionRecord table
            modelBuilder.Entity<TransactionRecord>().HasData(
                new TransactionRecord
                {
                    TransactionRecordId = 1,
                    TransactionTypeId = "B",
                    CompanyName = "Microsoft",
                    TickerSymbol = "MSFT",
                    Quantity = 100,
                    SharePrice = 123.45,
                },
                new TransactionRecord
                {
                    TransactionRecordId = 2,
                    TransactionTypeId = "S",
                    CompanyName = "Google",
                    TickerSymbol = "GOOG",
                    Quantity = 100,
                    SharePrice = 2701.76
                },
                new TransactionRecord
                {
                    TransactionRecordId = 3,
                    TransactionTypeId = "B",
                    CompanyName = "Walmart",
                    TickerSymbol = "WMT",
                    Quantity = 200,
                    SharePrice = 140.98
                }
            );
        }
    }
}

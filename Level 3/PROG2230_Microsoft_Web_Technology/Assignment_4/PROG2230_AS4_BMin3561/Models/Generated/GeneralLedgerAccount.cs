/*
 * Program ID : Assignment 4
 *
 * Revision History : Created by Byounguk Min Nov 25, 2021
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PROG2230_AS4_BMin3561.Models.Generated
{
    [Table("general_ledger_accounts")]
    [Index(nameof(AccountDescription), Name = "UQ__general___EEFBAF028F602DC6", IsUnique = true)]
    public partial class GeneralLedgerAccount
    {
        public GeneralLedgerAccount()
        {
            InvoiceLineItems = new HashSet<InvoiceLineItem>();
            Vendors = new HashSet<Vendor>();
        }

        [Key]
        [Column("account_number")]
        public int AccountNumber { get; set; }
        [Column("account_description")]
        [StringLength(50)]
        public string AccountDescription { get; set; }

        [InverseProperty(nameof(InvoiceLineItem.AccountNumberNavigation))]
        public virtual ICollection<InvoiceLineItem> InvoiceLineItems { get; set; }
        [InverseProperty(nameof(Vendor.DefaultAccountNumberNavigation))]
        public virtual ICollection<Vendor> Vendors { get; set; }
    }
}

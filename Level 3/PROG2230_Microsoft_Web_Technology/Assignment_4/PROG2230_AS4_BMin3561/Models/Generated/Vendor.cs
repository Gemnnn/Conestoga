/*
 * Program ID : Assignment 4
 *
 * Revision History : Created by Byounguk Min Nov 25, 2021
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PROG2230_AS4_BMin3561.Models.Generated
{
    [Table("vendors")]
    [Index(nameof(VendorName), Name = "UQ__vendors__6107BA71F8130635", IsUnique = true)]
    public partial class Vendor
    {
        public Vendor()
        {
            Invoices = new HashSet<Invoice>();
        }
        //public IList<string> Alphabet
        //{
        //    get
        //    {
        //        var alphabet = Enumerable.Range(65, 26).Select(i => ((char)i).ToString()).ToList();
        //        //alphabet.Insert(0, "All");
        //        return alphabet;
        //    }
        //}
        //public List<string> FirstLetters { get; set; }
        //public string SelectedGroup { get; set; }

        [Key]
        [Column("vendor_id")]
        public int VendorId { get; set; }
        [Required]
        [Column("vendor_name")]
        [StringLength(256)]
        [RegularExpression(@"^[0-9a-zA-Z''-'\s]{1,}$",
        ErrorMessage = "special characters are not allowed.")]
        public string VendorName { get; set; }
        [Column("vendor_address1")]
        [StringLength(128)]
        public string VendorAddress1 { get; set; }
        [Column("vendor_address2")]
        [StringLength(128)]
        public string VendorAddress2 { get; set; }
        [Required]
        [Column("vendor_city")]
        [StringLength(64)]
        public string VendorCity { get; set; }
        [Required]
        [Column("vendor_state")]
        [RegularExpression(@"^[a-zA-Z]{2,2}$", ErrorMessage = "State must be 2 letters")]
        [StringLength(2)]
        public string VendorState { get; set; }
        [Required]
        [Column("vendor_zip_code")]
        [RegularExpression(@"^[0-9]{5}$", ErrorMessage = "Zip code must be 5 number")]
        [StringLength(20)]
        public string VendorZipCode { get; set; }
        [Column("vendor_phone")]
        [StringLength(50)]
        public string VendorPhone { get; set; }
        [Column("vendor_contact_last_name")]
        [StringLength(128)]
        public string VendorContactLastName { get; set; }
        [Column("vendor_contact_first_name")]
        [StringLength(128)]
        public string VendorContactFirstName { get; set; }
        [Column("vendor_contact_email")]
        [StringLength(128)]
        public string VendorContactEmail { get; set; }
        [Column("default_terms_id")]
        public int DefaultTermsId { get; set; }
        [Column("default_account_number")]
        public int DefaultAccountNumber { get; set; }
        [Column("is_deleted")]
        public bool IsDeleted { get; set; }

        [ForeignKey(nameof(DefaultAccountNumber))]
        [InverseProperty(nameof(GeneralLedgerAccount.Vendors))]
        public virtual GeneralLedgerAccount DefaultAccountNumberNavigation { get; set; }
        [ForeignKey(nameof(DefaultTermsId))]
        [InverseProperty(nameof(Term.Vendors))]
        public virtual Term DefaultTerms { get; set; }
        [InverseProperty(nameof(Invoice.Vendor))]
        public virtual ICollection<Invoice> Invoices { get; set; }

        public string getStart(string name)
        {
            char firstChar = char.Parse(name.Substring(0, 1).ToUpper());

            if (firstChar <= 'E')
            {
                return "A";
            }
    
            else if (firstChar <= 'K')
            {
                return "F";
            }
            else if (firstChar <= 'R')
            {
                return "L";
            }
            else
            {
                return "S";
            } 
        }
    }
}

/*
 * Program ID : Assignment 4
 *
 * Revision History : Created by Byounguk Min Nov 25, 2021
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROG2230_AS4_BMin3561.Models.Generated
{
    public class ViewModel
    {
        

        public Vendor ViewVendor { get; set; }
        public Term ViewTerm { get; set; }
        public IQueryable<Invoice> ViewInvoices { get; set; }
        public IQueryable<InvoiceLineItem> ViewInvoiceLineItems { get; set; }
        public InvoiceLineItem ViewInvoiceLineItem { get; set; }



    }
}

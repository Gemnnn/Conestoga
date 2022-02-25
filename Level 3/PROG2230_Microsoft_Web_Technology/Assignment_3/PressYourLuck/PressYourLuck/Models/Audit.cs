using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PROG2230_AS3_BM3561.Models
{
    public class Audit
    {
        [Key]
        [Required]
        public int AuditId { get; set; }

        [Required]
        public string PlayerName { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }

        [ForeignKey("AuditType")]
        public string AuditTypeId { get; set; }

        public AuditType AuditType { get; set; }

        public double Amount { get; set; }

        public Audit()
        {

        }

        public Audit(string auditType, string playerName, double amount)
        {
            AuditTypeId = auditType;
            PlayerName = playerName;
            Amount = amount;
            CreateDate = DateTime.Now;
        }
    }
}

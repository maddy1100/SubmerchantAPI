using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SubmerchantAPI.Models
{
    public class TerminateSubmerchant
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long TerminateID { get; set; }
        [MaxLength(20)]
        public string SubMerchantID { get; set; }
        public int TerminationReasonCode { get; set; }
        public char NoticePeriod { get; set; }
        public DateTime? TerminationDate { get; set; }
        public string OtherReason { get; set; }

        // Foreign key   
        [Display(Name = "PrimaryContact")]
        public virtual long PrimaryContactID { get; set; }

        [ForeignKey("PrimaryContactID")]
        public virtual PrimaryContact PrimaryContacts { get; set; }
    }
}

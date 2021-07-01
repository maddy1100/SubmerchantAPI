using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SubmerchantAPI.Models
{
    public class SubMerchantDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ProcessingDetailsID { get; set; }

        [Required]
        [MaxLength(20)]
        public string SubMerchantID { get; set; }


        public int? ApplicationStatus { get; set; }


        public int? PostUnderwritingSuccess { get; set; }


        public int? DataValidationStatus { get; set; }

        [MaxLength(250)]
        public string ValidationFailureReason { get; set; }

        // Data received from Windows Service
        public int? GNFStatus { get; set; }
        public string GNFFailureReason { get; set; }
        public int? RNFStatus { get; set; }
        public string RNFFailureReason { get; set; }
        public int? MCMatchStatus { get; set; }
        public string MatchFailureReason { get; set; }
        public int? VMASStatus { get; set; }
        public string VMASFailureReason { get; set; }
        public char? RecTypeH { get; set; }
        public char? RecTypeT { get; set; }
        public string SourceSystemName { get; set; }
        public DateTime? DateCreated { get; set; }
        public long? RecordCount { get; set; }



        //Foreign key
        [Display(Name = "PrimaryContact")]
        public virtual long PrimaryContactID { get; set; }

        [ForeignKey("PrimaryContactID")]
        public virtual PrimaryContact PrimaryContacts { get; set; }

    }
}

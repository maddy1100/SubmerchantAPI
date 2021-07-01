using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SubmerchantAPI.Models
{
    public class SubMerchantPostProcessingDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ProcessingDetailsID { get; set; }

        [Required]
        [MaxLength(20)]
        public string SubMerchantID { get; set; }

        
        public int ? ApplicationStatus { get; set; }

       
        public int ? PostUnderwritingSuccess { get; set; }

       
        public int ? DataValidationStatus { get; set; }

        [MaxLength(250)]
        public string ValidationFailureReason { get; set; }


        // Foreign key   
        [Display(Name = "PrimaryContact")]
        public virtual long PrimaryContactID { get; set; }

        [ForeignKey("PrimaryContactID")]
        public virtual PrimaryContact PrimaryContacts { get; set; }

    }
}

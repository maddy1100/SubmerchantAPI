using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SubmerchantAPI.Models.DbModels
{
    public class AuthorisationFees
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long AuthorisationFeesID { get; set; }

        
        public decimal ? AuthorisationPP { get; set; }

        
        public decimal ? AuthorisationfeePerTrasaction { get; set; }


       
        public decimal ? MinimumMerchantServiceCharge { get; set; }

        
        public decimal ? MonthlyPaperStatementFee { get; set; }

        
        public decimal ? ChargebackFee { get; set; }

       
        public decimal ? LatePaymentORReturnedDirectDebitFee { get; set; }

       
        public decimal ? AdministrationFee { get; set; }

       
        public decimal ? TerminalRecoveryFee { get; set; }

        
        public decimal ? FasterPaymentsFee { get; set; }

      
        public decimal ? PCIServiceFee3 { get; set; }

        
        public decimal ? PCINonComplianceFee4 { get; set; }

        // Foreign key   
        [Display(Name = "PrimaryContact")]
        public virtual long PrimaryContactID { get; set; }

        [ForeignKey("PrimaryContactID")]
        public virtual PrimaryContact PrimaryContacts { get; set; }


    }
}

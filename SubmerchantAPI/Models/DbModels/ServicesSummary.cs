using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SubmerchantAPI.Models.DbModels
{
    public class ServicesSummary
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ServicesSummaryID { get; set; }

      
        public int ? Terminal_Model { get; set; }

        [MaxLength(30)]
        public string Terminal_ContractPeriod { get; set; }

        
        public decimal ? Terminal_MonthlyRental { get; set; }

       
        public decimal ? MerchantRates_CreditCard { get; set; }

       
        public decimal ? MerchantRates_DebitCard { get; set; }

        
        public decimal ? MerchantRates_AuthorisationFee { get; set; }

      
        public decimal ? MerchantRates_MinimumMonthlyServiceFee { get; set; }

        
        public decimal ? SetUpFee_FeeAmount { get; set; }

        
        public decimal ? SetUpFee_AmexFee { get; set; }


        // Foreign key   
        [Display(Name = "PrimaryContact")]
        public virtual long PrimaryContactID { get; set; }

        [ForeignKey("PrimaryContactID")]
        public virtual PrimaryContact PrimaryContacts { get; set; }
    }
}

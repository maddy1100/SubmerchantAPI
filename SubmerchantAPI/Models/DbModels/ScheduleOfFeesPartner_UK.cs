using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SubmerchantAPI.Models.DbModels
{
    public class ScheduleOfFeesPartner_UK
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long PartnersUKID { get; set; }

        [MaxLength(200)]
        public string VisaCreditCardSecureRate { get; set; }


        public decimal? MasterCardCreditCardSecureRate { get; set; }


        public decimal? VisaDebitCardSecureRate { get; set; }


        public decimal? MasterCardDebitCardSecureRate { get; set; }


        public decimal? VisaVPayCardSecureRate { get; set; }


        public decimal? UKMaestroCardSecureRate { get; set; }


        public decimal? InternationalMaestroCardSecureRate { get; set; }


        public decimal? VisaBusinessCreditCardSecureRate { get; set; }


        public decimal? VisaBusinessDebitCardSecureRate { get; set; }


        public decimal? VisaPurchasingCardSecureRate { get; set; }


        public decimal? VisaCorporateCardSecureRate { get; set; }


        public decimal? MasterCardBusinessCardSecureRate { get; set; }


        public decimal? MasterCardPurchasingCardSecureRate { get; set; }


        public decimal? MasterCardFleetCardSecureRate { get; set; }


        public decimal? MasterCardCorporateCardSecureRate { get; set; }


        public decimal? MasterCardPrePaidCommercialCardSecureRate { get; set; }


        public decimal? NonEEAVisaCardSecureRate { get; set; }


        public decimal? NonEEAMasterCardCreditCardSecureRate { get; set; }


        public decimal? DinersCardSecureRate { get; set; }


        public decimal? JCBCardSecureRate { get; set; }


        public decimal? UnionPayCardSecureRate { get; set; }


        public decimal? UnionPay { get; set; }
        // Foreign key   
        [Display(Name = "PrimaryContact")]
        public virtual long PrimaryContactID { get; set; }

        [ForeignKey("PrimaryContactID")]
        public virtual PrimaryContact PrimaryContacts { get; set; }
    }
}

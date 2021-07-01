using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SubmerchantAPI.Models.DbModels
{
    public class AdditionalCustomerInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CustomerInfoID { get; set; }

        [Required]

        public decimal TotalCreditCardSales { get; set; }

        public bool? NA { get; set; }

        public char? CurrentProvider { get; set; }


        public decimal? SettlementAmount { get; set; }


        public int? NoticePeriod { get; set; }


        public decimal? ProjectedAnnualTurnover { get; set; }


        public decimal? ProjectedAnnualCardTurnover { get; set; }


        public decimal? AverageTransactionValue { get; set; }


        public decimal? RealisticMinTransactionValue { get; set; }

        public decimal? RealisticMaxTransactionValue { get; set; }

        // Foreign key   
        [Display(Name = "PrimaryContact")]
        public virtual long PrimaryContactID { get; set; }

        [ForeignKey("PrimaryContactID")]
        public virtual PrimaryContact PrimaryContacts { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SubmerchantAPI.Models.DbModels
{
    public class MerchantAccountConfiguration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long AccConfigID { get; set; }


        public int ? MerchantBankAcquirer { get; set; }


        public long ? MerchantAccountNumber { get; set; }


        public int ? AmericanExpressID { get; set; }

        [MaxLength(20)]
        public string TillReceipts { get; set; }


        public char ? OutgoingCall { get; set; }


        public int ? AreaCode { get; set; }

        [MaxLength(20)]
        [DataType(DataType.PhoneNumber)]
        public string Landline { get; set; }

        // Foreign key   
        [Display(Name = "PrimaryContact")]
        public virtual long PrimaryContactID { get; set; }

        [ForeignKey("PrimaryContactID")]
        public virtual PrimaryContact PrimaryContacts { get; set; }
    }
}

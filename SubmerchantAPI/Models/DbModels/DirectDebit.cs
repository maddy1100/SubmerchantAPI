using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SubmerchantAPI.Models.DbModels
{
    public class DirectDebit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long DirectDebitID { get; set; }

      
        public int ? BankOrBuildingSocietyAccountNumber { get; set; }

        
        public int ? SortCode { get; set; }

        
        public int ? ReferenceNumber { get; set; }

        [MaxLength(20)]
        public string NameOfBank { get; set; }

        [MaxLength(30)]
        public string PostalAddress { get; set; }

        [MaxLength(30)]
        public string AccountHolderName { get; set; }


        // Foreign key   
        [Display(Name = "PrimaryContact")]
        public virtual long PrimaryContactID { get; set; }

        [ForeignKey("PrimaryContactID")]
        public virtual PrimaryContact PrimaryContacts { get; set; }
    }
}

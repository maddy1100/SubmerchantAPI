using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SubmerchantAPI.Models.DbModels
{
    public class BankDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long BankDetailsID { get; set; }


        [MaxLength(20)]
        public string NatureOfBusiness { get; set; }

        [MaxLength(20)]
        public string NameOfBank { get; set; }

        [MaxLength(20)]
        public string NameOfAccount { get; set; }

        
        public int ? SortCode { get; set; }

        
        public int ? BranchPostCode { get; set; }

       
        public long ? AccountNumber { get; set; }

        
        public char ? BusinessOrPersonal { get; set; }

        [MaxLength(3)]
        public string ApplicationCurrency { get; set; }

        // Foreign key   
        [Display(Name = "PrimaryContact")]
        public virtual long PrimaryContactID { get; set; }

        [ForeignKey("PrimaryContactID")]
        public virtual PrimaryContact PrimaryContacts { get; set; }
    }
}
